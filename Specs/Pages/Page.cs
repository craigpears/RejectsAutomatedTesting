using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specs.Pages
{
    public abstract class Page
    {
        private By _pageTag = By.CssSelector("div[data-test-page]");
        protected IWebDriver _driver = new ChromeDriver(@"C:\Projects\RejectsAutomatedTesting\Specs\Selenium");
        protected string _pageName;

        /// <summary>
        /// All pages for testing must have a div with a data-test-page attribute.  
        /// The pageName parameter is the value of the attribute that identifies that the page is visible.
        /// </summary>
        /// <param name="pageName">The data-test-page attribute value for this page</param>
        public Page(string pageName)
        {
            _pageName = pageName;
        }

        /// <summary>
        /// Checks if you are currently at the page
        /// </summary>
        /// <returns></returns>
        public bool AtPage()
        {
            var pageTags = _driver.FindElements(_pageTag);
            foreach (var tag in pageTags)
            {
                var tagPageName = tag.GetAttribute("data-test-page");
                if(_pageName.Trim() == tagPageName.Trim())
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Checks if you are at the page and goes to it if you aren't
        /// </summary>
        public virtual void GetToPage()
        {
            if (!AtPage())
            {
                GoToPage();
            }
        }

        /// <summary>
        /// Executes the steps to go to the page, even if you are already there
        /// </summary>
        public virtual void GoToPage()
        {
            throw new NotImplementedException();
        }
    }
}
