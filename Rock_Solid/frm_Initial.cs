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
	public partial class frm_Initial : Form
	{
		public frm_Initial()
		{
			InitializeComponent();
			frm_Login login = new frm_Login(this);
            lb_Version.Text = Global.Version;
            login.ShowDialog();
		}

        private void tsmi_UserChange_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login(this);
            login.ShowDialog();
        }

        private void tsmi_LogOff_Click(object sender, EventArgs e)
        {
            lb_AccessText.Text = "0";
            lb_UserName.Text = "Nenhum Usuário Logado";
            pb_Login.Image = Properties.Resources.Red_Button;
            Global.level = 0;
            Global.logged = false;
            this.Close();
        }

		private void tsmi_User_Click(object sender, EventArgs e)
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

        private void tsmi_UserQuery_Click(object sender, EventArgs e)
        {
            frm_User user = new frm_User();
            user.ShowDialog();
        }

        private void tsmi_Client_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 3)
                {
                    frm_Client client = new frm_Client();
                    client.ShowDialog();
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

        private void tsmi_ClientQuery_Click(object sender, EventArgs e)
        {
            frm_ClientList client = new frm_ClientList();
            client.ShowDialog();
        }

        private void tsmi_Product_Click(object sender, EventArgs e)
        {
            frm_Product product = new frm_Product();
            product.ShowDialog();
        }

        private void tsmi_ProductQuery_Click(object sender, EventArgs e)
        {
            frm_Product product = new frm_Product();
            product.ShowDialog();
        }

        private void tsmi_SalesOrder_Click(object sender, EventArgs e)
		{
            frm_SalesOrder sales = new frm_SalesOrder();
            sales.ShowDialog();
        }
    }
}
