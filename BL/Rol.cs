using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
       public static ML.Result GetAllEf()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.RolGetAll().ToList();
                    if (query !=null) { 
                        result.Objects = new List<object>();
                        foreach (var registro in query) { 
                            ML.Rol rol = new ML.Rol();
                            rol.IdRol = registro.idRol;
                            rol.Nombre = registro.Nombre;

                            result.Objects.Add(rol);
                           
                        }
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
            }
            return result;
        }

    }
}
