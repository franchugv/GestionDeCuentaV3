using R24_JesusCG_V1;
using System.IO;

namespace GestionDeCuentaV3.Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainController.ControladorP();

            static void CargarCuentasFichero()
            {

                // Recursos Locales
                string listaCuentas = null;   // Lista de cuentas a devolver
                string[] listaFicheros = null;  // Lista de los ficheros almacenados

                // Lista de los ficheros almacenados
                listaFicheros = Directory.GetFiles("cuentas\\"); // c:/.../CuentasBancarias/(Ficheros.jov/oro/pla) Lo que devuelve
                                                          // Validar
               
                File.

                foreach(string file in listaFicheros)
                {

                }
            }

        }

        
    }
}
