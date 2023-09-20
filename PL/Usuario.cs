using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        //public static void Add()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingresa el nombre del nuevo usuario");
        //    usuario.Nombre = Console.ReadLine();
        //    Console.WriteLine("Ingresa el apellido paterno del nuevo usuario");
        //    usuario.ApellidoPaterno = Console.ReadLine();
        //    Console.WriteLine("Ingresa el apellido Materno del nuevo usuario");
        //    usuario.ApellidoMaterno = Console.ReadLine();
        //    Console.WriteLine("Ingresa la fecha de nacimiento del nuevo usuario ");
        //    usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa el id del rol del usuario");
        //    usuario.Rol = new ML.Rol();
        //    usuario.Rol.IdRol = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa El nombre del usuario ");
        //    usuario.UserName = Console.ReadLine();
        //    Console.WriteLine("Ingresa el email del usuario ");
        //    usuario.Email = Console.ReadLine();
        //    Console.WriteLine("Ingresa M si el usuario es Mujer o ingresa F si es Hombre");
        //    usuario.Sexo = Console.ReadLine();
        //    Console.WriteLine("Ingresa El telefono del usuario ");
        //    usuario.Telefono = Console.ReadLine();
        //    Console.WriteLine("Ingresa El password del usuario ");
        //    usuario.Password = Console.ReadLine();
        //    Console.WriteLine("Ingresa El Celular del usuario ");
        //    usuario.Celular = Console.ReadLine();
        //    Console.WriteLine("Ingresa El CURP del usuario ");
        //    usuario.CURP = Console.ReadLine();


        //    ML.Result result = BL.Usuario.AddEF(usuario);
        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Usuario agregado exitosamente");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Usuario no agregado " + result.Ex);
        //    }
        //}

        //public static void Delete()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingresa el Id del usuario que deseas eliminar");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.DeleteEF(usuario);
        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Usuario eliminado exitosamente");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Usuario no Eliminado " + result.ErrorMessage);
        //    }

        //}

        //public static void Update()
        //{

        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingresa el Id del usuario que deseas Actualizar");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Actualiza el nombre del usuario");
        //    usuario.Nombre = Console.ReadLine();
        //    Console.WriteLine("Actualiza el apellido paterno del usuario");
        //    usuario.ApellidoPaterno = Console.ReadLine();
        //    Console.WriteLine("Actualiza el apellido Materno del usuario");
        //    usuario.ApellidoMaterno = Console.ReadLine();
        //    Console.WriteLine("Actualiza la fecha de nacimiento del usuario ");
        //    usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa El nombre del usuario ");
        //    usuario.UserName = Console.ReadLine();
        //    Console.WriteLine("Ingresa el email del usuario ");
        //    usuario.Email = Console.ReadLine();
        //    Console.WriteLine("Ingresa M si el usuario es Mujer o ingresa F si es Hombre");
        //    usuario.Sexo = Console.ReadLine();
        //    Console.WriteLine("Ingresa El telefono del usuario ");
        //    usuario.Telefono = Console.ReadLine();
        //    Console.WriteLine("Ingresa El password del usuario ");
        //    usuario.Password = Console.ReadLine();
        //    Console.WriteLine("Ingresa El Celular del usuario ");
        //    usuario.Celular = Console.ReadLine();
        //    Console.WriteLine("Ingresa El CURP del usuario ");
        //    usuario.CURP = Console.ReadLine();


        //    Console.WriteLine("Actualiza el Id Rol del usuario");
        //    usuario.Rol = new ML.Rol();
        //    usuario.Rol.IdRol = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.UpdateEF(usuario);
        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Usuario actualizado exitosamente");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Usuario no actualizado " + result.Ex);
        //    }

        //}


        //public static void GetAll()
        //{

        //    ML.Result result = new ML.Result();
        //    result = BL.Usuario.GetAllEF();

        //    List<object> objects = result.Objects;
            

        //    if (result.Correct)
        //    {
        //        foreach (ML.Usuario usuario in objects)
        //        {
        //            Console.WriteLine("-------------");
        //            Console.WriteLine("Id usuario: " + usuario.IdUsuario);
        //            Console.WriteLine("Nombre: " + usuario.Nombre);
        //            Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
        //            Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
        //            Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
        //            Console.WriteLine("Id Rol: " + usuario.Rol.IdRol);
        //            Console.WriteLine("Nombre: " + usuario.Rol.Nombre);
        //            Console.WriteLine("Nombre de Usuario: " + usuario.UserName);
        //            Console.WriteLine("Email: " + usuario.Email);
        //            Console.WriteLine("Sexo: "+ usuario.Sexo);
        //            Console.WriteLine("Telefono" + usuario.Telefono); ;
        //            Console.WriteLine("Password: " + usuario.Password);
        //            Console.WriteLine("Celular: " + usuario.Celular);
        //            Console.WriteLine("Curp: " + usuario.CURP);
        //            Console.WriteLine("---------------");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error " + result.ErrorMessage);
        //    }
        //}

        //public static void GetById()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Ingresa el id del usuario a consultar");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.GetByIdEF(usuario);

        //    if (result.Correct == true)
        //    {
        //        usuario = (ML.Usuario) result.Object;
        //        Console.WriteLine("Id usuario: " + usuario.IdUsuario);
        //        Console.WriteLine("Nombre: " + usuario.Nombre);
        //        Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
        //        Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
        //        Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
        //        Console.WriteLine("Id Rol: " + usuario.Rol.IdRol);
        //        Console.WriteLine("Nombre del Rol: " + usuario.Rol.Nombre);
        //        Console.WriteLine("Nombre de Usuario: " + usuario.UserName);
        //        Console.WriteLine("Email: " + usuario.Email);
        //        Console.WriteLine("Sexo: " + usuario.Sexo);
        //        Console.WriteLine("Telefono: " + usuario.Telefono); ;
        //        Console.WriteLine("Password: " + usuario.Password);
        //        Console.WriteLine("Celular: " + usuario.Celular);
        //        Console.WriteLine("Curp: " + usuario.CURP);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error " + result.ErrorMessage);
        //    }
        //}

       

    }
}
