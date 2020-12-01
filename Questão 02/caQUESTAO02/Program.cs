using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO02
{
    class Program
    {
        static void Main(string[] args)
        {
            //v1
            Vetor2D v1 = new Vetor2D();
            Console.WriteLine("Insira a componente X do vetor 1: ");
            v1.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Y do vetor 1: ");
            v1.Y = Convert.ToDouble(Console.ReadLine());

            //v2
            Vetor2D v2 = new Vetor2D();
            Console.WriteLine("Insira a componente X do vetor 2: ");
            v2.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Y do vetor 2: ");
            v2.Y = Convert.ToDouble(Console.ReadLine());

            //exibindo
            v1.Exibicao(v1, v2);
           
            Console.ReadKey();
        }
    }
}
    