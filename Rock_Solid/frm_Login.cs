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
	public partial class frm_Login : Form
	{
		frm_Initial principal;
		DataTable dt = new DataTable();
		public frm_Login(frm_Initial f)
		{
			InitializeComponent();
			principal = f;
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			string username = tb_UserName.Text;
			string password = tb_Password.Text;

			if(username == ""){
				MessageBox.Show("Digite um Usuário");
				tb_UserName.Focus();
				return;
			}
			else if(password == "")
			{
				MessageBox.Show("Digite a Senha");
				tb_Password.Focus();
				return;
			}

			string sql = "SELECT * FROM USER WHERE USER_USERNAME = '"+username+"'AND USER_PASSWORD = '"+password+"'";
			dt = DataBase.CheckIn(sql);
			if(dt.Rows.Count == 1)
			{
				principal.lb_AccessText.Text = dt.Rows[0].ItemArray[5].ToString();
				principal.lb_UserName.Text = dt.Rows[0].Field<string>("USER_USERNAME");
				principal.pb_Login.Image = Properties.Resources.Green_Button;
				Global.level = int.Parse(dt.Rows[0].Field<Int64>("USER_LEVEL").ToString());
				Global.logged = true;
				this.Close();
			}
			else
			{
				MessageBox.Show("Usuário ou Senha Inválido");
				tb_UserName.Focus();
			}
		}

		private void btn_Logout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
