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


        private static bool VerificarExsitencia(string numcuenta, Cuenta cuenta)
        {

            bool esValido = true;

            if (!File.Exists(GenerarNombre(numcuenta, cuenta))) esValido = false;

            return esValido;
        }




        public static string ConsultarFichero(string numcuenta, Cuenta cuenta)
        {
            // Recursos
            StreamReader lector;
            string cadena = "";

            lector = File.OpenText(GenerarNombre(numcuenta, cuenta));
            cadena = lector.ReadToEnd();

            lector.Close();

            return cadena;

        }



        private static void AgregarFichero(string numcuenta, Cuenta cuenta)
        {
            StreamWriter escritor;

            if (!Directory.Exists(PATH)) Directory.CreateDirectory(PATH);



            escritor = File.CreateText(GenerarNombre(numcuenta, cuenta));
            escritor.Close();
        }

        public static void EscribirFichero(string numcuenta, string Datos, Cuenta cuenta)
        {

            if (!File.Exists(GenerarNombre(numcuenta, cuenta))) AgregarFichero(numcuenta, cuenta);



            File.AppendAllText(GenerarNombre(numcuenta, cuenta), Datos);

        }

        public static void EliminarFichero(string numcuenta, Cuenta cuenta)
        {
            // Borrar Fichero

            File.Delete(GenerarNombre(numcuenta, cuenta));
        }

        public static void EditarFichero(string numcuenta, string numcuentaAntiguo, string Datos, Cuenta cuenta)
        {
            if (File.Exists(GenerarNombre(numcuentaAntiguo, cuenta))) EliminarFichero(numcuenta, cuenta);

            EscribirFichero(numcuenta, Datos, cuenta);
        }

        private static string GenerarNombre(string numcuenta, Cuenta cuenta)
        {

            string nombre = "";

            if (cuenta is CuentaJoven)
            {
                nombre = PATH + numcuenta + ".jov";
            }

            if (cuenta is CuentaOro)
            {
                nombre = PATH + numcuenta + ".oro";
            }

            if (cuenta is CuentaPlatino)
            {
                nombre = PATH + numcuenta + ".pla";
            }
            return nombre;
        }


    }
}
