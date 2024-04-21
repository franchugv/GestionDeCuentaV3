using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Eliminar
{
    public static class MetodosEliminar
    {
        public static void EliminarCuenta(List<Cuenta> ListaC, int opcion)
        {

            ListaC.Remove(ListaC[opcion]);
        }
    }
}
