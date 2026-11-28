using Projetofinal_DellaTorrexxx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//GABRIEL MENEZES SOUSA
//CODIGO INICIADO 24/11

//ULTIMA ATUALIZAÇÃO 26/11 18:00
namespace Gestao_Hospitalar
{
    public partial class FrmMedico : Form
    {
        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();
        private int? idMedicoSelecionado;
        public FrmMedico()
        {
            InitializeComponent();            
        }       

        //EVENTOS DE CLICK MENU
        //EVENTO FRM AGENDAMENTO  
        private void AgendamentoTSM_Click(object sender, EventArgs e)
        {
            FrmAgendamento agendamento = new FrmAgendamento();
            agendamento.Show();
            Hide();
        }

        //EVENTO FRM MEDICO
        private void MedicoTSM_Click(object sender, EventArgs e)
        {
            FrmMedico Medico = new FrmMedico();
            Medico.Show();
            Hide();
        }

        //EVENTO FRM PACIENTE
        private void PacienteTSM_Click(object sender, EventArgs e)
        {
            FrmPaciente Paciente = new FrmPaciente();
            Paciente.Show();
            Hide();
        }

        //evento frm atendimento
        private void atendimentoTSM_Click(object sender, EventArgs e)
        {
            frmAtendimento atendimento = new frmAtendimento();
            atendimento.Show();
            Hide();
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            DataGridMedico.Visible = false;
            btnAtualizar.Enabled = false;
            //adicionando itens no combo box
            cboEspecMed.Items.Add("Selecione uma Especialidade...");
            cboEspecMed.Items.Add("Pediatria");
            cboEspecMed.Items.Add("Cardiologia");
            cboEspecMed.Items.Add("Ortopedia");
            cboEspecMed.Items.Add("Oftalmologia");

            dtpNascMed.MinDate = new DateTime(1920, 1, 1);
            dtpNascMed.MaxDate = DateTime.Today;
        }
        private void VoltaTamanho()
        {
            //FUNÇÃO 1 -- Ajuste de tamanho da tela
            //tamamnho inicial do sistema -- Aumenta só no clique do grid
            Height = 489;
            Width = 450;

            //DataGridMedico = 
        }
        private void LimparCampos()
        {
            //função 2 --limpeza de campos
            idMedicoSelecionado = null;
            btnAtualizar.Enabled = false;
            txtCRMmed.Clear();
            txtEmailMed.Clear();
            txtNomeMed.Clear();
            txtCelularMed.Clear();
            dtpNascMed.Value = DateTime.Today;
            cboEspecMed.SelectedIndex = 0;
            txtCRMmed.Focus();
        }

        private bool ValidarCampos()
        {
            //funçao 3 -- validações de campos vazios
            if (string.IsNullOrWhiteSpace(txtCRMmed.Text) ||
                string.IsNullOrWhiteSpace(txtNomeMed.Text) ||
                cboEspecMed.SelectedIndex <= 0 ||
                string.IsNullOrWhiteSpace(txtCelularMed.Text) ||
                string.IsNullOrWhiteSpace(txtEmailMed.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios (CRM, Nome, Especialidade, Celular e E-mail).");
                return false;
            }
            if (txtCRMmed.Text.Trim().Length > 6 || txtNomeMed.Text.Trim().Length > 50 ||
                txtCelularMed.Text.Trim().Length != 11 || !txtCelularMed.Text.Trim().All(char.IsDigit) ||
                txtEmailMed.Text.Trim().Length > 150)
            {
                MessageBox.Show("Confira o CRM, nome, celular (11 dígitos) e e-mail.");
                return false;
            }
            return true;
        }

        private void txtCRMmed_TextChanged(object sender, EventArgs e)
        {
            idMedicoSelecionado = null;
            btnAtualizar.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!idMedicoSelecionado.HasValue || !ValidarCampos()) return;
            try
            {
                PreencherParametros();
                Conexao.Cmd.Parameters.AddWithValue("@id", idMedicoSelecionado.Value);
                Conexao.StrSql = "UPDATE Medico SET nomeMedico=@nomeMedico, especialidade=@especialidade, celularMedico=@celularMedico, emailMedico=@emailMedico, nascMedico=@nascMedico WHERE idMedico=@id AND crmMedico=@crmMedico";
                int linhas = Conexao.ExecutarCmd();
                MessageBox.Show(linhas > 0 ? "Médico atualizado com sucesso!" : "Nenhuma alteração registrada.");
                ChamarGrid();
                Height = 489;
                Width = 918;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void PreencherParametros()
        {
            // função 4 -- Parametros
            Conexao.Cmd.Parameters.Clear(); //limpeza de parametros anteriores
            Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRMmed.Text.Trim()); // trim: apaga os espaços do codigo
            Conexao.Cmd.Parameters.AddWithValue("@nomeMedico", txtNomeMed.Text.Trim()); // no caso de nome, ele nao mexe com espaços no meio
            Conexao.Cmd.Parameters.AddWithValue("@especialidade", cboEspecMed.Text);
            Conexao.Cmd.Parameters.AddWithValue("@celularMedico", txtCelularMed.Text.Trim());
            Conexao.Cmd.Parameters.AddWithValue("@emailMedico", txtEmailMed.Text.Trim());
            Conexao.Cmd.Parameters.AddWithValue("@nascMedico", dtpNascMed.Value.ToString("yyyy-MM-dd")); //padronizando as datas com mySql
        }
        
        //EVENTOS DE CLICK - BOTOES
        //QUERY INSERT
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //validação
            if (!ValidarCampos()) return;

            try
            {
                CmdSql.Clear();
                CmdSql.Append("INSERT INTO Medico (crmMedico, nomeMedico, especialidade, celularMedico, emailMedico, nascMedico) ");
                CmdSql.Append("VALUES (@crmMedico, @nomeMedico, @especialidade, @celularMedico, @emailMedico, @nascMedico)");

                PreencherParametros();
                Conexao.StrSql = CmdSql.ToString();                
                Conexao.ExecutarCmd();

                MessageBox.Show("Médico cadastrado com sucesso!");

                LimparCampos();
                VoltaTamanho();
            }
            catch (Exception ex)
            {
                //CHECA A MENSAGEM DE ERRO PARA INDICAR PRO USUARIO
                if (ex.Message.Contains("Duplicate entry"))
                    MessageBox.Show("Já existe um medico cadastrado com este CRM!");
                else
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
            }            
        }

