using MongoDB.Driver;
using System;
using TaskBoard.Repository.Repository;
using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.Backlog
{
    [Binding]
    public class BacklogDataListSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public async void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            MongoDBRepository mongoDBRepository = new MongoDBRepository();


            var xx = await mongoDBRepository.GetAll<Model.Backlog>().ToListAsync();


            //var cc = await mongoDBRepository.GetAll<Model.Backlog>();

            //var myTypes = await mongoDBRepository.GetFiltered(t => t.Id != 1 as object).ToListAsync();

            //ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
