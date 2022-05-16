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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmSair sair = new frmSair(); 
            sair.ShowDialog(); 

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text == "cdmachado" && txtSenha.Text == "1234")
                {
                    MessageBox.Show("Bem Vindo ao Sistema", "Bem-Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    frmVotacao votar = new frmVotacao();
                    votar.ShowDialog();
                    
                }

                else if (txtLogin.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Os Campos Login e ou Senha Estão Vazios\n Repita o Processo!", "Atenção!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtLogin.Focus(); 
                }

                else
                {
                    MessageBox.Show("Os campos Login e ou Senha Estão Incorretos \n Repita o Processo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                    txtLogin.Text = "";
                    txtSenha.Text = ""; 
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
