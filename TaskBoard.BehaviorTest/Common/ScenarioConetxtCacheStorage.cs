using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.Common
{
    public class ScenarioConetxtCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            ScenarioContext.Current.Remove(key);
        }

        public void Store(string key, object data)
        {
            ScenarioContext.Current.Add(key, data);
        }

        public T Retrieve<T>(string key)
        {
            var itemsStored = ScenarioContext.Current.Get<T>(key);
            if (itemsStored == null)
            {
                itemsStored = default(T);
            }
            return itemsStored;
        }
    }
}