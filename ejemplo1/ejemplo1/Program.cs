using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;  
            double nota3 = 0;
            Console.WriteLine("ingrese las 3 notas");
            nota1= Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());
            double promedio = nota1 + nota2 + nota3 / 3;
            Console.WriteLine("promedio de las notas " + promedio);
            if(promedio >= 6)
            {
                Console.WriteLine("promocion");
            }
            else if( promedio >= 4)
            {
                Console.WriteLine("Regular");
            }
            Console.WriteLine("No Aprobo");
            Console.ReadKey();
            
        }
    }
}
