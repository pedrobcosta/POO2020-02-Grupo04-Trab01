using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Aluno
    {
        private string nome = "Arthur Honório Brandão";
        private string matricula = "11821ECP019";
        private string tel = "(34) 9 9922 6624";

        //constructor
        //letra A

        public Aluno ()
        {
            nome = "";
            matricula = "";
            tel = "";
        }

        public Aluno (string nome, string matricula, string tel)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.tel = tel;
        }

        //metodos
        //letra B
        public void Membros()
        {
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a matrícula: ");
            matricula = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            tel = Console.ReadLine();
        }

        //letra C
        public void Imprime()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Telefone: " + tel);
        }
    }
}
