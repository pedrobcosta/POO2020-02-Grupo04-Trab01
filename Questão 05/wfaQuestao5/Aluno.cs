using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao5
{
    class Aluno
    {
        private string nome;
        private string numero_matricula;
        private string periodo;
        private List<Materia> lista_materias;

        //  Overrides
        public override string ToString()
        {
            return this.nome;

        }

        // Getters
        public string getNome()
        {
            return nome;
        }
        public string getNumero_matricula()
        {
            return numero_matricula;
        }
        public string getPeriodo()
        {
            return periodo;
        }
        public List<Materia> getLista_materias()
        {
            return lista_materias;
        }

        // Setters
        public void setNome(string _nome)
        {
            nome = _nome;
        }
        public void setNumero_matricula(string _numero_matricula)
        {
            numero_matricula = _numero_matricula;
        }
        public void setPeriodo(string _periodo)
        {
            periodo = _periodo;
        }

        // Construtores
        public Aluno(string _nome, string _numero_matricula, string _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new List<Materia>();
        }

        public Aluno()
        {
            nome = "Sem Nome";
            numero_matricula = "Sem Matricula";
            periodo = "Sem periodo";
            lista_materias = new List<Materia>();
        }

        // Métodos
        public void addMateria(Materia _materia)
        {
            lista_materias.Add(_materia);
        }
    }
}
