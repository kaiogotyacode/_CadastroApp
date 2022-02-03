using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationApp.Models;


namespace ValidationApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Pessoa pessoa = new Pessoa();
        

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
                

            if (ModelState.IsValid){
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {   
            return View(pessoa);
        }
  
    }
}