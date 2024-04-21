using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Añadir
{
    public static class UIAñadir
    {
        public static void MenuAñadir()
        {
            Console.Clear();
            Console.WriteLine("\t- Menú Principal -");
            Console.WriteLine("\t\t0. Salir");
            Console.WriteLine("\t\t1. Cuenta Joven");
            Console.WriteLine("\t\t2. Cuenta Oro");
            Console.WriteLine("\t\t3. Cuenta Platino");
            Console.Write("\nElija una opción: ");
        }
    }
}
