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
    public partial class frm_User : Form
    {
        public frm_User()
        {
            InitializeComponent();
        }

        public static void ClearGlobalUser()
        {
            Global.userID = 0;
            Global.userName = "";
            Global.userUsername = "";
            Global.userPassword = "";
            Global.userStatus = "Ativo";
            Global.userLevel = 0;
        }

        public void ClearTB()
        {
            tb_ID.Text = "0";
            tb_Name.Clear();
            tb_Username.Clear();
            tb_Password.Clear();
            cb_Status.Text = "Ativo";
            tb_Level.Value = 0;
            ClearGlobalUser();
            tb_Name.Focus();
        }

        private void btn_New_Click(object sender, EventArgs e)
		{
            DialogResult res = MessageBox.Show("Criar Novo Usuário?", "NOVO", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
			{
                ClearTB();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.USER_NAME = tb_Name.Text;
            user.USER_USERNAME = tb_Username.Text;
            user.USER_PASSWORD = tb_Password.Text;
            user.USER_STATUS = cb_Status.Text;
            user.USER_LEVEL = Convert.ToInt32(Math.Round(tb_Level.Value, 0));

            DataBase.NewUser(user);
            ClearGlobalUser();
            tb_Name.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Global.userID != 0)
            {
                DialogResult res = MessageBox.Show("Confirma Exclusão do Usuário?", "EXCLUIR", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
				{
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = DataBase.DeleteUser(tb_ID.Text);
                        MessageBox.Show("Usuário Excluído com Sucesso");
                        tb_Name.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir Usuário");
                        tb_Name.Focus();
                        throw ex;
                    }
                }
                ClearTB();
            }
			else
			{
                MessageBox.Show("Nenhum Usuário Selecionado");
			}
            ClearGlobalUser();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
		{
            Close();
            ClearGlobalUser();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_UserList userList = new frm_UserList();
            userList.ShowDialog();
        }

        private void tb_ID_Click(object sender, EventArgs e)
        {
            ClearGlobalUser();
        }

        private void tb_ID_Enter(object sender, EventArgs e)
        {
            tb_ID.Text = Global.userID.ToString();
            tb_Name.Text = Global.userName.ToString();
            tb_Username.Text = Global.userUsername.ToString();
            tb_Password.Text = Global.userPassword.ToString();
            cb_Status.Text = Global.userStatus.ToString();
            tb_Level.Text = Global.userLevel.ToString();
        }

        private void tb_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = DataBase.GetUserList(tb_ID.Text);
                    tb_Name.Text = dt.Rows[0].Field<string>("USER_NAME").ToString();
                    tb_Username.Text = dt.Rows[0].Field<string>("USER_USERNAME").ToString();
                    tb_Password.Text = dt.Rows[0].Field<string>("USER_PASSWORD").ToString();
                    cb_Status.Text = dt.Rows[0].Field<string>("USER_STATUS").ToString();
                    tb_Level.Text = dt.Rows[0].Field<Int64>("USER_LEVEL").ToString();
                    Global.userID = Convert.ToInt32(tb_ID.Text);
                    Global.userName = tb_Name.Text;
                    Global.userUsername = tb_Username.Text;
                    Global.userPassword = tb_Password.Text;
                    Global.userStatus = cb_Status.Text;
                    Global.userLevel = Convert.ToInt32(tb_Level.Text);
                    tb_Name.Focus();
                }
                catch(Exception ex)
                {
                    if(Global.userID != 0)
                    {
                        MessageBox.Show("Usuário não Cadastrado");
                        ClearGlobalUser();
                        tb_Name.Focus();
                        throw ex;
                    }
                }
            }
        }
	}
}
