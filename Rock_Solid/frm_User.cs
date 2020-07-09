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
            Global.userStatus = "";
            Global.userLevel = 0;
        }

		private void btn_New_Click(object sender, EventArgs e)
		{
            {
                tb_Name.Clear();
                tb_Username.Clear();
                tb_Password.Clear();
                cb_Status.Text = "Ativo";
                tb_Level.Value = 0;
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

        private void tb_ID_Enter(object sender, EventArgs e)
        {
            tb_ID.Text = Global.userID.ToString();
            tb_Name.Text = Global.userName.ToString();
            tb_Username.Text = Global.userUsername.ToString();
            tb_Password.Text = Global.userPassword.ToString();
            cb_Status.Text = Global.userStatus.ToString();
            tb_Level.Text = Global.userLevel.ToString();
        }
    }
}
