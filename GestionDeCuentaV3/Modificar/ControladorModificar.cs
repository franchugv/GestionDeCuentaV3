using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Modificar
{
    public static class ControladorModificar
    {
        public static void ControladorM(List<Cuenta> ListC)
        {
            // Recursos
            int num = 0;
            MetodosPrincipales.MostrarNumeroLista(ListC);

            num = MetodosPrincipales.CaptarINT("la cuenta que desea modificar") - 1;

            MetodosModificar.ModificarCuentas(ListC, num);
        }
    }
}
