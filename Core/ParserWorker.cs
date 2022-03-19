using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    //Тело парсера
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        bool isActive;
        #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {

            }
        }

        #endregion

        public event Action<object, T, int, int> OnNewData;
        public Action<object> OnCompleted;
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort() //Для остановки парсинга
        {
            isActive = false;
        }
        //Работа парсера
        private async void Worker()
        {
            int pageValue = 1, i = 0;
            while (i++ < pageValue)
            {
                if (!isActive) //Если решили остановить парсер Abort()
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceByPageId(i); // {CurrentId}=i для реализации перехода по страницам
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document); //Парсинг необходимых данных
                if (i == 1) //Парсим количество страниц
                {
                    var page = document.QuerySelector(".paginator:nth-last-of-type(2)");
                    if (page != null) pageValue = int.Parse(page.GetAttribute("title"));
                }
                OnNewData?.Invoke(this, result, i, pageValue);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
