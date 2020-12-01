using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaQuestao5
{
    public partial class Form1 : Form
    {
        List<Aluno> lista_alunos = new List<Aluno>();
        List<Materia> lista_materias = new List<Materia>();
        public Form1()
        {
            InitializeComponent();
        }

        private void butNovoAluno_Click(object sender, EventArgs e)
        {
            string _nome = txtboxAlunoNome.Text;
            string _numero_matricula = txtboxAlunoNumMatr.Text;
            string _periodo = txtboxAlunoPeriodo.Text;
            Aluno _aluno = new Aluno(_nome, _numero_matricula, _periodo);
            lista_alunos.Add(_aluno);
            cboRelatorioAluno.Items.Clear();
            cboMateriaAluno.Items.Clear();
            foreach (Aluno a in lista_alunos)
            {
                cboRelatorioAluno.Items.Add(a);
                cboMateriaAluno.Items.Add(a);
            }
            txtboxAlunoNome.Text = "";
            txtboxAlunoNumMatr.Text = "";
            txtboxAlunoPeriodo.Text = "";
        }

        private void butNovaMateria_Click(object sender, EventArgs e)
        {
            string _nome = txtboxMateriaNome.Text;
            string _codigo = txtboxMateriaCodigo.Text;
            Materia _materia = new Materia(_nome, _codigo);
            lista_materias.Add(_materia);
            cboMateriaMateria.Items.Clear();
            foreach (Materia m in lista_materias)
            {
                cboMateriaMateria.Items.Add(m);
            }
            txtboxMateriaNome.Text = "";
            txtboxMateriaCodigo.Text = "";
        }

        private void butCadastroAluMat_Click(object sender, EventArgs e)
        {

            Aluno _aluno = ((Aluno)cboMateriaAluno.SelectedItem);
            Materia _materia = ((Materia)cboMateriaMateria.SelectedItem);
            _aluno.addMateria(_materia);
            cboMateriaAluno.Text = "";
            cboMateriaMateria.Text = "";
        }


        private void butRelatorio_Click(object sender, EventArgs e)
        {
            Aluno _aluno = ((Aluno)cboRelatorioAluno.SelectedItem);
            List<string> _relatorio = new List<string>();
            _relatorio.Add("Aluno:   " + _aluno.getNome());
            _relatorio.Add("\nNúmero de matrícula:   " + _aluno.getNumero_matricula());
            _relatorio.Add("\nPeríodo:   " + _aluno.getPeriodo());
            _relatorio.Add("\nMatérias:");
            foreach (Materia _materia in _aluno.getLista_materias())
            {
                _relatorio.Add("   " + _materia.getNome() + "   " + _materia.getCodigo());
            }
            rtxtboxRelatorio.Lines = _relatorio.ToArray();
            cboRelatorioAluno.Text = "";
        }
    }
}
