using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuoteWall.Models;

namespace QuoteWall.DOA
{
    public class WallDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
    public class QuoteDOA
    {
        
    }
}