using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Departamentos
    {
        public static ML.Result DeapartamentoGetByArea(int IdArea)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.DeapartamentoGetByIdArea(IdArea).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();
                            departamento.Nombre = obj.Nombre;
                            departamento.IdDepartamento = obj.IdDEpartamento;
                            result.Objects.Add(departamento);
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
