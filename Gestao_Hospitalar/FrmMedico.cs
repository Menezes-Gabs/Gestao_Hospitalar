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
    public partial class FrmMedico : Form
    {
        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();
        public FrmMedico()
        {
            InitializeComponent();            
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            DataGridMedico.Visible = false;
            //adicionando itens no combo box
            cboEspecMed.Items.Add("Selecione uma Especialidade...");
            cboEspecMed.Items.Add("Pediatria");
            cboEspecMed.Items.Add("Cardiologia");
            cboEspecMed.Items.Add("Ortopedia");
            cboEspecMed.Items.Add("Oftalmologia");
        }
        private void LimparCampos()
        {
            txtCRMmed.Clear();            
            txtEmailMed.Clear();
            txtNomeMed.Clear();
            txtCelularMed.Clear();
            dtpNascMed.Value = DateTime.Now;
            cboEspecMed.SelectedValue = null;
        }
        //buscar no banco o CRM do medico
        private void txtCRMmed_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCRMmed.Text))
            {
                LimparCampos();
                return;
            }
            try
            {
                //query no sql
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM Medico ");
                CmdSql.Append("WHERE crmMedico = @crmMedico");

                //colocando os paramentros
                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@crmMedico", txtCRMmed);

                Conexao.StrSql = CmdSql.ToString();

                DataSet DS = Conexao.RetornarDataSet();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    DataRow row = DS.Tables[0].Rows[0];
                    txtCelularMed.Text = row["celularMedico"].ToString();
                    txtEmailMed.Text = row["emailMedico"].ToString();
                    txtNomeMed.Text = row["nomeMedico"].ToString();
                    cboEspecMed.Text = row["especialidade"].ToString();


                    if (row["nascMedico"] != DBNull.Value)
                    {
                        dtpNascMed.Value = Convert.ToDateTime(row["nascMedico"]);
                    }
                }

                else
                {                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
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

        //QUERY INSERT
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }              
    }
}
