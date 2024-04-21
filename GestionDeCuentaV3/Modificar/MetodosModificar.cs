using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Modificar
{
    public static class MetodosModificar
    {
        public static void ModificarCuentas(List<Cuenta>ListaC, int EspecificarCuenta)
        {
            // Recursos

            string cadena = "";
            string numCuentaAntiguo;

            numCuentaAntiguo = ListaC[EspecificarCuenta].NumCuenta;
            

            MetodosPrincipales.CargarDatos(out string titular, out string numcuenta, out double ingreso, out DateTime fechanac, "el titular", "el Número de cuenta", "el ingreso que desea añadir", "la fecha de nacimiento (Y-M-D)");

            ListaC[EspecificarCuenta].Titular = titular;
            ListaC[EspecificarCuenta].NumCuenta = numcuenta;
            ListaC[EspecificarCuenta].Ingresar(ingreso);
            ListaC[EspecificarCuenta].FechaNacimiento = fechanac;

            cadena = $"{titular}\n{numcuenta}\n{ingreso}\n{fechanac}";

            APIFichero.ApiFichero.EditarFichero(ListaC[EspecificarCuenta].NumCuenta, numCuentaAntiguo, cadena);
        }
    }
}
