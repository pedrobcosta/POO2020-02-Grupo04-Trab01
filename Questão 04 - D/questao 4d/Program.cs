using System;

namespace questao_4d
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            Estacionamento[] p1 = new Estacionamento[5];
            Tempo[] e1 = new Tempo[5];
            Tempo[] s1 = new Tempo[5];
            Tempo[] c1 = new Tempo[5];

            for (i = 0; i < 5; i++)
            {
                p1[i] = new Estacionamento();
                e1[i] = new Tempo();
                s1[i] = new Tempo();
                Console.WriteLine("Digite o número da chapa do carro " + (i + 1) + " : ");
                p1[i].setnCarro(Console.ReadLine());

                Console.WriteLine("Digite a marca do carro " + (i + 1) + " : ");
                p1[i].setMarca(Console.ReadLine());

                Console.WriteLine("Digite o horario de entrada(hh:mm:secs) do carro " + (i + 1) +" : ");
                e1[i].setHora(Console.ReadLine());
                e1[i].setMin(Console.ReadLine());
                e1[i].setSecs(Console.ReadLine());

                Console.WriteLine("Digite o horario de saida(hh:mm:secs) do carro " + (i+1) +" : ");
                s1[i].setHora(Console.ReadLine());
                s1[i].setMin(Console.ReadLine());
                s1[i].setSecs(Console.ReadLine());
             
            }
            Console.WriteLine("\n\n\nRelatorio de dados: ");
            for (i = 0; i < 5; i++)
            {
                c1[i] = new Tempo();
                Console.WriteLine((i + 1) + " - Cliente: \n");
                p1[i].saida();
                Console.WriteLine("Horário de Entrada: ");
                e1[i].leitura();
                Console.WriteLine("Horário de saída: ");
                s1[i].leitura();
                c1[i] = s1[i].sub(e1[i]);
                Console.WriteLine("Horário de permanencia no estacionamento: ");
                c1[i].leitura();
                c1[i].cobrar();
                Console.WriteLine("\n\n\n");
            }
   
            Console.ReadLine();

        }
    }
}
