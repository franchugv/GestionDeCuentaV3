using GestionDeCuentaV3.Principal;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCuentaV3.Añadir
{
    public enum OpcionesAñadir : byte { Salir, CuentaJoven, CuentaOro, CuentaPlatino }

    public static class ControladorAñadir
    {

        public static void ControladorA(List<Cuenta> ListaC)
        {
            OpcionesAñadir opcion = OpcionesAñadir.Salir;
            bool esValido;
            string merror = "";

            do
            {
                esValido = true;
                UIAñadir.MenuAñadir();

                try
                {
                    opcion = (OpcionesAñadir)MetodosPrincipales.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesAñadir>().Length);
                    
                    switch (opcion)
                    {
                        case OpcionesAñadir.Salir:
                            break;
                        case OpcionesAñadir.CuentaJoven:
                            MetodosAñadir.AñadirCuentaJoven(ListaC);
                            break;
                        case OpcionesAñadir.CuentaOro:
                            MetodosAñadir.AñadirCuentaOro(ListaC);
                            break;
                        case OpcionesAñadir.CuentaPlatino:
                            MetodosAñadir.AñadirCuentaPlatino(ListaC);
                            break;
                    }

                }
                catch (Exception Error)
                {
                    esValido = false;
                    merror = Error.Message;
                }
                finally
                {
                    if (!esValido) MetodosPrincipales.MostrarError(merror);
                }

            } while (!esValido || opcion != OpcionesAñadir.Salir);
        }

    }
}
