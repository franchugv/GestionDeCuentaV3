using GestionDeCuentaV3.Añadir;
using GestionDeCuentaV3.Consultar;
using GestionDeCuentaV3.Eliminar;
using GestionDeCuentaV3.Modificar;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Principal
{
    public enum OpcionesPrincipal : byte { Salir, Añadir, Modificar, Eliminar, Consultar }
    public static class MainController
    {
        public static void ControladorP()
        {
            // Recursos
            OpcionesPrincipal opcion = OpcionesPrincipal.Salir;
            bool esValido;
            string merror = "";

            List<Cuenta> ListaCuentas = new List<Cuenta>();

            do
            {
                esValido = true;
                UIPrincipal.MenuPrincipal();

                try
                {
                    opcion = (OpcionesPrincipal)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);

                    switch (opcion)
                    {
                        case OpcionesPrincipal.Salir:
                            break;
                        case OpcionesPrincipal.Añadir:
                            ControladorAñadir.ControladorA(ListaCuentas);
                            break;
                        case OpcionesPrincipal.Modificar:
                            ControladorModificar.ControladorM(ListaCuentas);
                            break;
                        case OpcionesPrincipal.Eliminar:
                            ControladorEliminar.ControladorDel(ListaCuentas);
                            break;
                        case OpcionesPrincipal.Consultar:
                            ControladorConsultar.ControladorC(ListaCuentas);
                            break;
                    }
                }
                catch (Exception error)
                {
                    esValido = false;
                    merror = error.Message;
                }
                finally
                {
                    if (!esValido) MetodosPrincipales.MostrarError(merror);
                }

            } while (!esValido || opcion != OpcionesPrincipal.Salir);


        }
    }
}
