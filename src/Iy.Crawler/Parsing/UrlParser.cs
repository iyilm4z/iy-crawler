using HtmlAgilityPack;

namespace Iy.Crawler.Parsing;

public class UrlParser
{
    private readonly IUrlParserProvider _urlParserProvider;

    public UrlParser(IUrlParserProvider urlParserProvider)
    {
        _urlParserProvider = urlParserProvider;
    }

    public List<string> Parse(string htmlString)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(htmlString);

        var urlParsers = _urlParserProvider.GetUrlParsers();

        var urls = new List<string>();

        foreach (var urlParser in urlParsers)
        {
            var parsedUrls = urlParser.Parse(doc);
            if (parsedUrls.Any())
            {
                urls.AddRange(parsedUrls);
            }
        }

        return urls;
    }
}