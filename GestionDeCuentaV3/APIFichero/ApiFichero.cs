using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R24_JesusCG_V1;

namespace GestionDeCuentaV3.APIFichero
{
    public static class ApiFichero
    {
        private const string PATH = "cuentas\\";



        public static void EscribirFichero(string numcuenta, string Datos)
        {

            if (!File.Exists(GenerarNombre(numcuenta))) AgregarFichero(numcuenta);



            File.AppendAllText(GenerarNombre(numcuenta), Datos);

        }

        public static void EliminarFichero(string numcuenta)
        {
            // Borrar Fichero

            File.Delete(GenerarNombre(numcuenta));
        }

        public static void EditarFichero(string numcuenta, string numcuentaAntiguo, string Datos)
        {
            if (File.Exists(GenerarNombre(numcuentaAntiguo))) EliminarFichero(numcuenta);

            EscribirFichero(numcuenta, Datos);
        }

        private static string GenerarNombre(string nc)
        {
            return PATH + nc + ".txt";
        }

        private static void AgregarFichero(string numcuenta)
        {
            StreamWriter escritor;

            if (!Directory.Exists(PATH)) Directory.CreateDirectory(PATH);

            escritor = File.CreateText(GenerarNombre(numcuenta));
            escritor.Close();
        }
    }
}
