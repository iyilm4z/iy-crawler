using HtmlAgilityPack;

namespace Iy.Crawler.Parsing;

public interface IUrlParser
{
    List<string> Parse(HtmlDocument htmlDocument);
}