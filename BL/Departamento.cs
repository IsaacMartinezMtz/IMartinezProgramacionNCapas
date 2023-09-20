using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Departamento
    {
        public static ML.Result Add(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 contex = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = contex.DeapartamentoAdd(departamento.Nombre, departamento.Area.IdArea, filasAfectadas);
                    if(query > 0 ) {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Delete(int? IDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = context.DeapartamentoDelete(IDepartamento, filasAfectadas);
                    if(query > 0 )
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result Update(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int query = context.DeapartamentoUpdate(departamento.IdDepartamento, departamento.Nombre, departamento.Area.IdArea, filasAfectadas);
                        if(query > 0 )
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
            }
            return result;
        }
        public static ML.Result GetAll(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1()){
                    var query = context.DepartamentoGetAll(departamento.Nombre ,departamento.Area.IdArea).ToList();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach( var registro in query)
                        {
                            ML.Departamento departamentoM = new ML.Departamento();
                            departamentoM.IdDepartamento = registro.IdDepartamento;
                            departamentoM.Nombre = registro.Nombre;
                            departamentoM.Area = new ML.Area();
                            departamentoM.Area.IdArea = registro.IdArea;

                            result.Objects.Add(departamentoM);
                        }
                        result.Correct = true;
                    }else 
                    { 
                        result.Correct = false; 
                    }

                }  
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetById(int IdUsuario) {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.DepartamentoGetById(IdUsuario).FirstOrDefault();
                    result.Object = new List<object>();
                    if(query != null)
                    {
                        ML.Departamento departamentoG = new ML.Departamento();
                        departamentoG.IdDepartamento = query.IdDepartamento;
                        departamentoG.Nombre = query.Nombre;
                        departamentoG.Area = new ML.Area();
                        departamentoG.Area.IdArea = query.IdArea;

                        result.Object = departamentoG;
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                    }  
                }
            }catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
            }

            return result;
        }
    }
}
