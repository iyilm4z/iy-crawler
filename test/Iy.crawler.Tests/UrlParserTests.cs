using Iy.Crawler.Parsing;
using Xunit;

namespace Iy.crawler.Tests;

public class UrlParserTests
{
    [Fact]
    public void Parse_Should_Return_Urls_Or_Empty()
    {
        var urlParser = new UrlParser(new UrlParserProvider());

        var htmlString1 = TestStore.GetHtmlString();
        var urls1 = urlParser.Parse(htmlString1);

        Assert.Empty(urls1);

        var htmlString2 = TestStore.GetHtmlString(3, 2);
        var urls2 = urlParser.Parse(htmlString2);

        Assert.Equal(5, urls2.Count);
    }
}