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

namespace Gestao_Hospitalar
{
    public partial class FrmAgendamento : Form
    {

        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();

        public FrmAgendamento()
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

        private void LimparCamposAg()
        {
            txtCodAgend.Clear();
            txtCPF.Clear();
            txtCRM.Clear();
            lblEspec.Text = "...";
            lblNome.Text = "...";
        }

        private bool ValidarCamposAg()
        {
            if (String.IsNullOrEmpty(txtCRM.Text) ||
                String.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Selecione um médico e um paciente.");
                return false;
            }

            DateTime DataHora = DateAgend.Value.Date
            .AddHours(HorarioAgend.Value.Hour)
            .AddMinutes(HorarioAgend.Value.Minute);

            if (DataHora <= DateTime.Now)
            {
                MessageBox.Show("Selecione uma data correta.");
                return false;
            }

            return true;
        }

        private void PreencherParametrosAg(int codigo)
        {
            DateTime DataHora = DateAgend.Value.Date
            .AddHours(HorarioAgend.Value.Hour)
            .AddMinutes(HorarioAgend.Value.Minute);

            Conexao.Cmd.Parameters.Clear();
            Conexao.Cmd.Parameters.Add("@codAgend", MySqlDbType.Int32).Value = codigo;
            Conexao.Cmd.Parameters.Add("@dataAgend", MySqlDbType.DateTime).Value = DataHora;
            Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRM.Text.Trim());
            Conexao.Cmd.Parameters.AddWithValue("@cpfPaciente", txtCPF.Text.Trim());
            Conexao.Cmd.Parameters.AddWithValue("@statusAgend", "Agendado");
        }

        private void txtCRM_Leave(object sender, EventArgs e)
        {

            lblEspec.Text = "...";
            lblNome.Text = "...";

            if (String.IsNullOrEmpty(txtCRM.Text))
            {
                return;
            }

            try
            {
                CmdSql.Clear();
                CmdSql.Append("SELECT nomeMedico, especialidade FROM Medico ");
                CmdSql.Append("WHERE crmMedico = @crmMedico");

                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRM.Text.Trim());

                Conexao.StrSql = CmdSql.ToString();

                DataSet DS = Conexao.RetornarDataSet();

                if (DS.Tables.Count == 0 || DS.Tables[0].Rows.Count == 0)
                {
                    lblNome.Text = "Médico não localizado";
                    return;
                }

                DataRow row = DS.Tables[0].Rows[0];
                lblNome.Text = row["nomeMedico"].ToString();
                lblEspec.Text = row["especialidade"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar médico: " + ex.Message);
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposAg())
                return;

            if (!int.TryParse(txtCodAgend.Text, out int codigo))
            {
                MessageBox.Show("Digite um código de agendamento válido.");
                return;
            }

            try
            {
                CmdSql.Clear();
                CmdSql.Append("INSERT INTO Agendamento ");
                CmdSql.Append("(codAgend, DataAgend, idMedico_Agend, idPaciente_Agend, StatusAgend) ");
                CmdSql.Append("SELECT @codAgend, @dataAgend, m.idMedico, p.idPaciente, @StatusAgend ");
                CmdSql.Append("FROM Medico AS m ");
                CmdSql.Append("INNER JOIN Paciente AS p ON p.cpfPaciente = @cpfPaciente ");
                CmdSql.Append("WHERE m.crmMedico = @crmMedico");

                PreencherParametrosAg(codigo);
                Conexao.StrSql = CmdSql.ToString();
                Conexao.ExecutarCmd();
                

                MessageBox.Show("Agendamento " + codigo + " incluido com sucesso.");
                LimparCamposAg();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer o agendamento: " + ex.Message);
            }
        }
    }
}
