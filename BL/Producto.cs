using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
        public static ML.Result ProductoGetByIdArea(int IdArea)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
                {
                    var query = context.ProductoGetByIdDepartamento(IdArea).ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.Nombre = obj.Nombre;
                            producto.PrecioUnitario = obj.PrecioUnitario;
                            producto.Stock = obj.Stock;
                            producto.Imagen = obj.Imagen;
                            producto.Descripcio = obj.Descripcion;
                            result.Objects.Add(producto);
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

        //public static ML.Result GetAll(ML.Producto producto)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DLEF.IMartinezProgramacionNCapasEntities1 context = new DLEF.IMartinezProgramacionNCapasEntities1())
        //        {
        //            var query = context.ProductoGetAll().ToList();
        //            if (query != null)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (var obj in query)
        //                {
        //                    ML.Producto productod = new ML.Producto();
        //                    productod.Nombre = obj.Nombre;
        //                    productod.PrecioUnitario = obj.PrecioUnitario;
        //                    productod.Stock = obj.Stock;
        //                    productod.Imagen = obj.Imagen;
        //                    productod.Descripcio = obj.Descripcion;
        //                    result.Objects.Add(productod);
        //                }
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
        //    }
        //    return result;
        //}

    }
}
