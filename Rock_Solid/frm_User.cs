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

        public void ClearTB()
        {
            tb_ID.Text = "0";
            tb_Name.Clear();
            tb_Username.Clear();
            tb_Password.Clear();
            cb_Status.Text = "Ativo";
            tb_Level.Value = 0;
            tb_Name.Focus();
        }

        private void btn_New_Click(object sender, EventArgs e)
		{
            DialogResult res = MessageBox.Show("Criar Novo Usuário?", "NOVO", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
			{
                ClearTB();
                User.Clear();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            User user = new User();
            User.USER_NAME = tb_Name.Text;
            User.USER_USERNAME = tb_Username.Text;
            User.USER_PASSWORD = tb_Password.Text;
            User.USER_STATUS = cb_Status.Text;
            User.USER_LEVEL = Convert.ToInt32(Math.Round(tb_Level.Value, 0));

            DataBase.NewUser(user);
            User.Clear();
            tb_Name.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (User.USER_ID != 0)
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
            }
			else
			{
                MessageBox.Show("Nenhum Usuário Selecionado");
			}
            User.Clear();
            ClearTB();
        }

        private void btn_Close_Click(object sender, EventArgs e)
		{
            Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_UserList userList = new frm_UserList();
            userList.ShowDialog();
            tb_ID.Focus();
        }

        private void tb_ID_Click(object sender, EventArgs e)
        {
            User.Clear();
        }

        private void tb_ID_Enter(object sender, EventArgs e)
        {
            tb_ID.Text = User.USER_ID.ToString();
            tb_Name.Text = User.USER_NAME.ToString();
            tb_Username.Text = User.USER_USERNAME.ToString();
            tb_Password.Text = User.USER_PASSWORD.ToString();
            cb_Status.Text = User.USER_STATUS.ToString();
            tb_Level.Text = User.USER_LEVEL.ToString();
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
                    User.USER_ID = Convert.ToInt32(tb_ID.Text);
                    User.USER_NAME = tb_Name.Text;
                    User.USER_USERNAME = tb_Username.Text;
                    User.USER_PASSWORD = tb_Password.Text;
                    User.USER_STATUS = cb_Status.Text;
                    User.USER_LEVEL = Convert.ToInt32(tb_Level.Text);
                    tb_Name.Focus();
                }
                catch(Exception ex)
                {
                    if(User.USER_ID != 0)
                    {
                        MessageBox.Show("Usuário não Cadastrado");
                        User.Clear();
                        tb_Name.Focus();
                    }
                }
            }
        }

		private void frm_User_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) //Pode ser usado tambem (e.KeyCode == Keys.Enter)
			{
				this.ProcessTabKey(true);
				e.Handled = true; //Retira o som do windos na tecla
			}
		}

        private void frm_User_Load(object sender, EventArgs e)
        {
			ClearTB();
            User.Clear();
        }

        private void frm_User_FormClosed(object sender, FormClosedEventArgs e)
		{
            ClearTB();
            User.Clear();
		}
	}
}
