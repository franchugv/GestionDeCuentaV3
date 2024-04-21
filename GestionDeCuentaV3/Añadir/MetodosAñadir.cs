using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Añadir
{
    public static class MetodosAñadir
    {

        public static void AñadirCuentaJoven(List <Cuenta> ListaC)
        {
            Cuenta Cuentas;
            string cadena = "";

            MetodosPrincipales.CargarDatos(out string titular, out string numcuenta, out double ingreso, out DateTime fechanac, "el titular", "el Número de cuenta", "el ingreso que desea añadir", "la fecha de nacimiento (Y-M-D)");

            Cuentas = new CuentaJoven(titular, ingreso, fechanac, numcuenta);
            // Contenido del fichero
            cadena = $"{titular}\n{ingreso}\n{fechanac}\n{numcuenta}";


            APIFichero.ApiFichero.EscribirFichero(Cuentas.NumCuenta, cadena);

            // Asignar datos a la lista de cuentas

            ListaC.Add(Cuentas);

        }



        public static void AñadirCuentaOro(List<Cuenta> ListaC)
        {
            Cuenta Cuentas;
            string cadena = "";

            MetodosPrincipales.CargarDatos(out string titular, out string numcuenta, out double ingreso, out DateTime fechanac, "el titular", "el Número de cuenta", "el ingreso que desea añadir", "la fecha de nacimiento (Y-M-D)");

            Cuentas = new CuentaOro(titular, ingreso, fechanac, numcuenta);
            cadena = $"{titular}\n{ingreso}\n{fechanac}\n{numcuenta}";


            APIFichero.ApiFichero.EscribirFichero(Cuentas.NumCuenta, cadena);

            // Asignar datos a la lista de cuentas

            ListaC.Add(Cuentas);

        }

        public static void AñadirCuentaPlatino(List<Cuenta> ListaC)
        {
            Cuenta Cuentas;
            string cadena = "";

            MetodosPrincipales.CargarDatos(out string titular, out string numcuenta, out double ingreso, out DateTime fechanac, "el titular", "el Número de cuenta", "el ingreso que desea añadir", "la fecha de nacimiento (Y-M-D)");

            Cuentas = new CuentaPlatino(titular, ingreso, fechanac, numcuenta);
            cadena = $"{titular}\n{ingreso}\n{fechanac}\n{numcuenta}";


            APIFichero.ApiFichero.EscribirFichero(Cuentas.NumCuenta, cadena);

            // Asignar datos a la lista de cuentas

            ListaC.Add(Cuentas);

        }







    }



}
