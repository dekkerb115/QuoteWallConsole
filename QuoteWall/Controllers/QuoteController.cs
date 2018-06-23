using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuoteWall.Models;

namespace QuoteWall.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Random()
        {
            Quote quote = new Quote() {name = "Hello World" };
            return View(quote);
        }
    }
}