namespace wfaQuestao5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAluno = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butNovoAluno = new System.Windows.Forms.Button();
            this.txtboxAlunoPeriodo = new System.Windows.Forms.TextBox();
            this.txtboxAlunoNumMatr = new System.Windows.Forms.TextBox();
            this.txtboxAlunoNome = new System.Windows.Forms.TextBox();
            this.lblAlunoPeriodo = new System.Windows.Forms.Label();
            this.lblAlunoNumMatr = new System.Windows.Forms.Label();
            this.lblAlunoNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMateriaAluno = new System.Windows.Forms.Label();
            this.butNovaMateria = new System.Windows.Forms.Button();
            this.txtboxMateriaCodigo = new System.Windows.Forms.TextBox();
            this.lblMateriaCodigo = new System.Windows.Forms.Label();
            this.txtboxMateriaNome = new System.Windows.Forms.TextBox();
            this.lblMateriaNome = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblRelatorioAluno = new System.Windows.Forms.Label();
            this.cboRelatorioAluno = new System.Windows.Forms.ComboBox();
            this.butRelatorio = new System.Windows.Forms.Button();
            this.cboMateriaAluno = new System.Windows.Forms.ComboBox();
            this.rtxtboxRelatorio = new System.Windows.Forms.RichTextBox();
            this.lblMateriaTitulo1 = new System.Windows.Forms.Label();
            this.lblMateriaTitulo2 = new System.Windows.Forms.Label();
            this.lblMateriaMateria = new System.Windows.Forms.Label();
            this.cboMateriaMateria = new System.Windows.Forms.ComboBox();
            this.butCadastroAluMat = new System.Windows.Forms.Button();
            this.lblAlunoTitulo1 = new System.Windows.Forms.Label();
            this.tabAluno.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAluno
            // 
            this.tabAluno.Controls.Add(this.tabPage1);
            this.tabAluno.Controls.Add(this.tabPage2);
            this.tabAluno.Controls.Add(this.tabPage3);
            this.tabAluno.Location = new System.Drawing.Point(0, 1);
            this.tabAluno.Name = "tabAluno";
            this.tabAluno.SelectedIndex = 0;
            this.tabAluno.Size = new System.Drawing.Size(481, 373);
            this.tabAluno.TabIndex = 0;
            this.tabAluno.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAlunoTitulo1);
            this.tabPage1.Controls.Add(this.butNovoAluno);
            this.tabPage1.Controls.Add(this.txtboxAlunoPeriodo);
            this.tabPage1.Controls.Add(this.txtboxAlunoNumMatr);
            this.tabPage1.Controls.Add(this.txtboxAlunoNome);
            this.tabPage1.Controls.Add(this.lblAlunoPeriodo);
            this.tabPage1.Controls.Add(this.lblAlunoNumMatr);
            this.tabPage1.Controls.Add(this.lblAlunoNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butNovoAluno
            // 
            this.butNovoAluno.Location = new System.Drawing.Point(381, 175);
            this.butNovoAluno.Name = "butNovoAluno";
            this.butNovoAluno.Size = new System.Drawing.Size(81, 26);
            this.butNovoAluno.TabIndex = 6;
            this.butNovoAluno.Text = "Cadastrar";
            this.butNovoAluno.UseVisualStyleBackColor = true;
            this.butNovoAluno.Click += new System.EventHandler(this.butNovoAluno_Click);
            // 
            // txtboxAlunoPeriodo
            // 
            this.txtboxAlunoPeriodo.Location = new System.Drawing.Point(128, 149);
            this.txtboxAlunoPeriodo.Name = "txtboxAlunoPeriodo";
            this.txtboxAlunoPeriodo.Size = new System.Drawing.Size(339, 20);
            this.txtboxAlunoPeriodo.TabIndex = 5;
            // 
            // txtboxAlunoNumMatr
            // 
            this.txtboxAlunoNumMatr.Location = new System.Drawing.Point(128, 100);
            this.txtboxAlunoNumMatr.Name = "txtboxAlunoNumMatr";
            this.txtboxAlunoNumMatr.Size = new System.Drawing.Size(339, 20);
            this.txtboxAlunoNumMatr.TabIndex = 4;
            // 
            // txtboxAlunoNome
            // 
            this.txtboxAlunoNome.Location = new System.Drawing.Point(128, 54);
            this.txtboxAlunoNome.Name = "txtboxAlunoNome";
            this.txtboxAlunoNome.Size = new System.Drawing.Size(339, 20);
            this.txtboxAlunoNome.TabIndex = 3;
            // 
            // lblAlunoPeriodo
            // 
            this.lblAlunoPeriodo.AutoSize = true;
            this.lblAlunoPeriodo.Location = new System.Drawing.Point(6, 152);
            this.lblAlunoPeriodo.Name = "lblAlunoPeriodo";
            this.lblAlunoPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblAlunoPeriodo.TabIndex = 2;
            this.lblAlunoPeriodo.Text = "Período:";
            // 
            // lblAlunoNumMatr
            // 
            this.lblAlunoNumMatr.AutoSize = true;
            this.lblAlunoNumMatr.Location = new System.Drawing.Point(6, 103);
            this.lblAlunoNumMatr.Name = "lblAlunoNumMatr";
            this.lblAlunoNumMatr.Size = new System.Drawing.Size(109, 13);
            this.lblAlunoNumMatr.TabIndex = 1;
            this.lblAlunoNumMatr.Text = "Número de matrícula:";
            // 
            // lblAlunoNome
            // 
            this.lblAlunoNome.AutoSize = true;
            this.lblAlunoNome.Location = new System.Drawing.Point(6, 57);
            this.lblAlunoNome.Name = "lblAlunoNome";
            this.lblAlunoNome.Size = new System.Drawing.Size(38, 13);
            this.lblAlunoNome.TabIndex = 0;
            this.lblAlunoNome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.butCadastroAluMat);
            this.tabPage2.Controls.Add(this.cboMateriaMateria);
            this.tabPage2.Controls.Add(this.lblMateriaMateria);
            this.tabPage2.Controls.Add(this.lblMateriaTitulo2);
            this.tabPage2.Controls.Add(this.lblMateriaTitulo1);
            this.tabPage2.Controls.Add(this.cboMateriaAluno);
            this.tabPage2.Controls.Add(this.lblMateriaAluno);
            this.tabPage2.Controls.Add(this.butNovaMateria);
            this.tabPage2.Controls.Add(this.txtboxMateriaCodigo);
            this.tabPage2.Controls.Add(this.lblMateriaCodigo);
            this.tabPage2.Controls.Add(this.txtboxMateriaNome);
            this.tabPage2.Controls.Add(this.lblMateriaNome);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materia";
            // 
            // lblMateriaAluno
            // 
            this.lblMateriaAluno.AutoSize = true;
            this.lblMateriaAluno.Location = new System.Drawing.Point(8, 222);
            this.lblMateriaAluno.Name = "lblMateriaAluno";
            this.lblMateriaAluno.Size = new System.Drawing.Size(37, 13);
            this.lblMateriaAluno.TabIndex = 8;
            this.lblMateriaAluno.Text = "Aluno:";
            // 
            // butNovaMateria
            // 
            this.butNovaMateria.Location = new System.Drawing.Point(381, 128);
            this.butNovaMateria.Name = "butNovaMateria";
            this.butNovaMateria.Size = new System.Drawing.Size(81, 26);
            this.butNovaMateria.TabIndex = 7;
            this.butNovaMateria.Text = "Cadastrar";
            this.butNovaMateria.UseVisualStyleBackColor = true;
            this.butNovaMateria.Click += new System.EventHandler(this.butNovaMateria_Click);
            // 
            // txtboxMateriaCodigo
            // 
            this.txtboxMateriaCodigo.Location = new System.Drawing.Point(63, 102);
            this.txtboxMateriaCodigo.Name = "txtboxMateriaCodigo";
            this.txtboxMateriaCodigo.Size = new System.Drawing.Size(399, 20);
            this.txtboxMateriaCodigo.TabIndex = 3;
            // 
            // lblMateriaCodigo
            // 
            this.lblMateriaCodigo.AutoSize = true;
            this.lblMateriaCodigo.Location = new System.Drawing.Point(6, 105);
            this.lblMateriaCodigo.Name = "lblMateriaCodigo";
            this.lblMateriaCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblMateriaCodigo.TabIndex = 2;
            this.lblMateriaCodigo.Text = "Código:";
            // 
            // txtboxMateriaNome
            // 
            this.txtboxMateriaNome.Location = new System.Drawing.Point(63, 53);
            this.txtboxMateriaNome.Name = "txtboxMateriaNome";
            this.txtboxMateriaNome.Size = new System.Drawing.Size(399, 20);
            this.txtboxMateriaNome.TabIndex = 1;
            // 
            // lblMateriaNome
            // 
            this.lblMateriaNome.AutoSize = true;
            this.lblMateriaNome.Location = new System.Drawing.Point(6, 56);
            this.lblMateriaNome.Name = "lblMateriaNome";
            this.lblMateriaNome.Size = new System.Drawing.Size(38, 13);
            this.lblMateriaNome.TabIndex = 0;
            this.lblMateriaNome.Text = "Nome:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtxtboxRelatorio);
            this.tabPage3.Controls.Add(this.butRelatorio);
            this.tabPage3.Controls.Add(this.lblRelatorioAluno);
            this.tabPage3.Controls.Add(this.cboRelatorioAluno);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relatorio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblRelatorioAluno
            // 
            this.lblRelatorioAluno.AutoSize = true;
            this.lblRelatorioAluno.Location = new System.Drawing.Point(8, 17);
            this.lblRelatorioAluno.Name = "lblRelatorioAluno";
            this.lblRelatorioAluno.Size = new System.Drawing.Size(37, 13);
            this.lblRelatorioAluno.TabIndex = 1;
            this.lblRelatorioAluno.Text = "Aluno:";
            // 
            // cboRelatorioAluno
            // 
            this.cboRelatorioAluno.FormattingEnabled = true;
            this.cboRelatorioAluno.Location = new System.Drawing.Point(51, 14);
            this.cboRelatorioAluno.Name = "cboRelatorioAluno";
            this.cboRelatorioAluno.Size = new System.Drawing.Size(298, 21);
            this.cboRelatorioAluno.TabIndex = 0;
            // 
            // butRelatorio
            // 
            this.butRelatorio.Location = new System.Drawing.Point(355, 4);
            this.butRelatorio.Name = "butRelatorio";
            this.butRelatorio.Size = new System.Drawing.Size(107, 39);
            this.butRelatorio.TabIndex = 8;
            this.butRelatorio.Tag = "";
            this.butRelatorio.Text = "Gerar Relatório";
            this.butRelatorio.UseVisualStyleBackColor = true;
            this.butRelatorio.Click += new System.EventHandler(this.butRelatorio_Click);
            // 
            // cboMateriaAluno
            // 
            this.cboMateriaAluno.FormattingEnabled = true;
            this.cboMateriaAluno.Location = new System.Drawing.Point(63, 219);
            this.cboMateriaAluno.Name = "cboMateriaAluno";
            this.cboMateriaAluno.Size = new System.Drawing.Size(216, 21);
            this.cboMateriaAluno.TabIndex = 12;
            // 
            // rtxtboxRelatorio
            // 
            this.rtxtboxRelatorio.Location = new System.Drawing.Point(8, 49);
            this.rtxtboxRelatorio.Name = "rtxtboxRelatorio";
            this.rtxtboxRelatorio.ReadOnly = true;
            this.rtxtboxRelatorio.Size = new System.Drawing.Size(454, 286);
            this.rtxtboxRelatorio.TabIndex = 9;
            this.rtxtboxRelatorio.Text = "";
            // 
            // lblMateriaTitulo1
            // 
            this.lblMateriaTitulo1.AutoSize = true;
            this.lblMateriaTitulo1.BackColor = System.Drawing.Color.Pink;
            this.lblMateriaTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaTitulo1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMateriaTitulo1.Location = new System.Drawing.Point(8, 12);
            this.lblMateriaTitulo1.Name = "lblMateriaTitulo1";
            this.lblMateriaTitulo1.Size = new System.Drawing.Size(128, 13);
            this.lblMateriaTitulo1.TabIndex = 13;
            this.lblMateriaTitulo1.Text = "Cadastro de nova matéria";
            // 
            // lblMateriaTitulo2
            // 
            this.lblMateriaTitulo2.AutoSize = true;
            this.lblMateriaTitulo2.BackColor = System.Drawing.Color.LightPink;
            this.lblMateriaTitulo2.Location = new System.Drawing.Point(8, 177);
            this.lblMateriaTitulo2.Name = "lblMateriaTitulo2";
            this.lblMateriaTitulo2.Size = new System.Drawing.Size(170, 13);
            this.lblMateriaTitulo2.TabIndex = 14;
            this.lblMateriaTitulo2.Text = "Cadastro de aluno em uma matéria";
            // 
            // lblMateriaMateria
            // 
            this.lblMateriaMateria.AutoSize = true;
            this.lblMateriaMateria.Location = new System.Drawing.Point(8, 270);
            this.lblMateriaMateria.Name = "lblMateriaMateria";
            this.lblMateriaMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateriaMateria.TabIndex = 15;
            this.lblMateriaMateria.Text = "Matéria:";
            // 
            // cboMateriaMateria
            // 
            this.cboMateriaMateria.FormattingEnabled = true;
            this.cboMateriaMateria.Location = new System.Drawing.Point(63, 267);
            this.cboMateriaMateria.Name = "cboMateriaMateria";
            this.cboMateriaMateria.Size = new System.Drawing.Size(216, 21);
            this.cboMateriaMateria.TabIndex = 16;
            // 
            // butCadastroAluMat
            // 
            this.butCadastroAluMat.Location = new System.Drawing.Point(198, 294);
            this.butCadastroAluMat.Name = "butCadastroAluMat";
            this.butCadastroAluMat.Size = new System.Drawing.Size(81, 26);
            this.butCadastroAluMat.TabIndex = 17;
            this.butCadastroAluMat.Text = "Cadastrar";
            this.butCadastroAluMat.UseVisualStyleBackColor = true;
            this.butCadastroAluMat.Click += new System.EventHandler(this.butCadastroAluMat_Click);
            // 
            // lblAlunoTitulo1
            // 
            this.lblAlunoTitulo1.AutoSize = true;
            this.lblAlunoTitulo1.BackColor = System.Drawing.Color.Pink;
            this.lblAlunoTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunoTitulo1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAlunoTitulo1.Location = new System.Drawing.Point(8, 12);
            this.lblAlunoTitulo1.Name = "lblAlunoTitulo1";
            this.lblAlunoTitulo1.Size = new System.Drawing.Size(120, 13);
            this.lblAlunoTitulo1.TabIndex = 14;
            this.lblAlunoTitulo1.Text = "Cadastro de novo aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 370);
            this.Controls.Add(this.tabAluno);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno/Materia";
            this.tabAluno.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAluno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblAlunoNumMatr;
        private System.Windows.Forms.Label lblAlunoNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblAlunoPeriodo;
        private System.Windows.Forms.Button butNovoAluno;
        private System.Windows.Forms.TextBox txtboxAlunoPeriodo;
        private System.Windows.Forms.TextBox txtboxAlunoNumMatr;
        private System.Windows.Forms.TextBox txtboxAlunoNome;
        private System.Windows.Forms.Label lblMateriaNome;
        private System.Windows.Forms.Label lblMateriaCodigo;
        private System.Windows.Forms.TextBox txtboxMateriaNome;
        private System.Windows.Forms.TextBox txtboxMateriaCodigo;
        private System.Windows.Forms.Button butNovaMateria;
        private System.Windows.Forms.Label lblMateriaAluno;
        private System.Windows.Forms.Label lblRelatorioAluno;
        private System.Windows.Forms.ComboBox cboRelatorioAluno;
        private System.Windows.Forms.Button butRelatorio;
        private System.Windows.Forms.ComboBox cboMateriaAluno;
        private System.Windows.Forms.RichTextBox rtxtboxRelatorio;
        private System.Windows.Forms.Button butCadastroAluMat;
        private System.Windows.Forms.ComboBox cboMateriaMateria;
        private System.Windows.Forms.Label lblMateriaMateria;
        private System.Windows.Forms.Label lblMateriaTitulo2;
        private System.Windows.Forms.Label lblMateriaTitulo1;
        private System.Windows.Forms.Label lblAlunoTitulo1;
    }
}

