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

            //I define the variables

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
    }
}
