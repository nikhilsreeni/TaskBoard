
using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskBoard.Model;

namespace TaskBoard.Repository
{
    public class ElasticSearchContext
    {
        ElasticClient client = null;
        public ElasticSearchContext()
        {
            //var pool = new SniffingConnectionPool(new[] { new Uri("http://localhost:9200") });
            //var lowLevelClient = new ElasticsearchClient(new ConnectionConfiguration(pool));
            //var lowLevelResponse = lowLevelClient.IndicesExists<dynamic>("foo");
            var uri = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(uri).BasicAuthentication("elastic", "changeme");

            client = new ElasticClient(settings);
            settings.DefaultIndex("backlog");

        }
        public List<Backlog> GetResult()
        {
            if (client.IndexExists("backlog").Exists)
            {
                var response = client.Search<Backlog>();
                return response.Documents.ToList();
            }
            return null;
        }

        public List<Backlog> GetResult(string condition)
        {
            if (client.IndexExists("backlog").Exists)
            {
                var query = condition;

                return client.SearchAsync<Backlog>(s => s
                .From(0)
                .Take(10)
                .Query(qry => qry
                    .Bool(b => b
                        .Must(m => m
                            .QueryString(qs => qs
                                .DefaultField("_all")
                                .Query(query)))))).Result.Documents.ToList();
            }
            return null;
        }

        public void AddNewIndex(Backlog model)
        {
            //Create Index 
            client.CreateIndex("Backlog", c =>
            c.Mappings(ms => ms.Map<Backlog>(m => m.AutoMap())));

            var settings = new IndexSettings { NumberOfReplicas = 1, NumberOfShards = 2 };

            var indexConfig = new IndexState
            {
                Settings = settings
            };

            if (!client.IndexExists("backlog").Exists)
            {
                client.CreateIndex("backlog", c => c
                .InitializeUsing(indexConfig)
                .Mappings(m => m.Map<Backlog>(mp => mp.AutoMap())));
            }

            client.Index(model);
        }

       
    }

}
