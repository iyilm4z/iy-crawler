using Iy.Crawler.Parsing;
using Shouldly;
using Xunit;

namespace Iy.Crawler.Tests.Parsing;

public class UrlParserTests
{
    [Fact]
    public void Parse_Should_Return_Urls_Or_Empty()
    {
        var urlParser = new UrlParser(new UrlParserProvider());

        var htmlString1 = TestStore.GetHtmlString();
        var urls1 = urlParser.Parse(htmlString1);

        urls1.ShouldBeEmpty();

        var htmlString2 = TestStore.GetHtmlString(3, 2);
        var urls2 = urlParser.Parse(htmlString2);

        5.ShouldBe(urls2.Count);
    }
}