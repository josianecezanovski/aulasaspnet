﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1505.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<string> categorias = new List<string>();
            categorias.Add("Estudo");
            categorias.Add("Lazer");
            categorias.Add("Refeiçao");
            categorias.Add("Trabalo");

            ViewBag.MinhasCategorias = categorias;



            return View();
        }
    }
}