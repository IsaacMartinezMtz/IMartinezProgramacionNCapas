using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el numero de la accion a realizar");
            Console.WriteLine("*** 1._ Add ***");
            Console.WriteLine("*** 2._ Delete ***");
            Console.WriteLine("*** 3._ Update ***");
            Console.WriteLine("*** 4._ Get All ***");
            Console.WriteLine("*** 5._ Get By Id ***");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    BL.Usuario.CargaMasivaTxt();
                    break;
                //case 2:
                //    PL.Usuario.Delete();
                //    break;
                //case 3:
                //    PL.Usuario.Update();
                //    break;
                //case 4:
                //    PL.Usuario.GetAll();
                //    break;
                //case 5:
                //    PL.Usuario.GetById();
                //    break;
                //default:
                //    break;
            }
            Console.ReadKey();
        }
    }
}
