using GestionDeCuentaV3.APIFichero;
using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Consultar
{
    public static class ControladorConsultar
    {
        public static void ControladorC(List<Cuenta> ListaC)
        {
            // Recursos
            int EspecificarCuenta = 0;

            MetodosPrincipales.MostrarNumeroLista(ListaC);

            EspecificarCuenta = MetodosPrincipales.CaptarINT("la Cuenta a Consultar");

            MetodosPrincipales.MostrarDato(ApiFichero.ConsultarFichero(ListaC[EspecificarCuenta].NumCuenta, ListaC[EspecificarCuenta]));
        }
    }
}
