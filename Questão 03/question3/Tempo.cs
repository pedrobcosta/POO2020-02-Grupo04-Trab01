using System;
using System.Collections.Generic;
using System.Text;

namespace question3
{
    class Tempo
    {
        //ATRIBUTOS
        private int hora;
        private int min;
        private int secs;

        //CONSTRUTORES
        //letra A)
        public Tempo() //Construtor default
        {
            hora = 0;
            min = 0;
            secs = 0;
        } 

        public Tempo(String _hora, String _min, String _secs) //Construtor entrada
        {
            hora = Convert.ToInt32(_hora);
            min = Convert.ToInt32(_min);
            secs = Convert.ToInt32(_secs);
        }
       
        //MÉTODOS
        //letra B)
        public void Leitura() // Saida
        {
            
            while (secs >= 60)
            {
                secs -= 60;
                min += 1;
            }
            while (min >= 60)
            {
                min -= 60;
                hora += 1;
            }

            Console.WriteLine($"{ hora: 00}:{ min: 00}:{ secs: 00}");
        }

        //letra C)
        public Tempo Soma(Tempo t2)
        {
            Tempo t3 = new Tempo();
            t3.hora = hora + t2.hora;
            t3.min  = min + t2.min;
            t3.secs = secs + t2.secs;

            return t3;
        }
    }
}
