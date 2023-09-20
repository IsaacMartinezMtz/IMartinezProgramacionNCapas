using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult Areas()
        {
            ML.Area area = new ML.Area();
            area.Nombre = "";
            ML.Result result = BL.Area.GetAll(area);

            if (result.Correct)
            {
                area.Areas = result.Objects;
                return View(area);
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public ActionResult Areas(ML.Area areas)
        {
            if (areas.Nombre == null)
            {
                areas.Nombre = "";
            }
            ML.Result result = BL.Area.GetAll(areas);
            areas = new ML.Area();
            areas.Areas = result.Objects;
            return View(areas);
        }
        [HttpGet]
        public ActionResult Departamentos(int? IdAreas)
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();
            ML.Result result = BL.Departamentos.DeapartamentoGetByArea(IdAreas.Value);
            if (result.Correct)
            {
                departamento.Departamentos = result.Objects;
            }
            return View(departamento);
        }

        [HttpGet]
        public ActionResult Productos(int? IdArea)
        {
            ML.Producto producto = new ML.Producto();
            producto.Departamento = new ML.Departamento();
            if (IdArea != null)
            {
                ML.Result result = BL.Producto.ProductoGetByIdArea(IdArea.Value);
                if (result.Correct)
                {

                    producto.Productos = result.Objects;

                }
            }
            else
            {
                ML.Result result = BL.Producto.GetAll(null);
                if (result.Correct)
                {

                    producto.Productos = result.Objects;

                }
            }
            return View(producto);
        }
    }
}