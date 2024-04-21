using GestionDeCuentaV3.Añadir;
using R24_JesusCG_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GestionDeCuentaV3.Principal
{
    public static class MetodosPrincipales
    {
        public static void MostrarError(string error)
        {
            Console.WriteLine($"Error: {error}");
            Pausa();
        }
        public static void Pausa()
        {
            Console.WriteLine("Pulse Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
        public static byte CaptarOpcionEnum(int NumOpciones)
        {
            // Recursos

            string aux = "";
            byte dato = 0;


                    aux = Console.ReadLine();

                    if (string.IsNullOrEmpty(aux)) throw new FormatException("cadena vacía");

                    dato = Convert.ToByte(aux);

                    if (dato >= NumOpciones) throw new OverflowException("La opción supera el rango de valores establecido");
                

            return dato;

        }

        public static string CaptarCadena(string text)
        {
           
            bool esValido;
            string dato = "";
            string merror = "";

            do
            {
                esValido = true;

                try
                {
                    Console.Write($"\nEscriba {text}: ");
                    dato = Console.ReadLine();
                    if (string.IsNullOrEmpty(dato)) throw new FormatException("cadena vacía");
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

            } while (!esValido);
            return dato;
        }

        public static double CaptarDouble(string text)
        {

            bool esValido;
            string aux = "";
            double dato = 0;
            string merror = "";

            do
            {
                esValido = true;

                try
                {
                    Console.Write($"\nEscriba {text}: ");

                    aux = Console.ReadLine();
                    if (string.IsNullOrEmpty(aux)) throw new FormatException("cadena vacía");
                    dato = Convert.ToDouble(aux);
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

            } while (!esValido);
            return dato;
        }

        public static DateTime CaptarDateTime(string text)
        {

            bool esValido;
            string aux = "";
            DateTime dato = new DateTime();
            string merror = "";

            do
            {
                esValido = true;

                try
                {
                    Console.Write($"\nEscriba {text}: ");

                    aux = Console.ReadLine();
                    if (string.IsNullOrEmpty(aux)) throw new FormatException("cadena vacía");
                    dato = Convert.ToDateTime(aux);
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

            } while (!esValido);
            return dato;
        }

        public static void CargarDatos(out string titular, out string numcuenta, out double ingreso, out DateTime fechanac, string textTitular, string textNum, string textIngreso, string textFecha)
        {

            titular = MetodosPrincipales.CaptarCadena(textTitular);
            MetodosPrincipales.Pausa();

            numcuenta = MetodosPrincipales.CaptarCadena(textNum);
            MetodosPrincipales.Pausa();

            ingreso = MetodosPrincipales.CaptarDouble(textIngreso);
            MetodosPrincipales.Pausa();

            fechanac = MetodosPrincipales.CaptarDateTime(textFecha);
            MetodosPrincipales.Pausa();

        }

        public static void MostrarNumeroLista(List<Cuenta> ListaC)
        {
            Console.WriteLine($"El número de cuentas disponibles es: {ListaC.ToArray().Length}");
        }

        public static int CaptarINT(string text)
        {
            // Recursos
            bool esValido;
            string merror = "";
            int dato = 0;
            string aux = "";


            do
            {
                esValido = true;
                Console.Write($"\nEscriba {text}: ");
                try
                {
                    aux = Console.ReadLine();
                    dato = Convert.ToInt32(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    merror = Error.Message;
                }
                finally
                {
                    if(!esValido)MetodosPrincipales.MostrarError(merror);
                }
            } while (!esValido);
            return dato;
            
        }

    }
}
