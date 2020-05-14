using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOrogolden.Business;
using WebOrogolden.Models;

namespace WebOrogolden.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        public ActionResult Create(Citas citas)
        {
            try
            {
                BusinessCitas businessCitas = new BusinessCitas();
                if (citas != null)
                {
                    businessCitas.AddCita(citas);
                    TempData["msj"] = "Cita reservada"; 
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                TempData["msj"] = ex.Message;

                return RedirectToAction("Index");
            }
        }

    }
}