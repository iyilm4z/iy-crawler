using HtmlAgilityPack;

namespace Iy.Crawler.Parsing;

public class AnchorTagUrlParser : IUrlParser
{
    public List<string> Parse(HtmlDocument htmlDocument)
    {
        var nodes = htmlDocument.DocumentNode.SelectNodes("//a[@href]");

        var urls = new List<string>();

        if (nodes == null || !nodes.Any())
        {
            return urls;
        }

        foreach (var link in nodes)
        {
            var hrefValue = link.GetAttributeValue("href", string.Empty);
            if (hrefValue != string.Empty)
            {
                urls.Add(hrefValue);
            }
        }

        return urls;
    }
}