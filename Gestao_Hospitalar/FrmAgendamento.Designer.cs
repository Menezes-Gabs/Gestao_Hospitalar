namespace Gestao_Hospitalar
{
    partial class FrmAgendamento
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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCodAgend = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblHintEspec = new System.Windows.Forms.Label();
            this.lblHintNome = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.HorarioAgend = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspec = new System.Windows.Forms.Label();
            this.DateAgend = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesqInd = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesqGeral = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 28);
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
            // 
            // MedicoTSM
            // 
            this.MedicoTSM.Name = "MedicoTSM";
            this.MedicoTSM.Size = new System.Drawing.Size(173, 24);
            this.MedicoTSM.Text = "Médico";
            // 
            // PacienteTSM
            // 
            this.PacienteTSM.Name = "PacienteTSM";
            this.PacienteTSM.Size = new System.Drawing.Size(173, 24);
            this.PacienteTSM.Text = "Paciente";
            // 
            // atendimentoTSM
            // 
            this.atendimentoTSM.Name = "atendimentoTSM";
            this.atendimentoTSM.Size = new System.Drawing.Size(173, 24);
            this.atendimentoTSM.Text = "Atendimento";
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
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(13, 47);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(89, 20);
            this.lblCod.TabIndex = 21;
            this.lblCod.Text = "Cod.Agend";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(13, 81);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(45, 20);
            this.lblCRM.TabIndex = 22;
            this.lblCRM.Text = "CRM";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(13, 114);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 146);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Data";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status";
            // 
            // txtCodAgend
            // 
            this.txtCodAgend.Location = new System.Drawing.Point(109, 46);
            this.txtCodAgend.Name = "txtCodAgend";
            this.txtCodAgend.Size = new System.Drawing.Size(100, 20);
            this.txtCodAgend.TabIndex = 26;
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(109, 81);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 27;
            this.txtCRM.Leave += new System.EventHandler(this.txtCRM_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(109, 116);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 28;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(109, 177);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 30;
            // 
            // lblHintEspec
            // 
            this.lblHintEspec.AutoSize = true;
            this.lblHintEspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintEspec.Location = new System.Drawing.Point(227, 88);
            this.lblHintEspec.Name = "lblHintEspec";
            this.lblHintEspec.Size = new System.Drawing.Size(108, 20);
            this.lblHintEspec.TabIndex = 31;
            this.lblHintEspec.Text = "Especialidade";
            // 
            // lblHintNome
            // 
            this.lblHintNome.AutoSize = true;
            this.lblHintNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintNome.Location = new System.Drawing.Point(227, 121);
            this.lblHintNome.Name = "lblHintNome";
            this.lblHintNome.Size = new System.Drawing.Size(51, 20);
            this.lblHintNome.TabIndex = 32;
            this.lblHintNome.Text = "Nome";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(227, 155);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(61, 20);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "Horario";
            // 
            // HorarioAgend
            // 
            this.HorarioAgend.CustomFormat = "HH:mm";
            this.HorarioAgend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HorarioAgend.Location = new System.Drawing.Point(294, 155);
            this.HorarioAgend.Name = "HorarioAgend";
            this.HorarioAgend.ShowUpDown = true;
            this.HorarioAgend.Size = new System.Drawing.Size(76, 20);
            this.HorarioAgend.TabIndex = 34;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(291, 126);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(16, 13);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "...";
            // 
            // lblEspec
            // 
            this.lblEspec.AutoSize = true;
            this.lblEspec.Location = new System.Drawing.Point(342, 94);
            this.lblEspec.Name = "lblEspec";
            this.lblEspec.Size = new System.Drawing.Size(16, 13);
            this.lblEspec.TabIndex = 36;
            this.lblEspec.Text = "...";
            // 
            // DateAgend
            // 
            this.DateAgend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateAgend.Location = new System.Drawing.Point(109, 151);
            this.DateAgend.Name = "DateAgend";
            this.DateAgend.Size = new System.Drawing.Size(100, 20);
            this.DateAgend.TabIndex = 37;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(17, 239);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(149, 47);
            this.btnIncluir.TabIndex = 38;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesqInd
            // 
            this.btnPesqInd.Location = new System.Drawing.Point(17, 292);
            this.btnPesqInd.Name = "btnPesqInd";
            this.btnPesqInd.Size = new System.Drawing.Size(149, 47);
            this.btnPesqInd.TabIndex = 39;
            this.btnPesqInd.Text = "Pesquisa Individual";
            this.btnPesqInd.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(172, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 47);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesqGeral
            // 
            this.btnPesqGeral.Location = new System.Drawing.Point(172, 292);
            this.btnPesqGeral.Name = "btnPesqGeral";
            this.btnPesqGeral.Size = new System.Drawing.Size(149, 47);
            this.btnPesqGeral.TabIndex = 41;
            this.btnPesqGeral.Text = "Pesquisa Geral";
            this.btnPesqGeral.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 381);
            this.dataGridView1.TabIndex = 42;
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesqGeral);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesqInd);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.DateAgend);
            this.Controls.Add(this.lblEspec);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.HorarioAgend);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblHintNome);
            this.Controls.Add(this.lblHintEspec);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtCodAgend);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAgendamento";
            this.Text = "AGENDAMENTO MEDICO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCodAgend;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblHintEspec;
        private System.Windows.Forms.Label lblHintNome;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker HorarioAgend;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEspec;
        private System.Windows.Forms.DateTimePicker DateAgend;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesqInd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesqGeral;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}