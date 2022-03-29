namespace Iy.Crawler.Parsing;

public interface IUrlParserProvider
{
    List<IUrlParser> GetUrlParsers();
}