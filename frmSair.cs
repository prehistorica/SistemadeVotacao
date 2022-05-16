using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Votação
{
    public partial class frmSair : Form
    {
        public frmSair()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show(); 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSair.Text == "cdmachado")
                {

                    MessageBox.Show("Até Breve", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    Application.Exit(); 
                }

                else if (txtSair.Text == "")
                {
                    MessageBox.Show("O campo Senha não pode ficar vazio\n Tente Novamente", "Atenção!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtSair.Focus(); 
                }

                else
                {
                    MessageBox.Show("Senha Incorreta", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtSair.Text = ""; 
                    txtSair.Focus(); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
