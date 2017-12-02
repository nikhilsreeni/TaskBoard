using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.Common
{
    public class FeatureConetxtCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            FeatureContext.Current.Remove(key);
        }

        public void Store(string key, object data)
        {
            FeatureContext.Current.Add(key, data);
        }

        public T Retrieve<T>(string key)
        {
            var itemsStored = FeatureContext.Current.Get<T>(key);
            if (itemsStored == null)
            {
                itemsStored = default(T);
            }
            return itemsStored;
        }
    }
}