using System;
using System.Collections.Generic;
using System.Text;

namespace question_4
{
    class Estacionamento
    {
        public Estacionamento() //Default
        {

        }

        private String nCarro, nMarca;

        public String getnCarro()
        {
            return (nCarro);
        }
        public String getMarca()
        {
            return (nMarca);
        }

        public void setnCarro(String _nCarro)
        {
            nCarro = _nCarro;
        }
        public void setMarca(String _nMarca)
        {
            nMarca = _nMarca;
        }

        public void saida() //saida
        {
            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Numero do chassi do carro: " + nCarro);
            Console.WriteLine("Marca do carro: " + nMarca);

        }

    }
}
