namespace Iy.Crawler.Parsing;

public class UrlParserProvider : IUrlParserProvider
{
    public List<IUrlParser> GetUrlParsers()
    {
        return new List<IUrlParser>
        {
            new AnchorTagUrlParser(),
            new ImgTagUrlParser()
        };
    }
}