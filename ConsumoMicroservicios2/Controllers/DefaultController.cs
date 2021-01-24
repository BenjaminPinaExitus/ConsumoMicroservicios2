using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumoMicroservicios2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var api = new Common.Api();

            var CatalogoLista = api.GetCatalogosList();

            return View(CatalogoLista);
        }

        public ActionResult CreateCatalogo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCatalogo(Models.Catalogo Ent)
        {
            var api = new Common.Api();
            var resultado = api.SetCatalogo(Ent);

            if (resultado)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return View();
            }
        }

        public ActionResult PantallaUno()
        {
            return View();
        }

        public ActionResult PantallaDos()
        {
            return View();
        }
    }
}