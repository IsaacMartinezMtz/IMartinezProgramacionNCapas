    using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;


namespace BL
{
    public class Usuario
    {
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "INSERT INTO  Usuario VALUES(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Aprobado, @Dirrecion)";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Aprobado", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Aprobado;
        //            collection[5] = new SqlParameter("@Dirrecion", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Dirrecion;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();
        //            int filasafectadas = cmd.ExecuteNonQuery();
        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al agregar el Usuario";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result AddPd(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsiarioAdd ";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Aprobado", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Aprobado;
        //            collection[5] = new SqlParameter("@Dirrecion", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Dirrecion;
        //            collection[6] = new SqlParameter("IdRol", SqlDbType.Int); 
        //            collection[6].Value = usuario.Rol.IdRol;


        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();
        //            int filasafectadas = cmd.ExecuteNonQuery();
        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())

                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = context.UsiarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.FechaNacimiento, usuario.Rol.IdRol, usuario.UserName, usuario.Email, usuario.Sexo, usuario.Telefono, usuario.Password, usuario.Celular, usuario.CURP, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia, usuario.Imagen, filasAfectadas);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        //public static ML.Result AddLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DLEF.IMartinezProgramacionNCapasEntities context = new DLEF.IMartinezProgramacionNCapasEntities())
        //        {
        //            DLEF.Usuario usuarioLinq = new DLEF.Usuario();

        //            usuarioLinq.Nombre = usuario.Nombre;
        //            usuarioLinq.ApellidoPaterno = usuario.ApellidoPaterno;
        //            usuarioLinq.ApellidoMaterno = usuario.ApellidoMaterno;
        //            usuarioLinq.FechaNacimiento = usuario.FechaNacimiento;
        //            usuarioLinq.Aprobado = usuario.Aprobado;
        //            usuarioLinq.Dirrecion = usuario.Dirrecion;
        //            usuarioLinq.idRol = usuario.Rol.IdRol;

        //            context.Usuario.Add(usuarioLinq);
        //            int rowsAffected = context.SaveChanges();

        //            if (rowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "DELETE FROM Usuario Where IdUsiario = @IdUsuario";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[1];
        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasafectadas = cmd.ExecuteNonQuery();
        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al Eliminar el usuario";

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
        //public static ML.Result DeletePd(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            String query = "UsuarioDelete";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[1];
        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasafectadas = cmd.ExecuteNonQuery();
        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;

        //    }
        //    return result;
        //}
        public static ML.Result DeleteEF(int? IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = context.UsuarioDelete(IdUsuario, filasAfectadas);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        //public static ML.Result DeleteLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result= new ML.Result();
        //    try
        //    {
        //        using(DLEF.IMartinezProgramacionNCapasEntities context = new DLEF.IMartinezProgramacionNCapasEntities())
        //        {
        //            ML.Result result1 = new ML.Result();
        //            var query = (from a in context.Usuario where a.IdUsiario == usuario.IdUsuario select a).First();

        //            context.Usuario.Remove(query);
        //            context.SaveChanges();
        //            result.Correct = true;
        //        }
        //    }catch (Exception ex)
        //    {
        //        result.Correct=false;
        //        result.ErrorMessage = ex.Message;

        //    }
        //    return result;
        //}
        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UPDATE Usuario SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, FechaNacimiento = @FechaNacimiento, Aprobado = @Aprobado, Dirrecion = @Dirrecion WHERE IdUsiario = @IdUsuario ";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[7];
        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;
        //            collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;
        //            collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;
        //            collection[4] = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
        //            collection[4].Value = usuario.FechaNacimiento;
        //            collection[5] = new SqlParameter("@Aprobado", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Aprobado;
        //            collection[6] = new SqlParameter("@Dirrecion", SqlDbType.VarChar);
        //            collection[6].Value = usuario.Dirrecion;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasafectadas = cmd.ExecuteNonQuery();

        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Actualizado Correctamente";
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error a actualizar el usuario";

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;

        //    }
        //    return result;
        //}
        //public static ML.Result UpdatePd(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioUpdate";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[8];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Aprobado", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Aprobado;
        //            collection[5] = new SqlParameter("@Dirrecion", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Dirrecion;
        //            collection[6] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[6].Value = usuario.IdUsuario;
        //            collection[7] = new SqlParameter("@IdRol", SqlDbType.Int);
        //            collection[7].Value = usuario.Rol.IdRol;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasafectadas = cmd.ExecuteNonQuery();

        //            if (filasafectadas > 0)
        //            {
        //                result.Correct = true;
        //                result.ErrorMessage = "Actualizado Correctamente";
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error a actualizar el usuario";

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //    }
        //    return result;
        //}
        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 contex = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = contex.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.FechaNacimiento, usuario.Rol.IdRol, usuario.UserName, usuario.Email, usuario.Sexo, usuario.Telefono, usuario.Password, usuario.Celular, usuario.CURP, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia, usuario.Imagen, filasAfectadas);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        //public static ML.Result UpdateLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result= new ML.Result();
        //    try
        //    {
        //        using (DLEF.IMartinezProgramacionNCapasEntities context = new DLEF.IMartinezProgramacionNCapasEntities())
        //        {
        //            var query = (from a in context.Usuario where a.IdUsiario == usuario.IdUsuario select a).SingleOrDefault();
        //            if (query != null)
        //            {
        //                query.Nombre = usuario.Nombre;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.FechaNacimiento = usuario.FechaNacimiento;
        //                query.Aprobado = usuario.Aprobado;
        //                query.Dirrecion = usuario.Dirrecion;
        //                query.idRol = usuario.Rol.IdRol;
        //                context.SaveChanges();

        //                result.Correct = true;
        //            }
        //            else 
        //            { 
        //                result.Correct = false; 
        //            }
        //        }

        //    }catch(Exception ex)
        //    {
        //        result.Correct=false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAll()
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsiario, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Aprobado, Dirrecion From Usuario";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);

        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                    usuario.Aprobado = bool.Parse(row[5].ToString());
        //                    usuario.Dirrecion = row[6].ToString();

        //                    result.Objects.Add(usuario);
        //                }
        //                result.Correct = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAllPd()
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuariaGetAll";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();
        //            adapter.Fill(tablaUsuario);
        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in tablaUsuario.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                    usuario.Aprobado = bool.Parse(row[5].ToString());
        //                    usuario.Dirrecion = row[6].ToString();
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.Rol.IdRol = int.Parse(row[7].ToString());

        //                    result.Objects.Add(usuario);
        //                }
        //                result.Correct = true;
        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 contex = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = contex.UsuariaGetAll(usuario.Nombre, usuario.ApellidoPaterno).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Usuario usuarioJ = new ML.Usuario();
                            usuarioJ.IdUsuario = registro.IdUsiario;
                            usuarioJ.Nombre = registro.Nombre;
                            usuarioJ.ApellidoPaterno = registro.ApellidoPaterno;
                            usuarioJ.ApellidoMaterno = registro.ApellidoMaterno;
                            usuarioJ.FechaNacimiento = (DateTime)registro.FechaNacimiento;
                            usuarioJ.Rol = new ML.Rol();
                            usuarioJ.Rol.IdRol = registro.idRol;
                            usuarioJ.Rol.Nombre = registro.NombreRol;
                            usuarioJ.UserName = registro.UserName;
                            usuarioJ.Email = registro.Email;
                            usuarioJ.Sexo = registro.Sexo;
                            usuarioJ.Telefono = registro.TeleFono;
                            usuarioJ.Password = registro.Password;
                            usuarioJ.Celular = registro.Celular;
                            usuarioJ.CURP = registro.CURP;
                            usuarioJ.Imagen = registro.Imagen;
                            usuarioJ.Status = registro.Status;
                        
                            usuarioJ.Direccion = new ML.Direccion();
                            usuarioJ.Direccion.IdDireccion = registro.IdDireccion;
                            usuarioJ.Direccion.Calle = registro.Calle;
                            usuarioJ.Direccion.NumeroInterior = registro.NumeroInterior;
                            usuarioJ.Direccion.NumeroExterior = registro.NumeroExterior;
                            usuarioJ.Direccion.Colonia = new ML.Colonia();
                            usuarioJ.Direccion.Colonia.IdColonia = registro.IdColonia;
                            usuarioJ.Direccion.Colonia.Nombre = registro.NombreColonia;
                            usuarioJ.Direccion.Colonia.CodigoPostal = registro.CodigoPostal;
                            usuarioJ.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuarioJ.Direccion.Colonia.Municipio.IdMunicipio = registro.IdMunicipio;
                            usuarioJ.Direccion.Colonia.Municipio.Nombre = registro.NombreMunicipio;
                            usuarioJ.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuarioJ.Direccion.Colonia.Municipio.Estado.IdEstado = registro.IdEstado;
                            usuarioJ.Direccion.Colonia.Municipio.Estado.Nombre = registro.NombreEstado;
                            usuarioJ.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuarioJ.Direccion.Colonia.Municipio.Estado.Pais.IdPais = registro.IdPais;
                            usuarioJ.Direccion.Colonia.Municipio.Estado.Pais.Nombre = registro.NombrePais;


                            result.Objects.Add(usuarioJ);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        //public static ML.Result GetAllLINQ()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using(DLEF.IMartinezProgramacionNCapasEntities context = new DLEF.IMartinezProgramacionNCapasEntities())
        //        {
        //            var query = (from Users in context.Usuario
        //                         join Rols in context.Rol on Users.idRol equals Rols.IdRol
        //                         select new {
        //                                     IdUsiario = Users.IdUsiario,
        //                                     Nombre = Users.Nombre,
        //                                     ApellidoPaterno = Users.ApellidoPaterno,
        //                                     ApellidoMaterno = Users.ApellidoMaterno,
        //                                     FechaNacimiento = Users.FechaNacimiento,
        //                                     Aprobado = Users.Aprobado,
        //                                     Dirrecion = Users.Dirrecion,
        //                                     idRol = Users.idRol,
        //                         });
        //            if (query != null )
        //            {
        //                result.Objects = new List<object>();
        //                foreach(var registros in query)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.IdUsuario = registros.IdUsiario;
        //                    usuario.Nombre = registros.Nombre;
        //                    usuario.ApellidoPaterno = registros.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = registros.ApellidoMaterno;
        //                    usuario.Aprobado = registros.Aprobado;
        //                    usuario.Dirrecion = registros.Dirrecion;
        //                    usuario.Rol.IdRol = registros.idRol;

        //                    result.Objects.Add( usuario );
        //                }
        //                result.Correct = true; 
        //            }
        //        }

        //    }catch(Exception ex)
        //    {
        //        result.Correct = false;
        //    }

        //    return result;
        //}

        //public static ML.Result GetById(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT IdUsiario, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Aprobado, Dirrecion From Usuario Where idUsiario = @IdUsuario";
        //            SqlCommand cmd = new SqlCommand(query, context);
        //            SqlParameter[] collection = new SqlParameter[1];
        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();

        //            adapter.Fill(tablaUsuario);

        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                DataRow row = tablaUsuario.Rows[0];
        //                ML.Usuario usuarioResult = new ML.Usuario();
        //                usuarioResult.IdUsuario = int.Parse(row[0].ToString());
        //                usuarioResult.Nombre = row[1].ToString();
        //                usuarioResult.ApellidoPaterno = row[2].ToString();
        //                usuarioResult.ApellidoMaterno = row[3].ToString();
        //                usuarioResult.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                usuarioResult.Aprobado = bool.Parse(row[5].ToString());
        //                usuarioResult.Dirrecion = row[6].ToString();

        //                //boxing
        //                result.Object = usuarioResult;
        //                result.Correct = true;

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result GetByIdPd(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();


        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetById";

        //            SqlCommand cmd = new SqlCommand(query, context);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;
        //            cmd.Parameters.AddRange(collection);

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataTable tablaUsuario = new DataTable();

        //            adapter.Fill(tablaUsuario);
        //            if (tablaUsuario.Rows.Count > 0)
        //            {
        //                DataRow row = tablaUsuario.Rows[0];
        //                ML.Usuario usuarioResult = new ML.Usuario();
        //                usuarioResult.IdUsuario = int.Parse(row[0].ToString());
        //                usuarioResult.Nombre = row[1].ToString();
        //                usuarioResult.ApellidoPaterno = row[2].ToString();
        //                usuarioResult.ApellidoMaterno = row[3].ToString();
        //                usuarioResult.FechaNacimiento = DateTime.Parse(row[4].ToString());
        //                usuarioResult.Aprobado = bool.Parse(row[5].ToString());
        //                usuarioResult.Dirrecion = row[6].ToString();
        //                usuarioResult.Rol = new ML.Rol();
        //                usuarioResult.Rol.IdRol = int.Parse(row[7].ToString());

        //                //boxing
        //                result.Object = usuarioResult;
        //                result.Correct = true;

        //            }
        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.ErrorMessage =ex.Message;
        //    }
        //    return result;
        //}
        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioGetById(IdUsuario).FirstOrDefault();
                    result.Object = new List<object>();
                    if (query != null)
                    {
                        ML.Usuario usuariog = new ML.Usuario();
                        usuariog.IdUsuario = query.IdUsiario;
                        usuariog.Nombre = query.Nombre;
                        usuariog.ApellidoPaterno = query.ApellidoPaterno;
                        usuariog.ApellidoMaterno = query.ApellidoMaterno;
                        usuariog.FechaNacimiento = (DateTime)query.FechaNacimiento;
                        usuariog.Rol = new ML.Rol();
                        usuariog.Rol.IdRol = query.idRol;
                        usuariog.Rol.Nombre = query.NombreRol;
                        usuariog.UserName = query.UserName;
                        usuariog.Email = query.Email;
                        usuariog.Sexo = query.Sexo;
                        usuariog.Telefono = query.TeleFono;
                        usuariog.Password = query.Password;
                        usuariog.Celular = query.Celular;
                        usuariog.CURP = query.CURP;
                        usuariog.Imagen = query.Imagen;
                        
                        usuariog.Direccion = new ML.Direccion();
                        usuariog.Direccion.IdDireccion = query.IdDireccion;
                        usuariog.Direccion.Calle = query.Calle;
                        usuariog.Direccion.NumeroInterior = query.NumeroInterior;
                        usuariog.Direccion.NumeroExterior = query.NumeroExterior;
                        usuariog.Direccion.Colonia = new ML.Colonia();
                        usuariog.Direccion.Colonia.IdColonia = query.IdColonia;
                        usuariog.Direccion.Colonia.Nombre = query.NombreColonia;
                        usuariog.Direccion.Colonia.CodigoPostal = query.CodigoPostal;
                        usuariog.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuariog.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio;
                        usuariog.Direccion.Colonia.Municipio.Nombre = query.NombreMunicipio;
                        usuariog.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuariog.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado;
                        usuariog.Direccion.Colonia.Municipio.Estado.Nombre = query.NombreEstado;
                        usuariog.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuariog.Direccion.Colonia.Municipio.Estado.Pais.IdPais = query.IdPais;
                        usuariog.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.NombrePais;

                        result.Object = usuariog;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
                result.Correct = false;
            }
            return result;
        }
        //public static ML.Result GetByIdLINQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DLEF.IMartinezProgramacionNCapasEntities context = new DLEF.IMartinezProgramacionNCapasEntities())
        //        {

        //            var query = (from Users in context.Usuario
        //                         join Rols in context.Rol on Users.idRol equals Rols.IdRol
        //                         where Users.IdUsiario == usuario.IdUsuario
        //                         select new
        //                         {
        //                             IdUsiario = Users.IdUsiario,
        //                             Nombre = Users.Nombre,
        //                             ApellidoPaterno = Users.ApellidoPaterno,
        //                             ApellidoMaterno = Users.ApellidoMaterno,
        //                             FechaNacimiento = Users.FechaNacimiento,
        //                             Aprobado = Users.Aprobado,
        //                             Dirrecion = Users.Dirrecion,
        //                             idRol = Users.idRol,
        //                         });
        //            result.Object = new List<object>();

        //            if (query != null)
        //            {
        //                foreach (var registros in query)
        //                {
        //                    ML.Usuario usuarioU = new ML.Usuario();
        //                    usuarioU.Rol = new ML.Rol();
        //                    usuarioU.IdUsuario = registros.IdUsiario;
        //                    usuarioU.Nombre = registros.Nombre;
        //                    usuarioU.ApellidoPaterno = registros.ApellidoPaterno;
        //                    usuarioU.ApellidoMaterno = registros.ApellidoMaterno;
        //                    usuarioU.Aprobado = registros.Aprobado;
        //                    usuarioU.Dirrecion = registros.Dirrecion;ic 
        //                    usuarioU.Rol.IdRol = registros.idRol;

        //                    result.Object = usuarioU;

        //                }
        //                result.Correct = true;
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Ex = ex;
        //        result.Correct = false;
        //    }
        //    return result;
        //}

        public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.IMartinezProgramacionNCapasEntities1 contex = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    var query = contex.ChangeStatus(IdUsuario, Status, filasAfectadas);
                    if(query > 0)
                    {
                        result.Correct= true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch(Exception ex) 
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }


        public static ML.Result UsuarioGetEmail(string Email)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioGetEmail(Email).FirstOrDefault();
                    result.Object = new List<object>();
                    if (query != null)
                    {
                        ML.Usuario usuariog = new ML.Usuario();   
                        usuariog.Email = query.Email;
                        usuariog.Password = query.Password;
                        result.Object = usuariog;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
                result.Correct = false;
            }
            return result;
        }

        public static void CargaMasivaTxt()
        {
            string file = @"C:\Users\digis\Documents\Isaac Martínez Martínez\IMartinezProgramacionNCapas\PL_MVC\Files\CargaMasiva.txt";

            if (File.Exists(file))
            {
                StreamReader streamReader = new StreamReader(file);

                string line = streamReader.ReadLine(); //SALTAR HEDEARS

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] row = line.Split('|');
                    ML.Usuario usuario = new ML.Usuario();
                    usuario.Nombre = row[0].ToString();
                    usuario.ApellidoPaterno = row[1];
                    usuario.ApellidoMaterno = row[2];
                    //usuario.FechaNacimiento =DateTime.Parse(row[3], CultureInfo.CreateSpecificCulture("en-US"));
                    usuario.Rol = new ML.Rol();
                    usuario.Rol.IdRol = int.Parse(row[4]);
                    usuario.UserName = row[5];
                    usuario.Email = row[6];
                    usuario.Sexo = row[7];
                    usuario.Telefono = row[8];
                    usuario.Password = row[9];
                    usuario.Celular = row[10];
                    usuario.CURP = row[11];
                    usuario.Imagen = row[12];
                    usuario.Direccion = new ML.Direccion();
                    usuario.Direccion.Calle = row[14];
                    usuario.Direccion.NumeroInterior = row[15];
                    usuario.Direccion.NumeroExterior = row[16];
                    usuario.Direccion.Colonia = new ML.Colonia();
                    usuario.Direccion.Colonia.IdColonia = int.Parse(row[17]);
                    //BL.Usuario.AddEF(usuario);

                }

            }
        }

        public static ML.Result LeerExcel(string connectionString)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (OleDbConnection context = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Hoja1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;

                        DataTable tableUsuario = new DataTable();

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.Nombre = row[0].ToString();
                                usuario.ApellidoPaterno = row[1].ToString();
                                usuario.ApellidoMaterno = row[2].ToString();
                                usuario.FechaNacimiento = DateTime.Parse(row[3].ToString());
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = int.Parse(row[4].ToString());
                                usuario.UserName = row[5].ToString();
                                usuario.Email = row[6].ToString();
                                usuario.Sexo = row[7].ToString();
                                usuario.Telefono = row[8].ToString();
                                usuario.Password = row[9].ToString();
                                usuario.Celular = row[10].ToString();
                                usuario.CURP = row[11].ToString();
                                usuario.Imagen = row[12].ToString();
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Calle = row[14].ToString();
                                usuario.Direccion.NumeroInterior = row[15].ToString();
                                usuario.Direccion.NumeroExterior = row[16].ToString();
                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.Direccion.Colonia.IdColonia = int.Parse(row[17].ToString());
                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;

                        }

                        result.Object = tableUsuario;

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No existen registros en el excel";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
        public static ML.Result ValidarExcel(List<object> usuarios)
        {
            ML.Result result = new ML.Result();

            try
            {
                result.Objects = new List<object>(); //almacena los registros incompletos
                int i = 1; //guarda el numero de la fila
                foreach (ML.Usuario usuario in usuarios)
                {
                    
                    ML.ErrorExcel error = new ML.ErrorExcel();
                    usuario.Rol = new ML.Rol();
                    usuario.Direccion = new ML.Direccion();
                    usuario.Direccion.Colonia = new ML.Colonia();
                    
                    error.IdRegistro = i++;

                    if (usuario.Nombre == "")
                    {
                        error.Mensaje += "Ingresar el nombre  ";
                    }
                    if (usuario.ApellidoPaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido paterno  ";
                    }
                    if (usuario.FechaNacimiento == null)
                    {
                        error.Mensaje += "Ingresa Fecha de Nacimiento ";
                    }
                    ////if(usuario.Rol.IdRol == 0)
                    ////{
                    ////    error.Mensaje += "Ingresa el IdRol ";
                    ////}
                    if(usuario.UserName == "")
                    {
                        error.Mensaje += "Ingresa el username ";
                    }
                    if(usuario.Email == "")
                    {
                        error.Mensaje += "Ingresa el email ";
                    }
                    if(usuario.Sexo == "")
                    {
                        error.Mensaje += "Ingresa el sexo ";
                    }
                    if(usuario.Telefono == "")
                    {
                        error.Mensaje += "Ingresa el telefono ";
                    }
                    if(usuario.Password == "")
                    {
                        error.Mensaje += "Ingresa el password ";
                    }
                    if(usuario.Direccion.Calle == "")
                    {
                        error.Mensaje += "Ingresa la calle ";
                    }
                    if(usuario.Direccion.NumeroExterior == "")
                    {
                        error.Mensaje += "Ingresa el numero exterior ";
                    }
                    //if (usuario.Direccion.Colonia.IdColonia == 0)
                    //{
                    //    error.Mensaje += "Ingresa el id de la colonia ";
                    //}
                    if (error.Mensaje != null)
                    {
                        result.Objects.Add(error);
                    }


                }
                result.Correct = false;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }


    }


}