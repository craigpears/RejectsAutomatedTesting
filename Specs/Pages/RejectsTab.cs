using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specs.Pages
{
    public class RejectsTab : Page
    {
        public RejectsTab():base("rejectsTab")
        {

        }

        public class Pack
        {
            public string Status { get; set; }
            public int PackNumber { get; set; }
        }

        public override void GoToPage()
        {
            _driver.Url = "http://localhost:58224/";
        }

        public void AddAnyBadPack()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("addBadPack('x');");
        }

        public void AddPack(int packNumber, string status = "Bad")
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("addPack("+ packNumber + ",'"+status+"');");
        }
        
        public int GetNumberOfRejects()
        {
            return _driver.FindElements(By.ClassName("rejectRow")).Count();          
        }

        public void SaveChanges()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("saveChanges();");
        }

        public void Refresh()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("refresh();");
        }

        public List<Pack> GetPacks()
        {
            return _driver
                .FindElement(By.ClassName("rejectsContainer"))
                .FindElements(By.ClassName("rejectRow"))
                .Select(x => new Pack
                {
                    Status = x.FindElement(By.ClassName("status")).Text,
                    PackNumber = int.Parse(x.FindElement(By.ClassName("packNumber")).Text)
                })
                .ToList();
        }

        public void BulkUpdate(int startPackNumber, int endPackNumber, string targetStatus)
        {
            for(int i = startPackNumber; i <= endPackNumber; i++)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript(String.Format("addPack({0},'{1}');", i, targetStatus));
            }
        }
    }
}
