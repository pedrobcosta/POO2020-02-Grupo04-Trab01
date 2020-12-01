using System;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {   
            String hora, min, secs;
            
            //T1
            Console.WriteLine("Digite a hora, minutos e segundos do primeiro tempo: ");
            hora = Console.ReadLine();
            min = Console.ReadLine();
            secs = Console.ReadLine();
            Tempo t1 = new Tempo(hora, min, secs);
            t1.Leitura();
           
            //T2
            Console.WriteLine("Digite a hora, minutos e segundos do segundo tempo: ");
            hora = Console.ReadLine();
            min = Console.ReadLine();
            secs = Console.ReadLine();
            Tempo t2 = new Tempo(hora, min, secs);
            t2.Leitura();
          
            //T3
            Tempo t3 = new Tempo();
            t3 = t1.Soma(t2); //Somatorio dos hora
            Console.WriteLine("\nA soma dos tempos eh: ");
            t3.Leitura(); 
            
            Console.ReadLine();
        }
    }
}
