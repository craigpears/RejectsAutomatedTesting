using Specs.Pages;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class RejectsSteps
    {
        protected RejectsTab _page = new RejectsTab();

        [Given(@"I am at the rejects tab")]
        public void GivenIAmAtTheRejectsTab()
        {
            _page.GetToPage();
        }
        
        [Given(@"There are (.*) rejects")]
        public void GivenThereAreRejects(int expectedNumberOfRejects)
        {
            _page.GoToPage(); // refreshes back to a state where there are no packs
            for (int i = 0; i < expectedNumberOfRejects; i++)
            {
                _page.AddAnyBadPack();
            }
        }
        
        [When(@"I add (.*) packs?")]
        public void WhenIAddBadPack(int numberOfPacksToAdd)
        {
            for(int i = 0; i < numberOfPacksToAdd; i++)
            {
                _page.AddAnyBadPack();
            }
        }
        
        [Then(@"the result should be (.*) packs? on the screen")]
        public void ThenTheResultShouldBeBadPackOnTheScreen(int expectedNumberOfPacks)
        {
            var actualNumber = _page.GetNumberOfRejects();
            if (actualNumber != expectedNumberOfPacks)
            {
                throw new Exception(String.Format("Expected {0} bad packs, but there were {1}", expectedNumberOfPacks, actualNumber));
            }
        }

        [When(@"Save Changes")]
        public void WhenSaveChanges()
        {
            _page.SaveChanges();
        }

        [When(@"Refresh")]
        [When(@"I Refresh")]
        public void WhenRefresh()
        {
            _page.Refresh();
        }

        [When(@"I add packs")]
        public void WhenIAddPacks(Table packNumbers)
        {
            foreach (var row in packNumbers.Rows)
            {
                var packNumber = int.Parse(row[0]);
                _page.AddPack(packNumber);
            }
        }

        [Then(@"I should see packs")]
        public void ThenIShouldSeePacks(Table expectedPacks)
        {
            var actualPacks = _page.GetPacks();
            var actualCount = actualPacks.Count;
            var expectedCount = expectedPacks.RowCount;
            if (actualCount != expectedCount)
            {
                throw new Exception(String.Format("Expected to see {0} packs but there were {1}", expectedCount, actualCount));
            }

            foreach (var row in expectedPacks.Rows)
            {
                var expectedStatus = row[0];
                var packNumber = int.Parse(row[1]);
                var pack = actualPacks.SingleOrDefault(x => x.PackNumber == packNumber);

                if (pack == null)
                {
                    throw new Exception(String.Format("Couldn't find pack {0}", packNumber));
                }

                if(!actualPacks.Any(x => x.PackNumber == packNumber && pack.Status == expectedStatus))
                {
                    throw new Exception(String.Format("Pack {0} has status {1} instead of {2}", packNumber, pack.Status, expectedStatus));
                }
            }
        }

        [Given(@"There are rejects")]
        public void GivenThereAreRejects(Table initialRejects)
        {
            foreach (var row in initialRejects.Rows)
            {
                var expectedStatus = row[0];
                var packNumber = int.Parse(row[1]);
                _page.AddPack(packNumber, expectedStatus);
            }
        }

        [When(@"I bulk update packs (.*) - (.*) to (.*)")]
        public void WhenIBulkUpdatePacks(int startPackNumber, int endPackNumber, string targetStatus)
        {
            _page.BulkUpdate(startPackNumber, endPackNumber, targetStatus);
        }
    }
}
