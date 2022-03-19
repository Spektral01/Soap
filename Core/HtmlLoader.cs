using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Parser.Core
{
    //Загружает исходный код страницы из полученных настроек
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.Https}{settings.FCity}{settings.BaseUrl}{settings.Filter}{settings.FPage}"; //Реализация url
        }

        public async Task<string> GetSourceByPageId(int id) //Замена {CurrentId} для парсинга
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string sourse = null;
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            return sourse;
        }
    }
}
