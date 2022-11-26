using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private AulaDBContext context = new AulaDBContext();
        // GET: Aula
        [HttpGet]
        public ActionResult Index()
        {
            List<Aula> lista= context.aulas.ToList();
            return View(lista);
        }

        //GET: Aula/Create
        [HttpGet]
        public ActionResult Create()
        {
            Aula aula= new Aula();
            return View("Register",aula);
        }

        //POST: Aula/Create
        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.aulas.Add(aula);
                context.SaveChanges();
                return View("index");
            }
            else
            {
                return View("Register", aula);
            }
        }

        //GET: Aula/Details
        [HttpGet]
        public ActionResult Details(int id)
        {
            Aula aula = context.aulas.Find(id);
            if(aula == null) return HttpNotFound();
            return View("Detalle",aula);
        }


        //GET: Aula/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Aula aula = context.aulas.Find(id);

            if(aula == null) return HttpNotFound();
            return View("Modificar", aula);
        }


        //POST: Aula/Edit
        [HttpPost]
        public ActionResult Edit(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aula).State = EntityState.Modified;
                context.SaveChanges();
                return View("index");
            }
            return View("Modificar");

        }


        //GET: Aula/ListarPorEstado/estado
        [HttpGet]
        public ActionResult ListarPorEstado(string estado)
        {
            List<Aula> lista = (from a in context.aulas where a.Estado == estado select a).ToList();
            return View(lista);
        }

        //GET: Aula/TraerPorNumero/numero
        [HttpGet]
        public ActionResult TraerPorNumero(int numero)
        {
            Aula aula = (from a in context.aulas where a.Numero == numero select a).SingleOrDefault();
            
            if(aula==null) return HttpNotFound();
            return View("Details",aula);
        }

    }
}