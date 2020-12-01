using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO06
{
    class Program
    {
        static void Main(string[] args)
        {
            //v1
            Vetor3D v1 = new Vetor3D();
            Console.WriteLine("Insira a componente X do vetor 1: ");
            v1.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Y do vetor 1: ");
            v1.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Z do vetor 1: ");
            v1.Z = Convert.ToDouble(Console.ReadLine());

            //v2
            Vetor3D v2 = new Vetor3D();
            Console.WriteLine("Insira a componente X do vetor 2: ");
            v2.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Y do vetor 2: ");
            v2.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a componente Z do vetor 2: ");
            v2.Z = Convert.ToDouble(Console.ReadLine());

            //exibindo
            v1.Exibicao(v1, v2);

            Console.ReadKey();
        }
    }
}
