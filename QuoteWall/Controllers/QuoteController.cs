using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuoteWall.Models;
using QuoteWall.DOA;

namespace QuoteWall.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Random()
        {
            //Quote quote = new Quote() {Name = "Hello World" };
            WallDbContext context = new WallDbContext();
            var query = from x in context.Quotes
                        where x.Id == 1
                        select x;
            Quote quote = query.FirstOrDefault<Quote>();
            return View(quote);
            /*
            context.Quotes.Add(quote);
            context.SaveChanges();
            */
            //return View(quote);
        }
    }
}