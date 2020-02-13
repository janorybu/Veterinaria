using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinaria.Web.Models;

namespace Veterinaria.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();
            producto1.Codigo = 1;
            producto1.Descripcion = "Antibioticos";


            var producto2 = new ProductoModel();
            producto2.Codigo = 2;
            producto2.Descripcion = "Antiinflamatorios";

            var producto3 = new ProductoModel();
            producto3.Codigo = 3;
            producto3.Descripcion = "Vacunas";

          
            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            

            return View(listadeProductos);
            
           }
    }
}