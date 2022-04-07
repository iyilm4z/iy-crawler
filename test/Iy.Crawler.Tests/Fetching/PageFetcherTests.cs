using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Iy.Crawler.Fetching;
using Shouldly;
using Xunit;

namespace Iy.Crawler.Tests.Fetching;

public class PageFetcherTests
{
    [Fact]
    public async Task FetchPage_Should_Return_PageFetchResult()
    {
        var response = TestStore.GetHtmlString(3, 5);
        var messageHandler = new MockHttpMessageHandler(response, HttpStatusCode.OK);
        var httpClient = new HttpClient(messageHandler);
        var pageFetcher = new PageFetcher(httpClient);

        var result = await pageFetcher.FetchPage(new Uri("http://www.foo.com"));

        response.ShouldBe(result.Response);
    }
}