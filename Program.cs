using System;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YoutubeViewBot
{
    class MainClass
    {
        static URLScanner scanner;

        static IWebDriver driver;
        static string[] urls = { "URL HERE", "URL HERE" };
        static int delay = 10;

        public static void Main(string[] args) {
            driver = new ChromeDriver();
            scanner = new URLScanner();
            watch();
        }

        static void watch() {
            while (true)
            {
                for (int i = 0; i < urls.Length; i++)
                {
                    Thread.Sleep(delay * 1000);

                    // Seeing if the url is a youtube video url
                    bool canGoToURL = scanner.scanURL(urls[i].ToLower());

                    if (canGoToURL)
                    {
                        driver.Url = urls[i];
                        Thread.Sleep(1000);

                        driver.FindElement(By.ClassName("ytp-play-button")).Click();
                    }
                    else
                    {
                        Console.WriteLine("You cannot access this site or video");
                    }
                }
            }
        }
    }   
}
