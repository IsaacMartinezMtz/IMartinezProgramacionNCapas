using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Estados
    {
        public static ML.Result GetByIdPais(int IdPais)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.EstadoGetById(IdPais).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Estado estado = new ML.Estado();
                            estado.Nombre = obj.Nombre;
                            estado.IdEstado = obj.IdEstado;
                            result.Objects.Add(estado);
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
