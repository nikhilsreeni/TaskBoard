using System;
using System.Collections.Generic;

namespace TaskBoard.DoaminModel
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
        public Guid Id { get; set; }

        public List<Epic> Epic { get; set; }
    }
}