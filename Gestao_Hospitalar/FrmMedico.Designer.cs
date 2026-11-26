namespace Gestao_Hospitalar
{
    partial class FrmMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AgendamentoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.PacienteTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.listagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentiPorDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemPorEspecialidadeMédicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeAtendimentoPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspec = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtCRMmed = new System.Windows.Forms.TextBox();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.cboEspecMed = new System.Windows.Forms.ComboBox();
            this.txtCelularMed = new System.Windows.Forms.TextBox();
            this.txtEmailMed = new System.Windows.Forms.TextBox();
            this.btnPesqGeral = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesqInd = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dtpNascMed = new System.Windows.Forms.DateTimePicker();
            this.DataGridMedico = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTSM
            // 
            this.MenuTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgendamentoTSM,
            this.MedicoTSM,
            this.PacienteTSM,
            this.atendimentoTSM,
            this.listagensToolStripMenuItem});
            this.MenuTSM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTSM.Name = "MenuTSM";
            this.MenuTSM.Size = new System.Drawing.Size(58, 24);
            this.MenuTSM.Text = "Menu";
            // 
            // AgendamentoTSM
            // 
            this.AgendamentoTSM.Name = "AgendamentoTSM";
            this.AgendamentoTSM.Size = new System.Drawing.Size(173, 24);
            this.AgendamentoTSM.Text = "Agendamento";
            this.AgendamentoTSM.Click += new System.EventHandler(this.AgendamentoTSM_Click);
            // 
            // MedicoTSM
            // 
            this.MedicoTSM.Name = "MedicoTSM";
            this.MedicoTSM.Size = new System.Drawing.Size(173, 24);
            this.MedicoTSM.Text = "Médico";
            this.MedicoTSM.Click += new System.EventHandler(this.MedicoTSM_Click);
            // 
            // PacienteTSM
            // 
            this.PacienteTSM.Name = "PacienteTSM";
            this.PacienteTSM.Size = new System.Drawing.Size(173, 24);
            this.PacienteTSM.Text = "Paciente";
            this.PacienteTSM.Click += new System.EventHandler(this.PacienteTSM_Click);
            // 
            // atendimentoTSM
            // 
            this.atendimentoTSM.Name = "atendimentoTSM";
            this.atendimentoTSM.Size = new System.Drawing.Size(173, 24);
            this.atendimentoTSM.Text = "Atendimento";
            this.atendimentoTSM.Click += new System.EventHandler(this.atendimentoTSM_Click);
            // 
            // listagensToolStripMenuItem
            // 
            this.listagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem1,
            this.pacienteToolStripMenuItem1,
            this.agendamentoToolStripMenuItem,
            this.atendimentiPorDiaToolStripMenuItem,
            this.listagemPorEspecialidadeMédicaToolStripMenuItem,
            this.quantidadeAtendimentoPorMêsToolStripMenuItem});
            this.listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.listagensToolStripMenuItem.Text = "Listagens";
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(332, 24);
            this.médicoToolStripMenuItem1.Text = "1- Médico";
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(332, 24);
            this.pacienteToolStripMenuItem1.Text = "2- Paciente";
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.agendamentoToolStripMenuItem.Text = "3- Agendamento";
            // 
            // atendimentiPorDiaToolStripMenuItem
            // 
            this.atendimentiPorDiaToolStripMenuItem.Name = "atendimentiPorDiaToolStripMenuItem";
            this.atendimentiPorDiaToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.atendimentiPorDiaToolStripMenuItem.Text = "4- Atendimento por dia";
            // 
            // listagemPorEspecialidadeMédicaToolStripMenuItem
            // 
            this.listagemPorEspecialidadeMédicaToolStripMenuItem.Name = "listagemPorEspecialidadeMédicaToolStripMenuItem";
            this.listagemPorEspecialidadeMédicaToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.listagemPorEspecialidadeMédicaToolStripMenuItem.Text = "5- Listagem por especialidade médica";
            // 
            // quantidadeAtendimentoPorMêsToolStripMenuItem
            // 
            this.quantidadeAtendimentoPorMêsToolStripMenuItem.Name = "quantidadeAtendimentoPorMêsToolStripMenuItem";
            this.quantidadeAtendimentoPorMêsToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.quantidadeAtendimentoPorMêsToolStripMenuItem.Text = "6- Quantidade Atendimento por mês";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(13, 59);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(45, 20);
            this.lblCRM.TabIndex = 21;
            this.lblCRM.Text = "CRM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(194, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // lblEspec
            // 
            this.lblEspec.AutoSize = true;
            this.lblEspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspec.Location = new System.Drawing.Point(13, 94);
            this.lblEspec.Name = "lblEspec";
            this.lblEspec.Size = new System.Drawing.Size(108, 20);
            this.lblEspec.TabIndex = 23;
            this.lblEspec.Text = "Especialidade";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(13, 130);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 20);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(13, 205);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(93, 20);
            this.lblNasc.TabIndex = 26;
            this.lblNasc.Text = "Nascimento";
            // 
            // txtCRMmed
            // 
            this.txtCRMmed.Location = new System.Drawing.Point(65, 58);
            this.txtCRMmed.MaxLength = 6;
            this.txtCRMmed.Name = "txtCRMmed";
            this.txtCRMmed.Size = new System.Drawing.Size(100, 20);
            this.txtCRMmed.TabIndex = 27;
            this.txtCRMmed.TextChanged += new System.EventHandler(this.txtCRMmed_TextChanged);
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(252, 58);
            this.txtNomeMed.MaxLength = 50;
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(151, 20);
            this.txtNomeMed.TabIndex = 28;
            // 
            // cboEspecMed
            // 
            this.cboEspecMed.FormattingEnabled = true;
            this.cboEspecMed.Location = new System.Drawing.Point(127, 93);
            this.cboEspecMed.MaxLength = 50;
            this.cboEspecMed.Name = "cboEspecMed";
            this.cboEspecMed.Size = new System.Drawing.Size(151, 21);
            this.cboEspecMed.TabIndex = 29;
            // 
            // txtCelularMed
            // 
            this.txtCelularMed.Location = new System.Drawing.Point(127, 132);
            this.txtCelularMed.MaxLength = 30;
            this.txtCelularMed.Name = "txtCelularMed";
            this.txtCelularMed.Size = new System.Drawing.Size(151, 20);
            this.txtCelularMed.TabIndex = 30;
            // 
            // txtEmailMed
            // 
            this.txtEmailMed.Location = new System.Drawing.Point(127, 170);
            this.txtEmailMed.MaxLength = 255;
            this.txtEmailMed.Name = "txtEmailMed";
            this.txtEmailMed.Size = new System.Drawing.Size(151, 20);
            this.txtEmailMed.TabIndex = 31;
            // 
            // btnPesqGeral
            // 
            this.btnPesqGeral.Location = new System.Drawing.Point(171, 297);
            this.btnPesqGeral.Name = "btnPesqGeral";
            this.btnPesqGeral.Size = new System.Drawing.Size(149, 47);
            this.btnPesqGeral.TabIndex = 45;
            this.btnPesqGeral.Text = "Pesquisa Geral";
            this.btnPesqGeral.UseVisualStyleBackColor = true;
            this.btnPesqGeral.Click += new System.EventHandler(this.btnPesqGeral_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(171, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesqInd
            // 
            this.btnPesqInd.Location = new System.Drawing.Point(16, 297);
            this.btnPesqInd.Name = "btnPesqInd";
            this.btnPesqInd.Size = new System.Drawing.Size(149, 47);
            this.btnPesqInd.TabIndex = 43;
            this.btnPesqInd.Text = "Pesquisa Individual";
            this.btnPesqInd.UseVisualStyleBackColor = true;
            this.btnPesqInd.Click += new System.EventHandler(this.btnPesqInd_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(16, 244);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(149, 47);
            this.btnIncluir.TabIndex = 42;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizar
            //
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(16, 350);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(149, 47);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            //
            // dtpNascMed
            // 
            this.dtpNascMed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascMed.Location = new System.Drawing.Point(127, 204);
            this.dtpNascMed.Name = "dtpNascMed";
            this.dtpNascMed.Size = new System.Drawing.Size(151, 20);
            this.dtpNascMed.TabIndex = 46;
            // 
            // DataGridMedico
            // 
            this.DataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMedico.Location = new System.Drawing.Point(402, 194);
            this.DataGridMedico.AllowUserToAddRows = false;
            this.DataGridMedico.AllowUserToDeleteRows = false;
            this.DataGridMedico.ReadOnly = true;
            this.DataGridMedico.Name = "DataGridMedico";
            this.DataGridMedico.Size = new System.Drawing.Size(240, 150);
            this.DataGridMedico.TabIndex = 47;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.DataGridMedico);
            this.Controls.Add(this.dtpNascMed);
            this.Controls.Add(this.btnPesqGeral);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesqInd);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtEmailMed);
            this.Controls.Add(this.txtCelularMed);
            this.Controls.Add(this.cboEspecMed);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.txtCRMmed);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEspec);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMedico";
            this.Text = "FORMULARIO MEDICO";
            this.Load += new System.EventHandler(this.FrmMedico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTSM;
        private System.Windows.Forms.ToolStripMenuItem AgendamentoTSM;
        private System.Windows.Forms.ToolStripMenuItem MedicoTSM;
        private System.Windows.Forms.ToolStripMenuItem PacienteTSM;
        private System.Windows.Forms.ToolStripMenuItem atendimentoTSM;
        private System.Windows.Forms.ToolStripMenuItem listagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentiPorDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemPorEspecialidadeMédicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeAtendimentoPorMêsToolStripMenuItem;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEspec;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.TextBox txtCRMmed;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.ComboBox cboEspecMed;
        private System.Windows.Forms.TextBox txtCelularMed;
        private System.Windows.Forms.TextBox txtEmailMed;
        private System.Windows.Forms.Button btnPesqGeral;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesqInd;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DateTimePicker dtpNascMed;
        private System.Windows.Forms.DataGridView DataGridMedico;
    }
}