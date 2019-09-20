using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinyMCE_TEXT_ENRICHED.Models;

namespace TinyMCE_TEXT_ENRICHED.Controllers
{
    public class NewsController : Controller
    {

        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(News model)
        {

            Noticias noticias = new Noticias();

            using (PruebaEntities5 db = new PruebaEntities5())
            {
                noticias.NewsTitle = model.NewsTitle;
                noticias.Content = model.Content;

                db.Noticias.Add(noticias);
                db.SaveChanges();

            }
            
                return View("NewDisplay", model);

        }
    }
}