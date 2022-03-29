using HtmlAgilityPack;

namespace Iy.Crawler.Parsing;

public class ImgTagUrlParser : IUrlParser
{
    public List<string> Parse(HtmlDocument htmlDocument)
    {
        var nodes = htmlDocument.DocumentNode.SelectNodes("//img[@src]");

        var urls = new List<string>();

        if (nodes == null || !nodes.Any())
        {
            return urls;
        }

        foreach (var link in nodes)
        {
            var srcValue = link.GetAttributeValue("src", string.Empty);
            if (srcValue != string.Empty)
            {
                urls.Add(srcValue);
            }
        }

        return urls;
    }
}