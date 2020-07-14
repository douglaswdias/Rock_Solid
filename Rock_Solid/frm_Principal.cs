using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Solid
{
	public partial class frm_Principal : Form
	{
		public frm_Principal()
		{
			InitializeComponent();
			frm_Login login = new frm_Login(this);
			login.ShowDialog();
		}

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login(this);
            login.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_AccessText.Text = "0";
            lb_UserName.Text = "Nenhum Usuário Logado";
            pb_Login.Image = Properties.Resources.Red_Button;
            Global.level = 0;
            Global.logged = false;
            this.Close();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if(Global.level >= 3)
                {

                }
                else
                {
                    MessageBox.Show("Acesso Negado \nUsuário Sem Permissão");
                }
            }
            else
            {
                MessageBox.Show("Nenhum Usuário Logado");
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 3)
                {
                    frm_User user = new frm_User();
                    user.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso Negado \nUsuário Sem Permissão");
                }
            }
            else
            {
                MessageBox.Show("Nenhum Usuário Logado");
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 3)
                {

                }
                else
                {
                    MessageBox.Show("Acesso Negado \nUsuário Sem Permissão");
                }
            }
            else
            {
                MessageBox.Show("Nenhum Usuário Logado");
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 3)
                {

                }
                else
                {
                    MessageBox.Show("Acesso Negado \nUsuário Sem Permissão");
                }
            }
            else
            {
                MessageBox.Show("Nenhum Usuário Logado");
            }
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
