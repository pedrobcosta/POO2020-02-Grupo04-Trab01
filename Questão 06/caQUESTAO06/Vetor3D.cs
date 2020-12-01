using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO06
{
    class Vetor3D : Vetor2D
    {
        //ATRIBUTOS
        public double z;

        //CONSTRUTORES
        public Vetor3D()
        {
            z = 0.0;
        }

        public Vetor3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //GETTERS E SETTERS
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        //MÉTODOS
        private double Modulo(Vetor3D v)
        {
            double modulo;
            modulo = System.Math.Sqrt((v.x * v.x) + (v.y * v.y) + (v.z * v.z));
            return modulo;
        }

        private Vetor3D ProdVetorial(Vetor3D vA, Vetor3D vB)
        {
            Vetor3D produto = new Vetor3D();
            produto.x = (vA.y * vB.z) - (vA.z * vB.y);
            produto.y = (vA.z * vB.x) - (vA.x * vB.z);
            produto.z = (vA.x * vB.y) - (vA.y * vB.x);
            return produto;
        }

        //MÉTODO PARA TESTE
        public void Exibicao(Vetor3D vA, Vetor3D vB)
        {
            Console.WriteLine("O módulo de vA é: " + Modulo(vA) + ".");
            Console.WriteLine("O módulo de vB é: " + Modulo(vB) + ".");
            Console.WriteLine("O produto vetorial de vA e vB é: " + ProdVetorial(vA, vB).x + " em x; " + ProdVetorial(vA, vB).y + " em y; " + ProdVetorial(vA, vB).z + " em z.");
        }
    }
}
