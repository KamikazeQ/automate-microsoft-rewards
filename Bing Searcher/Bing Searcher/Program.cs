using System;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Bing_Searcher
{
    class Program
    {

        /*
         * Current build is being tested/developed with Microsoft Edge (EdgeHTML) version 18.  So user will need to do the following to enable the Web Driver
         * 
         * Enable Developer Mode by going to Settings > Update and Security > For Developer
         */

        static void Main(string[] args)
        {
            List<string> searchWords = new List<string>() {"cat", "ai", "duck", "hero", "dog", "girl", "man", "cow", "clown", "woman",
              "tree", "building", "bike", "motorcycle", "crimefighter", "shoe", "plane", "pig", "mop", "broom",
              "plant", "kitty", "bang", "butt", "ball", "scooter", "tube", "mouse", "dart", "gun",
              "goose", "bear", "television", "window"};

            // Opens IE Edge
            /*
            using (IWebDriver driver = new EdgeDriver())
            {
                driver.Navigate().GoToUrl("http://www.bing.com/");
            }
            */

            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl(@"http://www.bing.com");

            // Search

            foreach (string word in searchWords)
            {
                IWebElement elem = driver.FindElement(By.Name("q"));
                elem.Clear();
                Thread.Sleep(2000);
                elem.SendKeys("What is a " + word + "?");
                Thread.Sleep(2000);
                elem.SendKeys(Keys.Return);
                Thread.Sleep(3000);
            }

            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
