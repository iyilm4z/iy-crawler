namespace Iy.Crawler.Fetching;

public class PageFetcher : IPageFetcher
{
    private readonly HttpClient _httpClient;

    public PageFetcher(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FetchPageResult> FetchPage(Uri uri)
    {
        var response = await _httpClient.GetStringAsync(uri);
        
        return new FetchPageResult
        {
            Response = response
        };
    }
}