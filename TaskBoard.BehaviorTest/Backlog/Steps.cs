using MongoDB.Driver;
using System;
using System.Collections.Generic;
using TaskBoard.Repository.Repository;
using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.Backlog
{
    [Binding]
    public class BacklogDataListSteps
    {
        MongoDBRepository mongoDBRepository = new MongoDBRepository();

        [Given(@"I have entered (.*) into the calculator")]
        public async void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
           
            var xx = await mongoDBRepository.GetAll<Model.Backlog>().ToListAsync();

            //var cc = await mongoDBRepository.GetAll<Model.Backlog>();

            //var myTypes = await mongoDBRepository.GetFiltered(t => t.Id != 1 as object).ToListAsync();

            //ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            mongoDBRepository.Add(new Model.Backlog { Epic = new List<Model.Epic> { new Model.Epic { Title = "Epic 3" } }, Id = Guid.NewGuid() });
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public async void  ThenTheResultShouldBeOnTheScreen(int p0)
        {
            var xx = await mongoDBRepository.GetAll<Model.Backlog>().ToListAsync();
        }


        [Given(@"i have backlog list")]
        public void GivenIHaveBacklogList()
        {
            


            ElasticSearchRepository ElasticSearchRepository = new ElasticSearchRepository();

            ElasticSearchRepository.AddNewIndex(new Model.Backlog { Epic = new List<Model.Epic> { new Model.Epic { Title = "Epic 1" } }, Id = Guid.NewGuid() });
            ElasticSearchRepository.AddNewIndex(new Model.Backlog { Epic = new List<Model.Epic> { new Model.Epic { Title = "Epic 2" } }, Id = Guid.NewGuid() });
            ElasticSearchRepository.AddNewIndex(new Model.Backlog { Epic = new List<Model.Epic> { new Model.Epic { Title = "Epic 3" } }, Id = Guid.NewGuid() });
        }

        [When(@"I save the backlog")]
        public void WhenISaveTheBacklog()
        {
            
        }

        [Then(@"i can search the backlog")]
        public void ThenICanSearchTheBacklog()
        {
            ElasticSearchRepository ElasticSearchRepository = new ElasticSearchRepository();
           var xx= ElasticSearchRepository.GetResult();
        }

    }
}
