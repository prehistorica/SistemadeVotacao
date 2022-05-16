using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace Sistema_de_Votação
{
    public partial class frmVotacao : Form
    {
        public frmVotacao()
        {
            InitializeComponent();
        }

        private void urna666BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pafuncioRadioButton.Checked == true)
                {
                    MessageBox.Show("Você Votou no Candidato Pafuncio", "Muito Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Votação Encerrada", "Feito!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    frmLogin login = new frmLogin();
                    login.ShowDialog();

                    this.Validate();
                    this.urna666BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.urna612DataSet);
                }

                else if (fudêncioRadioButton.Checked == true)
                {
                    MessageBox.Show("Você Votou no Candidato Fudêncio", "Muito Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Votação Encerrada", "Feito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.ShowDialog();

                    this.Validate();
                    this.urna666BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.urna612DataSet);
                }

                else if (nuloRadioButton.Checked == true)
                {
                    MessageBox.Show("Você Votou Nulo", "Muito Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Votação Encerrada", "Feito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.ShowDialog();

                    this.Validate();
                    this.urna666BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.urna612DataSet);
                }

                else if (brancoRadioButton.Checked == true)
                {
                    MessageBox.Show("Você Votou em Branco", "Muito Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Votação Encerrada", "Feito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.ShowDialog();

                    this.Validate();
                    this.urna666BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.urna612DataSet);
                }

                else
                {
                    MessageBox.Show("Escolha um Candidato", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    pafuncioRadioButton.Checked = false;
                    fudêncioRadioButton.Checked = false;
                    nuloRadioButton.Checked = false;
                    brancoRadioButton.Checked = false; 
                    this.Validate();
                    this.urna666BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.urna612DataSet);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void frmVotacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'urna612DataSet.Urna666'. Você pode movê-la ou removê-la conforme necessário.
            this.urna666TableAdapter.Fill(this.urna612DataSet.Urna666);

        }

        private void Habilitar(object sender, EventArgs e)
        {
            gbVoto.Visible = true;
            urna666BindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            lblIniciarVotacao.Visible = false;
            lblEscolha.Visible = true;
            lblConcluir.Visible = true; 
        }
    }
}
