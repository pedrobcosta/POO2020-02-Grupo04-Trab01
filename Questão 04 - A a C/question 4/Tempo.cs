using System;
using System.Collections.Generic;
using System.Text;

namespace question_4
{
    class Tempo
    {
        private int hora;
        private int min;
        private int secs;

        public Tempo() //Construtor default
        {
            hora = 0;
            min = 0;
            secs = 0;
        }

        public int getHora()
        {
            return (hora);
        }
        public int getMin()
        {
            return (min);
        }
        public int getSecs()
        {
            return (secs);
        }

        public void setHora(String _hora)
        {
            hora = Convert.ToInt32(_hora);
        }
        public void setMin(String _min)
        {
            min = Convert.ToInt32(_min);
        }
        public void setSecs(String _secs)
        {
            secs = Convert.ToInt32(_secs);
        }

        public void leitura() // SAIDA
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

            while (secs < 0)
            {
                secs += 60;
                min -= 1;
            }
            while (min < 0)
            {
                min += 60;
                hora -= 1;
            }

            Console.WriteLine($"{ hora: 00}:{ min: 00}:{ secs: 00}");
        }

        public Tempo soma(Tempo t2)
        {
            Tempo t3 = new Tempo();
            t3.hora = hora + t2.hora;
            t3.min = min + t2.min;
            t3.secs = secs + t2.secs;

            return t3;
        }
        public Tempo sub(Tempo t2)
        {
            Tempo t3 = new Tempo();
            t3.hora = hora - t2.hora;
            t3.min = min - t2.min;
            t3.secs = secs - t2.secs;

            return t3;
        }
        public void cobrar() // SAIDA
        {
            int valor = 0;
            while ( hora > 0)
            {
                valor += 7;
                hora--;
            }
            if (min > 0 || secs > 0)
            {
                valor+= 7;
            }
            
            Console.WriteLine($"O Valor a ser cobrado é: R$" + valor);
        }
    }
}
