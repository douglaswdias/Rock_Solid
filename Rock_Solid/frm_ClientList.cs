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
	public partial class frm_ClientList : Form
	{
		public frm_ClientList()
		{
			InitializeComponent();
		}

		private void dgv_ClientList_SelectionChanged(object sender, EventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
            int countRows = dgv.SelectedRows.Count;
            if(countRows > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = DataBase.ClientList(vId);
                Client.CLIENT_ID = Convert.ToInt32(dt.Rows[0].Field<Int64>("CLIENT_ID"));
				Client.CLIENT_NAME = dt.Rows[0].Field<string>("CLIENT_NAME").ToString();
				Client.CLIENT_POSTCODE = dt.Rows[0].Field<string>("CLIENT_POSTCODE").ToString();
				Client.CLIENT_ADDRESS = dt.Rows[0].Field<string>("CLIENT_ADDRESS").ToString();
				Client.CLIENT_NUMBER = dt.Rows[0].Field<string>("CLIENT_NUMBER").ToString();
				Client.CLIENT_NEIGHBORHOOD = dt.Rows[0].Field<string>("CLIENT_NEIGHBORHOOD").ToString();
				Client.CLIENT_CITY = dt.Rows[0].Field<string>("CLIENT_CITY").ToString();
				Client.CLIENT_STATE = dt.Rows[0].Field<string>("CLIENT_STATE").ToString();
				Client.CLIENT_RG = dt.Rows[0].Field<string>("CLIENT_RG").ToString();
				Client.CLIENT_CPF = dt.Rows[0].Field<string>("CLIENT_CPF").ToString();
				Client.CLIENT_EMAIL = dt.Rows[0].Field<string>("CLIENT_EMAIL").ToString();
				Client.CLIENT_PHONE = dt.Rows[0].Field<string>("CLIENT_PHONE").ToString();
				Client.CLIENT_CEL = dt.Rows[0].Field<string>("CLIENT_CEL").ToString();
				Client.CLIENT_PROFILEIMGPATH = dt.Rows[0].Field<string>("CLIENT_PROFILEIMGPATH").ToString();
				this.dgv_ClientList.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                this.dgv_ClientList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			}
		}

		private void frm_ClientList_Load(object sender, EventArgs e)
		{
			dgv_ClientList.DataSource = DataBase.ClientListDGV();
			dgv_ClientList.Columns[0].Width = 55;
			dgv_ClientList.Columns[1].Width = 225;
			dgv_ClientList.Columns[2].Width = 214;
			dgv_ClientList.Columns[3].Width = 214;
			dgv_ClientList.Columns[4].Width = 214;
			dgv_ClientList.Columns[5].Width = 214;
			Debug.WriteLine(dgv_ClientList.Columns[0].Width);
			Debug.WriteLine(dgv_ClientList.Columns[1].Width);
			Debug.WriteLine(dgv_ClientList.Columns[2].Width);
			Debug.WriteLine(dgv_ClientList.Columns[3].Width);
			Debug.WriteLine(dgv_ClientList.Columns[4].Width);
			Debug.WriteLine(dgv_ClientList.Columns[5].Width);
		}

		private void btn_Select_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgv_ClientList_DoubleClick(object sender, EventArgs e)
		{
			Close();
		}

		private void tb_Search_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (rb_Name.Checked)
				{
					dgv_ClientList.DataSource = DataBase.SearchClientName(tb_Search.Text);
				}
				else if (rb_CPF.Checked)
				{
					dgv_ClientList.DataSource = DataBase.SearchClientCPF(tb_Search.Text);
				}
			}
		}
	}
}
