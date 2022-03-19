using Parser;
using System;

namespace Parser.Core.Postupi
{
    //Реализация интерфейса для url
    class PostupiSettings : IParserSettings
    {
        public PostupiSettings(string https, string City, string BUrl, string Fltr)
        {
            BaseUrl = BUrl;
            Filter = Fltr;
            FCity = City;
            Https = https;
        }
        public string Https { get; set; }
        public string FCity { get; set; }
        public string BaseUrl { get; set; }
        public string Filter { get; set; }
        public string FPage { get; set; } = "page_num={CurrentId}";
    }
}
