using System;
namespace YoutubeViewBot
{
    public class URLScanner
    {
        public bool scanURL(string url)
        {

            if (url.StartsWith("https://www.youtube.com/watch?") || url.StartsWith("http://www.youtube.com/watch?") || url.StartsWith("https://youtube.com/watch?") || url.StartsWith("http://youtube.com/watch?"))
            {
                return true;
            }
            return false;
        }
    }
}
