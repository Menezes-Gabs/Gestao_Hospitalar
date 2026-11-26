using Projetofinal_DellaTorrexxx;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestao_Hospitalar
{
    public partial class FrmMedico : Form
    {
        private const string SelecionarMedicos =
            "SELECT idMedico, crmMedico, nomeMedico, especialidade, celularMedico, emailMedico, nascMedico FROM Medico";

        private readonly ClsConexao conexao = new ClsConexao();
        private int? idMedicoSelecionado;

        public FrmMedico()
        {
            InitializeComponent();
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            DataGridMedico.Visible = false;
            cboEspecMed.Items.AddRange(new object[] { "Pediatria", "Cardiologia", "Ortopedia", "Oftalmologia" });
        }

        private void LimparDadosMedico()
        {
            idMedicoSelecionado = null;
            btnAtualizar.Enabled = false;
            txtNomeMed.Clear();
            cboEspecMed.SelectedIndex = -1;
            cboEspecMed.Text = string.Empty;
            txtCelularMed.Clear();
            txtEmailMed.Clear();
            dtpNascMed.Value = DateTime.Today;
        }

        private void txtCRMmed_TextChanged(object sender, EventArgs e)
        {
            if (idMedicoSelecionado.HasValue)
                LimparDadosMedico();
        }

        private bool ValidarCrm()
        {
            int tamanho = txtCRMmed.Text.Trim().Length;
            if (tamanho >= 1 && tamanho <= 6)
                return true;

            MessageBox.Show("Informe um CRM de até 6 caracteres.");
            txtCRMmed.Focus();
            return false;
        }

        private bool ValidarDadosMedico()
        {
            if (string.IsNullOrWhiteSpace(txtNomeMed.Text) ||
                string.IsNullOrWhiteSpace(cboEspecMed.Text) ||
                string.IsNullOrWhiteSpace(txtCelularMed.Text) ||
                string.IsNullOrWhiteSpace(txtEmailMed.Text))
            {
                MessageBox.Show("Preencha nome, especialidade, celular e e-mail.");
                return false;
            }

            return true;
        }

        private void PrepararSql(string sql)
        {
            conexao.StrSql = sql;
            conexao.Cmd.Parameters.Clear();
        }

        private void AdicionarCrm()
        {
            conexao.Cmd.Parameters.AddWithValue("@crm", txtCRMmed.Text.Trim());
        }

        private void AdicionarDadosMedico()
        {
            conexao.Cmd.Parameters.AddWithValue("@nome", txtNomeMed.Text.Trim());
            conexao.Cmd.Parameters.AddWithValue("@especialidade", cboEspecMed.Text.Trim());
            conexao.Cmd.Parameters.AddWithValue("@celular", txtCelularMed.Text.Trim());
            conexao.Cmd.Parameters.AddWithValue("@email", txtEmailMed.Text.Trim());
            conexao.Cmd.Parameters.AddWithValue("@nascimento", dtpNascMed.Value.Date);
        }

        private void ExecutarOperacao(string operacao, Action acao)
        {
            try
            {
                acao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao " + operacao + ": " + ex.Message);
            }
        }

        private void btnPesqInd_Click(object sender, EventArgs e)
        {
            if (!ValidarCrm())
                return;

            ExecutarOperacao("pesquisar médico", () =>
            {
                PrepararSql(SelecionarMedicos + " WHERE crmMedico = @crm");
                AdicionarCrm();

                DataTable medicos = conexao.RetornarDataSet().Tables[0];
                if (medicos.Rows.Count == 0)
                {
                    LimparDadosMedico();
                    MessageBox.Show("Nenhum médico encontrado com esse CRM.");
                    return;
                }

                DataRow medico = medicos.Rows[0];
                txtNomeMed.Text = (string)medico["nomeMedico"];
                cboEspecMed.Text = (string)medico["especialidade"];
                txtCelularMed.Text = (string)medico["celularMedico"];
                txtEmailMed.Text = (string)medico["emailMedico"];
                dtpNascMed.Value = (DateTime)medico["nascMedico"];
                idMedicoSelecionado = (int)medico["idMedico"];
                btnAtualizar.Enabled = true;
            });
        }

        private void ListarMedicos()
        {
            ExecutarOperacao("listar médicos", () =>
            {
                PrepararSql(SelecionarMedicos + " ORDER BY nomeMedico, crmMedico");
                DataGridMedico.DataSource = conexao.RetornarDataSet().Tables[0];
                DataGridMedico.Columns["idMedico"].Visible = false;
                DataGridMedico.Visible = true;
            });
        }

        private void btnPesqGeral_Click(object sender, EventArgs e)
        {
            ListarMedicos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!ValidarCrm() || !ValidarDadosMedico())
                return;

            ExecutarOperacao("incluir médico", () =>
            {
                PrepararSql(
                    "INSERT INTO Medico (crmMedico, nomeMedico, especialidade, celularMedico, emailMedico, nascMedico) " +
                    "VALUES (@crm, @nome, @especialidade, @celular, @email, @nascimento)");
                AdicionarCrm();
                AdicionarDadosMedico();
                conexao.ExecutarCmd();

                LimparDadosMedico();
                txtCRMmed.Clear();
                MessageBox.Show("Médico incluído.");
                if (DataGridMedico.Visible)
                    ListarMedicos();
            });
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!idMedicoSelecionado.HasValue || !ValidarCrm() || !ValidarDadosMedico())
                return;

            ExecutarOperacao("atualizar médico", () =>
            {
                PrepararSql(
                    "UPDATE Medico SET nomeMedico = @nome, especialidade = @especialidade, " +
                    "celularMedico = @celular, emailMedico = @email, nascMedico = @nascimento " +
                    "WHERE idMedico = @id AND crmMedico = @crm");
                conexao.Cmd.Parameters.AddWithValue("@id", idMedicoSelecionado.Value);
                AdicionarCrm();
                AdicionarDadosMedico();

                if (conexao.ExecutarCmd() == 0)
                {
                    LimparDadosMedico();
                    MessageBox.Show("O cadastro pesquisado não está mais disponível.");
                }
                else
                {
                    MessageBox.Show("Médico atualizado.");
                }

                if (DataGridMedico.Visible)
                    ListarMedicos();
            });
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!ValidarCrm())
                return;

            string crm = txtCRMmed.Text.Trim();
            DialogResult resposta = MessageBox.Show(
                "Excluir o médico com CRM " + crm + "?", "Excluir médico",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta != DialogResult.Yes)
                return;

            ExecutarOperacao("excluir médico", () =>
            {
                PrepararSql("DELETE FROM Medico WHERE crmMedico = @crm");
                conexao.Cmd.Parameters.AddWithValue("@crm", crm);
                if (conexao.ExecutarCmd() == 0)
                {
                    MessageBox.Show("Nenhum médico encontrado com esse CRM.");
                }
                else
                {
                    LimparDadosMedico();
                    txtCRMmed.Clear();
                    MessageBox.Show("Médico excluído.");
                }

                if (DataGridMedico.Visible)
                    ListarMedicos();
            });
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
    }
}
