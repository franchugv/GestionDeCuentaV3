using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Eliminar
{
    public static class ControladorEliminar
    {
        public static void ControladorDel(List<Cuenta> ListaC)
        {
            // Recursos

            int EspecificarCuenta = 0;

            MetodosPrincipales.MostrarNumeroLista(ListaC);

            MetodosPrincipales.CaptarINT("la cuenta a Eliminar");

            MetodosEliminar.EliminarCuenta(ListaC, EspecificarCuenta);

            APIFichero.ApiFichero.EliminarFichero(ListaC[EspecificarCuenta].NumCuenta, ListaC[EspecificarCuenta]);

            UIEliminar.MensajeEliminar();
        }
    }
}
