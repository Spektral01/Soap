using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Postupi
{
    //Парсинг данных
    class PostupiParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>(); //Спарсенные данные будут записываться в список, который в последствии преобразуется в массив
            
            var visibleMid = document.QuerySelectorAll("b.visible-mid"); //удаление повторных слов
            for (int i = 0; i < visibleMid.Length; i++)
            {
                visibleMid[i].TextContent = "";
            }
            var items = document.QuerySelectorAll(".list"); //Сбор данных с блока

            foreach (var item in items) //Проходимся по каждому элементу
            {
                list.Add(item.Children[1].Children[0].Children[0].Children[1].TextContent); //Название вуза или специализации 
                list.Add(item.Children[1].Children[0].Children[0].Children[1].Children[0].GetAttribute("href")); //Ссылка на вузы или специализацию

                for (int i = 0; i < item.Children[1].Children[0].Children[1].ChildElementCount - 1; i++)
                {
                    list.Add("\t" + item.Children[1].Children[0].Children[1].Children[i].Children[0].TextContent +
                        ":\t\t" + item.Children[1].Children[0].Children[1].Children[i].Children[1].TextContent + " " +
                        item.Children[1].Children[0].Children[1].Children[i].Children[2].TextContent); //Баллы, бюджет
                }

                try //Стоимость обучения может отсутствовать
                {
                    list.Add("\tСтоимость обучения: \t\tот " + item.Children[0].Children[1].Children[0].TextContent + "р/год"); //Стоимость обучения
                }
                catch
                {

                }

                list.Add("");
            }
            return list.ToArray();
        }
    }
}
