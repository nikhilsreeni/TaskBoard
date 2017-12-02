using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using TaskBoard.BehaviorTest.Common;
using TaskBoard.PersistenceModel;
using TaskBoard.Repository.Repository;
using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.Backlog
{
    [Binding]
    public class BacklogDataListSteps
    {
        private readonly MongoDBRepository mongoDBRepository = new MongoDBRepository();

        [Given(@"I have entered (.*) into the calculator")]
        public async void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            var xx = await mongoDBRepository.GetAll<PersistenceModel.Backlog>().ToListAsync();

            //var cc = await mongoDBRepository.GetAll<PersistenceModel.Backlog>();

            //var myTypes = await mongoDBRepository.GetFiltered(t => t.Id != 1 as object).ToListAsync();

            //ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            string[] nameList = {"Raju", "Ravi", "Soman"};
            var randamName = nameList.ToList().PickRandom();
            mongoDBRepository.Add(
                new PersistenceModel.Backlog
                {
                    Epic =
                        new List<Epic>
                        {
                            new Epic {Title = randamName}
                        },
                    Id = Guid.NewGuid()
                });
        }

        [Then(@"the result should be (.*) on the screen")]
        public async void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            var xx = await mongoDBRepository.GetAll<PersistenceModel.Backlog>().ToListAsync();
        }


        [Given(@"i have backlog list")]
        public void GivenIHaveBacklogList()
        {
            var ElasticSearchRepository = new ElasticSearchRepository();

            ElasticSearchRepository.AddNewIndex(new PersistenceModel.Backlog
            {
                Epic = new List<Epic> {new Epic {Title = "Epic 1"}},
                Id = Guid.NewGuid()
            });
            ElasticSearchRepository.AddNewIndex(new PersistenceModel.Backlog
            {
                Epic = new List<Epic> {new Epic {Title = "Epic 2"}},
                Id = Guid.NewGuid()
            });
            ElasticSearchRepository.AddNewIndex(new PersistenceModel.Backlog
            {
                Epic = new List<Epic> {new Epic {Title = "Epic 3"}},
                Id = Guid.NewGuid()
            });
        }

        [When(@"I save the backlog")]
        public void WhenISaveTheBacklog()
        {
        }

        [Then(@"i can search the backlog")]
        public void ThenICanSearchTheBacklog()
        {
            var ElasticSearchRepository = new ElasticSearchRepository();
            var xx = ElasticSearchRepository.GetResult();
        }
    }
}