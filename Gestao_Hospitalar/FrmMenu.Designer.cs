namespace Gestao_Hospitalar
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.AgendamentoTSM.Size = new System.Drawing.Size(180, 24);
            this.AgendamentoTSM.Text = "Agendamento";
            this.AgendamentoTSM.Click += new System.EventHandler(this.AgendamentoTSM_Click);
            // 
            // MedicoTSM
            // 
            this.MedicoTSM.Name = "MedicoTSM";
            this.MedicoTSM.Size = new System.Drawing.Size(180, 24);
            this.MedicoTSM.Text = "Médico";
            this.MedicoTSM.Click += new System.EventHandler(this.MedicoTSM_Click);
            // 
            // PacienteTSM
            // 
            this.PacienteTSM.Name = "PacienteTSM";
            this.PacienteTSM.Size = new System.Drawing.Size(180, 24);
            this.PacienteTSM.Text = "Paciente";
            this.PacienteTSM.Click += new System.EventHandler(this.PacienteTSM_Click);
            // 
            // atendimentoTSM
            // 
            this.atendimentoTSM.Name = "atendimentoTSM";
            this.atendimentoTSM.Size = new System.Drawing.Size(180, 24);
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
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(174, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "BEM VINDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 264);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

