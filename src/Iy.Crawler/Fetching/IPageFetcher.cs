namespace Iy.Crawler.Fetching;

public interface IPageFetcher
{
    Task<FetchPageResult> FetchPage(Uri uri);
}