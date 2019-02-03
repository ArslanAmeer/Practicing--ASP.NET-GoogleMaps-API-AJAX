using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practicing_AJAX_GoogleApi_ClickEvents.Models;

namespace Practicing_AJAX_GoogleApi_ClickEvents.Controllers
{
    public class GoogleController : Controller
    {
        private readonly DbContextClass db = new DbContextClass();
        // GET: Google
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCords()
        {
            List<GoogleMapCord> cords;
            using (db)
            {
                cords = (from s in db.GoogleMapCords select s).ToList();
            }

            return Json(cords, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string AddCordsToDb(GoogleMapCord cords)
        {
            using (db)
            {
                db.GoogleMapCords.Add(new GoogleMapCord()
                {
                    Latitude = cords.Latitude,
                    Longitude = cords.Longitude
                });
                db.SaveChanges();
            }

            return "DONE";
        }
    }
}