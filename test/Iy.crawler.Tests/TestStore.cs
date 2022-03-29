namespace Iy.crawler.Tests;

public static class TestStore
{
    public static string GetHtmlString(int aTagCount = 0, int imgTagCount = 0)
    {
        var aTags = "";
        for (var i = 1; i <= aTagCount; i++)
        {
            aTags += $"<a href=\"www.site-{i}.com\">site-{i}</a>";
        }

        var imgTags = "";
        for (var i = 1; i <= imgTagCount; i++)
        {
            imgTags += $"<img src=\"www.site-x.com/img-{i}.jpg\"></img>";
        }

        return "<html>" +
               "<head>" +
               "<title>I'm title</title>" +
               "</head><body>" +
               aTags +
               imgTags +
               "</body>" +
               "</html>";
    }
}