using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero;

                do
                {
                    Console.Write("Introduce un numero entre 0 y 999: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero >= 0 && numero <= 9)
                    {
                        Console.WriteLine("Este numero tiene un solo digito.");
                    }
                    
                    if(numero >= 10 && numero <= 99)
                    {
                        Console.WriteLine("Este numero tiene 2 digitos.");
                    }

                    if (numero >= 100 && numero <= 999)
                    {
                        Console.WriteLine("Este numero tiene 3 digitos.");
                    }
                    Console.WriteLine();
                } while (numero >= 0 && numero <= 999);
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
