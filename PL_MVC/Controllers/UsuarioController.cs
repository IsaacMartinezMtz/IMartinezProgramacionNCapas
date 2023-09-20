using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            ML.Result result = BL.Usuario.GetAllEF(usuario);

            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
                return View(usuario);
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            if (usuario.Nombre == null)
            {
                usuario.Nombre = "";
            }
            if (usuario.ApellidoPaterno == null)
            {
                usuario.ApellidoPaterno = "";
            }

            ML.Result result = BL.Usuario.GetAllEF(usuario);
            usuario = new ML.Usuario();
            usuario.Usuarios = result.Objects;
            return View(usuario);
        }
        [HttpGet]//Mostrar Formulario
        public ActionResult Form(int? IdUsuario) 
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
            ML.Result resultPais = BL.Pais.GetAll();
            ML.Result resultRol = BL.Rol.GetAllEf(); 
            if(IdUsuario != null){
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);
                if (result.Correct)//Update
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estados.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.MunicipioGetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                    usuario.Direccion.Colonia.Colonias = BL.Colonias.ColoniaGetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;
                } 
            }
            else //Add
            {
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Rol.Roles = resultRol.Objects;
            }
            return View(usuario);
        }
        [HttpPost]//Acciones del Formulario
        public ActionResult Form(ML.Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                HttpPostedFileBase file = Request.Files["Imagen"];
                if (file.ContentLength > 0)
                {
                    usuario.Imagen = ConvertirABase64(file);
                }
                if (usuario.IdUsuario == 0)
                {
                    ML.Result result = BL.Usuario.AddEF(usuario);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha registrado correctamente el usuario";
                        ViewBag.valido = false;
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error no se agrego el usuario";
                        ViewBag.valido = false;
                    }
                }
                else
                {
                    ML.Result result = BL.Usuario.UpdateEF(usuario);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha actualizado correctamente el usuario";
                        ViewBag.valido = false;
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error no se actualizo el usuario";
                        ViewBag.valido = false;
                    }
                }
                return PartialView("Modal");

            }
            else
            {
                ML.Result resultPais = BL.Pais.GetAll();
                ML.Result resultRol = BL.Rol.GetAllEf();
                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estados.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.MunicipioGetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                usuario.Direccion.Colonia.Colonias = BL.Colonias.ColoniaGetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;
                return View(usuario);
            }
        }
        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            
            ML.Result result = BL.Usuario.DeleteEF(IdUsuario);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se ha eliminado correctamente el usuario";
            }
            else
            {
                ViewBag.Mensaje = "No se ha podido eliminar el usuario. Erro: " + result.ErrorMessage;
            }
            return PartialView("Modal");
        }
        [HttpPost]
        public ActionResult Login(string Email, string password) {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = BL.Usuario.UsuarioGetEmail(Email);
            
            if (result.Correct)
            {
                usuario = (ML.Usuario)result.Object;
                if (password == usuario.Password)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.valido = true;
                    ViewBag.Mensaje = "Error contraseña incorrecta";
                }
            }
            else
            {
                ViewBag.Mensaje = "Error Usuario incorrecto";
                ViewBag.valido = true;
            }
            return PartialView("Modal");
        }
        public ActionResult Login()
        {
            return View();
        }

        public JsonResult GetByIdPais(int IdPais)
        {
            ML.Result result = BL.Estados.GetByIdPais(IdPais);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MunicipioGetByIdEstado(int IdEstado)
        {
            ML.Result result = BL.Municipio.MunicipioGetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = BL.Colonias.ColoniaGetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public string ConvertirABase64(HttpPostedFileBase Foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            byte[] data = reader.ReadBytes((int)Foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }

        public JsonResult ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = BL.Usuario.ChangeStatus(IdUsuario, Status);
            return Json(null);
        }
    }
}