        //QUERY DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //validação
            if (string.IsNullOrWhiteSpace(txtCRMmed.Text))
            {
                MessageBox.Show("Informe o CRM do médico que deseja excluir.");
                return;
            }
            // danger zone -- confirmação do usuario
            if (MessageBox.Show("Deseja realmente excluir este médico?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                CmdSql.Clear();
                CmdSql.Append("DELETE FROM Medico WHERE crmMedico = @crmMedico");

                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRMmed.Text.Trim());

                Conexao.StrSql = CmdSql.ToString();
                int LinhasAfetadas = Conexao.ExecutarCmd();

                if (LinhasAfetadas > 0)
                {
                    MessageBox.Show("Médico excluído com sucesso!");
                    LimparCampos();                    
                }
                else
                {
                    MessageBox.Show("Nenhum médico encontrado com esse CRM.");
                }

                VoltaTamanho();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("foreign key constraint"))
                    MessageBox.Show("Não é possível excluir: este médico já possui agendamentos ou atendimentos registrados.");

                else
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
            }        
        }
        //evento para carregar os medicos no grid
        private void ChamarGrid()
        {
            try
            {
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM Medico ");
                CmdSql.Append("ORDER BY nomeMedico");

                Conexao.Cmd.Parameters.Clear();
                Conexao.StrSql = CmdSql.ToString();

                DataSet DS = Conexao.RetornarDataSet();

                DataGridMedico.Visible = true;
                DataGridMedico.DataSource = DS.Tables[0];
                DataGridMedico.Columns["idMedico"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar médicos: " + ex.Message);
            }
        }

        //botao select individual
        private void btnPesqInd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCRMmed.Text))
            {
                MessageBox.Show("Digite o CRM para pesquisar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCRMmed.Focus();
                return;
            }

            idMedicoSelecionado = null;
            btnAtualizar.Enabled = false;
            try
            {
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM Medico ");
                CmdSql.Append("WHERE crmMedico = @crmMedico");

                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRMmed.Text.Trim());

                Conexao.StrSql = CmdSql.ToString();

                DataSet DS = Conexao.RetornarDataSet();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    DataRow row = DS.Tables[0].Rows[0];
                    txtNomeMed.Text = row["nomeMedico"].ToString();
                    cboEspecMed.Text = row["especialidade"].ToString();
                    txtCelularMed.Text = row["celularMedico"].ToString();
                    txtEmailMed.Text = row["emailMedico"].ToString();

                    if (row["nascMedico"] != DBNull.Value)
                    {
                        dtpNascMed.Value = Convert.ToDateTime(row["nascMedico"]);
                    }

                    idMedicoSelecionado = Convert.ToInt32(row["idMedico"]);
                    btnAtualizar.Enabled = true;
                    DataGridMedico.Visible = true;
                    DataGridMedico.DataSource = DS.Tables[0];
                    DataGridMedico.Columns["idMedico"].Visible = false;
                    Height = 489;
                    Width = 918;
                }
                else
                {
                    MessageBox.Show("Médico não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                    ChamarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        //botao pesquisa geral
        private void btnPesqGeral_Click(object sender, EventArgs e)
        {
            ChamarGrid();

            Height = 489;
            Width = 918;
        }
    }
}
