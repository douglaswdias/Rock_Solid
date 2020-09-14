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
	public partial class frm_ProductList : Form
	{
		public frm_ProductList()
		{
			InitializeComponent();
		}

		private void dgv_ProductList_SelectionChanged(object sender, EventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			int countRows = dgv.SelectedRows.Count;
			if (countRows > 0)
			{
				DataTable dt = new DataTable();
				string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
				dt = DataBase.ProductList(vId);
				Product.PRODUCT_ID = Convert.ToInt32(dt.Rows[0].Field<Int64>("PRODUCT_ID"));
				Product.PRODUCT_NAME = dt.Rows[0].Field<string>("PRODUCT_NAME").ToString();
				Product.PRODUCT_DESCRIPTION = dt.Rows[0].Field<string>("PRODUCT_DESCRIPTION").ToString();
				Product.PRODUCT_BARCODE = Convert.ToInt32(dt.Rows[0].Field<Int64>("PRODUCT_BARCODE"));
				Product.PRODUCT_TYPE = dt.Rows[0].Field<string>("PRODUCT_TYPE").ToString();
				Product.PRODUCT_SIZE = dt.Rows[0].Field<string>("PRODUCT_SIZE").ToString();
				Product.PRODUCT_COLOR = dt.Rows[0].Field<string>("PRODUCT_COLOR").ToString();
				Product.PRODUCT_WEIGHT = Convert.ToDouble(dt.Rows[0].Field<double>("PRODUCT_WEIGHT"));
				Product.PRODUCT_STOCK = dt.Rows[0].Field<string>("PRODUCT_STOCK").ToString();
				Product.PRODUCT_PURCHASEPRICE = Convert.ToDouble(dt.Rows[0].Field<double>("PRODUCT_PURCHASEPRICE"));
				Product.PRODUCT_MARKUPPRICE = Convert.ToDouble(dt.Rows[0].Field<double>("PRODUCT_MARKUPPRICE"));
				Product.PRODUCT_SELLINGPRICE = Convert.ToDouble(dt.Rows[0].Field<double>("PRODUCT_SELLINGPRICE"));
				Product.PRODUCT_LASTPURCHASE = Convert.ToDateTime(dt.Rows[0].Field<DateTime>("PRODUCT_LASTPURCHASE"));
				Product.PRODUCT_PROVIDERID = Convert.ToInt32(dt.Rows[0].Field<Int64>("PRODUCT_PROVIDERID"));
				Product.PRODUCT_IMAGE = dt.Rows[0].Field<string>("PRODUCT_IMAGE").ToString();
				Product.PRODUCT_CREATEDAT = Convert.ToDateTime(dt.Rows[0].Field<DateTime>("PRODUCT_CREATEDAT"));
				Product.PRODUCT_UPDATEDAT = Convert.ToDateTime(dt.Rows[0].Field<DateTime>("PRODUCT_UPDATEDAT"));
				this.dgv_ProductList.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
				this.dgv_ProductList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			}
		}

		private void frm_ProductList_Load(object sender, EventArgs e)
		{
			tb_Search.Focus();
			dgv_ProductList.DataSource = DataBase.ProductListDGV();
			dgv_ProductList.Columns[0].Width = 55;
			dgv_ProductList.Columns[1].Width = 225;
			dgv_ProductList.Columns[2].Width = 214;
			dgv_ProductList.Columns[3].Width = 214;
			Debug.WriteLine(dgv_ProductList.Columns[0].Width);
			Debug.WriteLine(dgv_ProductList.Columns[1].Width);
			Debug.WriteLine(dgv_ProductList.Columns[2].Width);
			Debug.WriteLine(dgv_ProductList.Columns[3].Width);
		}

		private void btn_Select_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgv_ProductList_DoubleClick(object sender, EventArgs e)
		{
			Close();
		}

		private void tb_Search_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (rb_Description.Checked)
				{
					dgv_ProductList.DataSource = DataBase.SearchProductDescription(tb_Search.Text);
				}
				else if (rb_BarCode.Checked)
				{
					dgv_ProductList.DataSource = DataBase.SearchProductBarCode(tb_Search.Text);
				}
			}
		}
	}
}
