using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuoteWallConsole
{
    public class Quote
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class WallDbContext: DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            WallDbContext context = new WallDbContext();
            Quote quote = new Quote();
            quote.Id = 2;
            quote.Name = "Success";
            context.Quotes.Add(quote);
            context.SaveChanges();
            /*
            using (var context = new WallDbContext())
            {
                var quote = new Quote()
                {
                    Id= 1,
                    Name = "Gates"
                };
                context.Quotes.Add(quote);

                context.SaveChanges();
            }*/

        }
    }
}
