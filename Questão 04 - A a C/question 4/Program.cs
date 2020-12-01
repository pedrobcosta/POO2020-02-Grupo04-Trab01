using System;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento p1 = new Estacionamento();
            Tempo e1 = new Tempo();
            Tempo s1 = new Tempo();

            Console.WriteLine("Digite o número da chapa do carro: ");
            p1.setnCarro(Console.ReadLine());

            Console.WriteLine("Digite a marca do carro: ");
            p1.setMarca(Console.ReadLine());

            Console.WriteLine("Digite o horario de entrada(hh:mm:secs): ");
            e1.setHora(Console.ReadLine());
            e1.setMin(Console.ReadLine());
            e1.setSecs(Console.ReadLine());

            Console.WriteLine("Digite o horario de saida(hh:mm:secs): ");
            s1.setHora(Console.ReadLine());
            s1.setMin(Console.ReadLine());
            s1.setSecs(Console.ReadLine());

            //Questão b
            p1.saida();
            Console.WriteLine("Horário de Entrada: ");
            e1.leitura();
            Console.WriteLine("Horário de saída: ");
            s1.leitura();

            //Questão c
            Tempo c1 = new Tempo();
            c1 = s1.sub(e1);
            Console.WriteLine("Horário de permanencia no estacionamento: ");
            c1.leitura();
            c1.cobrar();

            Console.ReadLine();

        }
    }
}
