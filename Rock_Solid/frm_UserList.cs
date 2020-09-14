using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            dgv_UserList.Columns[0].Width = 55;
            dgv_UserList.Columns[1].Width = 225;
            dgv_UserList.Columns[2].Width = 214;
            Debug.WriteLine(dgv_UserList.Columns[0].Width);
            Debug.WriteLine(dgv_UserList.Columns[1].Width);
            Debug.WriteLine(dgv_UserList.Columns[2].Width);
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
                User.USER_ID = Convert.ToInt32(dt.Rows[0].Field<Int64>("USER_ID"));
                User.USER_NAME = dt.Rows[0].Field<string>("USER_NAME").ToString();
                User.USER_USERNAME = dt.Rows[0].Field<string>("USER_USERNAME").ToString();
                User.USER_PASSWORD = dt.Rows[0].Field<string>("USER_PASSWORD").ToString();
                User.USER_STATUS = dt.Rows[0].Field<string>("USER_STATUS").ToString();
                User.USER_LEVEL = Convert.ToInt32(dt.Rows[0].Field<Int64>("USER_LEVEL"));
                this.dgv_UserList.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                this.dgv_UserList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_UserList_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

		private void tb_Search_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
			{
                dgv_UserList.DataSource = DataBase.SearchUserList(tb_Search.Text);
            }
        }
	}
}