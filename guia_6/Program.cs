using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace guia_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Turismo
            int cant_paseos,
                menor, // 
                ticket,
                cant_menores,
                cant_mayores,
                edad,
                pasaje_menor = 100;

            double descuento = 0,
                    recaudacion = 0;

            Console.Title = " **** Paseo por el Rio ****";
            Console.WriteLine("ingrese la cantidad de viajes para el dia: ");
            cant_paseos = Convert.ToInt32(Console.ReadLine()) ;
            Console.Beep(440, 2000);
            //Thread.Sleep(1000);

            for (int i = 0; i < cant_paseos + 3; i = i +1 )
            {
                cant_paseos = 0;
                cant_mayores = 0;
                cant_menores = 0;
                edad = 0;
                pasaje_menor = 100;
                recaudacion = 0;
                descuento = 0;
                do
                    {
                    Console.Clear();
                    Console.WriteLine("Viaje: {0}", i);
                    Console.WriteLine("ingrese edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    if  (edad < 12)
                        {
                        cant_menores++;
                        } else  {
                        cant_mayores++;
                         }
                }
                while (edad != -1);
                Console.WriteLine("la cantidad de menores es: {0} ", cant_menores);
                Console.WriteLine("la cantidad de mayores es: {0} ", cant_mayores);
                Console.Beep(440, 4000);

            }








        }
    }
}
