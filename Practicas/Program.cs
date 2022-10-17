using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        const string RESPUESTA_SI = "S";
        const string RESPUESTA_NO = "N";
        static void Main(string[] args)
        {
            //Practica1();
            //Sumar();
            //Practica2();
            //Practica3();
            //Practica3DoWhile();
            //Excepciones();
            //ExcepcionGenerica();
            //ExcepcionFinally();
            Practica4();


        }

        static void Practica1()
        {
            Console.WriteLine("Introduzca un valor para un radio: ");
            int radio = int.Parse(Console.ReadLine());
            //Console.WriteLine($"El valor del radio es {radio}");
            // System calculates the area
            const double PI = 3.14;
            double resultConversion = Convert.ToDouble(radio);
            //Console.WriteLine($"El valor del radio convertido es {resultConversion}");
            double area = PI * Math.Pow(resultConversion, 2);


            //System 
            // Console.WriteLine("El área del circulo de " + radio + " es " area);
            Console.WriteLine($"El área del circulo de {radio} es {area}");
        }

        #region Sumar
        static void Sumar()
        {
            int numero1 = 8;
            int numero2 = 13;

            Console.WriteLine(suma(numero1, numero2));
        }

        static int suma(int numero1, int numero2) => numero1 + numero2;
        #endregion


        #region Practica2
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("¿Cuál es su edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad < PUEDE_CONDUCIR)
            {
                Console.WriteLine("Eres menor de edad  y no puedes conducir");
            }
            else
            {
                Console.WriteLine("¿Tienes carné de conducir?");
                string respuesta = Console.ReadLine();

                if (respuesta.Equals(TIENE_CARNET))
                {
                    Console.WriteLine("Eres mayor de edad y tienes carné, por lo que puedes conducir");
                }
                else
                {
                    Console.WriteLine("Aunque seas mayor de edad, no tienes carné");
                }

            }

        }

        #endregion


        #region BucleWhile

        static void Practica3()
        {


        }


        //QUIÉRES ENTRAR? S/N
        //RESPUESTA: LEA DEL TECLADO.
        //Se comrpueba respuesta. 
        // Si respuesta = a s, vuelve a preguntar. Si no, se sale. 
        // Y si se da una respuesta distinta, se pide que de una respuesta correcta.


        #endregion
        static string LeerRespuesta()
        {


            string respuesta = string.Empty;

            Console.WriteLine("¿Quieres entrar en el bucle?");

            respuesta = Console.ReadLine().ToUpper();


            while (!respuesta.Equals(RESPUESTA_NO) && !respuesta.Equals(RESPUESTA_SI))
            {
                Console.WriteLine("Debes introducir N o S");
                respuesta = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Has salido del bucle");

            return respuesta;
        }






        #region DoWhile



        static string Practica3DoWhile()
        {
            string respuesta = string.Empty;

            Console.WriteLine("¿Quieres entrar en el bucle?");

                do
                {
                respuesta = Console.ReadLine().ToUpper();
                if (!respuesta.Equals(RESPUESTA_NO) && !respuesta.Equals(RESPUESTA_SI))
                    Console.WriteLine("Debes introducir N o S");
                    respuesta = Console.ReadLine().ToUpper();

                } while (!respuesta.Equals(RESPUESTA_NO) && !respuesta.Equals(RESPUESTA_SI));
                Console.WriteLine("Has salido del bucle");
            
            
            return respuesta;

        }

        #endregion



        #region Excepciones


        static void Excepciones()
        {
            int valor = 1;
            do
            {

                try
                {
                    Console.WriteLine("Introduce un número");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Se ha leído {valor}");
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("El formato del número no es correcto");

                }

                catch (OverflowException ex)
                {
                    Console.WriteLine("El número introducido es demasiado largo.");
                }
            }
            while (valor != 0);
        }
        #endregion

        #region Excepción Genérica

        static void ExcepcionGenerica()
        {
            try
            {
                Console.WriteLine("Introduce un número");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leído {valor}");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Enhorabuena, acabas de conseguir tu primer error System 32");

            }
        }

        #endregion


        #region


        static void ExcepcionFinally()
        {
            try
            {
                Console.WriteLine("Introduce un número");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leído {valor}");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Enhorabuena, acabas de conseguir tu primer error System 32");

            }

            finally
            {

                Console.WriteLine("Este finally sí tiene que salir");
            }
        }
        #endregion



        #region practica4
        static void Practica4()
        {

            const string PATH = @"C:\Users\manol\pruebaExcepcionesPractica4DisenoInterfaces/practica4.txt";

            System.IO.StreamReader archivo = null;
            string linea = string.Empty;

            try
            {
                archivo = new System.IO.StreamReader(PATH);
                linea = archivo.ReadLine();
                //Para que el sistema no se pare con los saltos de línea
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = archivo.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }

                Console.WriteLine("Conexión con el fichero cerrada");
            }

        }


        #endregion

    }

}

