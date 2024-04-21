using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Principal
{
    public static class UIPrincipal
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("\t- Menú Principal -");
            Console.WriteLine("\t\t0. Salir");
            Console.WriteLine("\t\t1. Añadir");
            Console.WriteLine("\t\t2. Modificar");
            Console.WriteLine("\t\t3. Eliminar");
            Console.WriteLine("\t\t4. Consultar");
            Console.Write("\nElija una opción: ");

        }
    }
}
