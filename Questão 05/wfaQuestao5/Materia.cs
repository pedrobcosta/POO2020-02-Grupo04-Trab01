using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao5
{
    class Materia
    {
        private string nome;
        private string codigo;

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
        public string getCodigo()
        {
            return codigo;
        }

        // Setters
        public void setNome(string _nome)
        {
            nome = _nome;
        }
        public void setCodigo(string _codigo)
        {
            codigo = _codigo;
        }

        // Contrutores
        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }
        public Materia()
        {
            nome = "Sem nome";
            codigo = "Sem código";
        }
    }
}
