using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colonias
    {
        public static ML.Result ColoniaGetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.ColoniaGetById(IdMunicipio).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Colonia colonia = new ML.Colonia();
                            colonia.Nombre = obj.Nombre;
                            colonia.IdColonia = obj.IdColonia;
                            result.Objects.Add(colonia);
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
                result.Correct = false;

            }
            return result;
        }
    }
}
