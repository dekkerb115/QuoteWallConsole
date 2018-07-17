using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuoteWall.Models;
using QuoteWall.DOA;

namespace QuoteWall.Controllers
{
    public class HomeController : Controller
    {
        public WallDbContext context = new WallDbContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var query = from x in context.Quotes
                        select x;
            var quoteList = new List<Quote>();
            foreach (Quote quote in query)
            {
                quoteList.Add(quote);

            }
            return View(quoteList);
        }
    }
}
