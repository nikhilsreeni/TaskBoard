using System;

namespace TaskBoard.API.Models
{
    public class Comment
    {
        public DateTime id { get; set; }
        public string author { get; set; }
        public string text { get; set; }
    }
}