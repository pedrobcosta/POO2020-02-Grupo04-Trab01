using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQUESTAO06
{
    public class Vetor2D
    {
        //ATRIBUTOS
        protected double x;
        protected double y;

        //CONSTRUTORES
        //letra A)
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }

        public Vetor2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //GETTERS E SETTERS
        //letra B)
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        //MÉTODOS
        //letra C)
        private double ProdEscalar(Vetor2D vA, Vetor2D vB)
        {
            double produto;
            produto = (vA.x * vB.x) + (vA.y * vB.y);
            return produto;
        }

        //letra D)
        private double Modulo(Vetor2D v)
        {
            double modulo;
            modulo = System.Math.Sqrt((v.x * v.x) + (v.y * v.y));
            return modulo;
        }

        //letra E)
        private double Angulo(Vetor2D vA, Vetor2D vB)
        {
            double angulo;
            angulo = System.Math.Acos(ProdEscalar(vA, vB) / (Modulo(vA) * Modulo(vB))); //usando funcao de arccosseno da .Math
            angulo = (angulo * 180) / System.Math.PI; //convertendo pra graus
            return angulo;
        }

        //letra F)
        private Vetor2D Projecao(Vetor2D vA, Vetor2D vB)
        {
            Vetor2D projecao = new Vetor2D();
            projecao.x = (ProdEscalar(vA, vB) / (Modulo(vA) * Modulo(vA))) * vA.x;
            projecao.y = (ProdEscalar(vA, vB) / (Modulo(vA) * Modulo(vA))) * vA.y;
            return projecao;
        }

    }
}
