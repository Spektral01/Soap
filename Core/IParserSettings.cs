using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    //Объявление интерфейса для url
    interface IParserSettings
    {
        string Https { get; set; }
        string Filter { get; set; }
        string FCity { get; set; }
        string BaseUrl { get; set; }
        string FPage { get; set; }
    }
}
