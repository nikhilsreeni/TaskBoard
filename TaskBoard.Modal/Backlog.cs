using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Model
{
    public class Task
    {
        public string Title { get; set; }
    }

    public class Scenario
    {
        public string Title { get; set; }
        public List<Task> Task { get; set; }
    }

    public class UserStory
    {
        public string Title { get; set; }
        public List<Scenario> Scenario { get; set; }
    }

    public class Feature
    {
        public string Title { get; set; }
        public List<UserStory> UserStory { get; set; }
    }

    public class Epic
    {
        public string Title { get; set; }
        public List<Feature> Feature { get; set; }
    }

    public class Backlog
    {
        [BsonId(IdGenerator = typeof(GuidIdGenerator))]
        public Guid Id { get; set; }

        public List<Epic> Epic { get; set; }
    }

    public class GuidIdGenerator : IIdGenerator
    {
        public object GenerateId(object container, object document)
        {
            return  Guid.NewGuid();
        }
        public bool IsEmpty(object id)
        {
            return string.IsNullOrEmpty(id.ToString());
        }
    }
}
