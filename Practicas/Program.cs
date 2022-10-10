using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica1();
            //Sumar();
            Practica2();




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

    }
}
