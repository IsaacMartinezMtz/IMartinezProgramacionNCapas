using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Departamento departamento = new ML.Departamento();
            ML.Area area = new ML.Area();
            departamento.Area = new ML.Area();
            ML.Result resultArea = BL.Area.GetAll(area);
            departamento.Nombre = "";
            departamento.Area.IdArea = 0;
            ML.Result result =BL.Departamento.GetAll(departamento);
         

            if (result.Correct)
            {
                departamento.Departamentos = result.Objects;
                departamento.Area.Areas = resultArea.Objects;
                //
            }
            else
            {
                return View();
            }
            return View(departamento);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Departamento departamento)
        {

            if (departamento.Nombre == null)
            {
                departamento.Nombre = "";
            }
            if (departamento.Area.IdArea == 0)
            {
                departamento.Area.IdArea = 0;
            }

            ML.Result result = BL.Departamento.GetAll(departamento);
            departamento= new ML.Departamento();
            departamento.Departamentos = result.Objects;
            return View(departamento);

        }
        [HttpGet]
        public ActionResult Form(int? IdDepartamento)
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();
            ML.Area area = new ML.Area();
            ML.Result resultArea = BL.Area.GetAll(area);
            if (IdDepartamento != null)
            {
                ML.Result result = BL.Departamento.GetById(IdDepartamento.Value);
                if (result.Correct) //Update
                {
                    departamento = (ML.Departamento)result.Object;
                    departamento.Area.Areas = resultArea.Objects;
                }
            }
            else
            {
                departamento.Area.Areas = resultArea.Objects;
            }
                return View(departamento);
        }
        [HttpPost] //Acciones del formulario
        public ActionResult Form(ML.Departamento departamento) 
        {
            if(departamento.IdDepartamento == 0)
            {
                ML.Result result = BL.Departamento.Add(departamento);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Se ha registrado correctamente el departamento";
                }
                else
                {
                    ViewBag.Mensaje = "Error no se agrego el Deapartamento";
                }
            }
            else
            {
                ML.Result result = BL.Departamento.Update(departamento);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Se ha actualizado correctamente el Departamento";
                }
                else
                {
                    ViewBag.Mensaje = "Error no se actualizo el Departamento";
                }
            }
            return PartialView("Modal");
        }
        [HttpGet]
        public ActionResult Delete(int IdDepartamento)
        {
            ML.Result result = BL.Departamento.Delete(IdDepartamento);
            if(result.Correct)
            {
                ViewBag.Mensaje = "Se ha eliminado correctamente el departamento";
            }
            else
            {
                ViewBag.Mensaje = "No se ha podido eliminar el departamento. Erro: " + result.ErrorMessage;
            }
            return PartialView("Modal");
        }
        
    }

}