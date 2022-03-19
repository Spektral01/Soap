using AngleSharp.Html.Dom;

namespace Parser.Core
{
    //Обобщенный интерфейс для возвращения любого типа
    interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document);

    }
}
