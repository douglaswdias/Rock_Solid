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
    public partial class frm_UserList : Form
    {
        public frm_UserList()
        {
            InitializeComponent();
        }

        private void frm_UserList_Load(object sender, EventArgs e)
        {
            dgv_UserList.DataSource = DataBase.UserList();
            dgv_UserList.Columns[0].Width = 41;
            dgv_UserList.Columns[1].Width = 245;
            dgv_UserList.Columns[2].Width = 225;
        }

        private void dgv_UserList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countRows = dgv.SelectedRows.Count;
            if(countRows > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = DataBase.GetUserList(vId);
                Global.userID = Convert.ToInt32(dt.Rows[0].Field<Int64>("USER_ID"));
                Global.userName = dt.Rows[0].Field<string>("USER_NAME").ToString();
                Global.userUsername = dt.Rows[0].Field<string>("USER_USERNAME").ToString();
                Global.userPassword = dt.Rows[0].Field<string>("USER_PASSWORD").ToString();
                Global.userStatus = dt.Rows[0].Field<string>("USER_STATUS").ToString();
                Global.userLevel = Convert.ToInt32(dt.Rows[0].Field<Int64>("USER_LEVEL"));

            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
