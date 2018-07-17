using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuoteWall.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Person Author { get; set; }
        public Person Approver { get; set; }
        public DateTime DateCreated { get; set; }
        public string Context { get; set; }
    }
}