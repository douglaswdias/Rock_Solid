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
	public partial class frm_SalesOrder : Form
	{
		public frm_SalesOrder()
		{
			InitializeComponent();
		}

		private void dgv_OrderItem_DoubleClick(object sender, EventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			int countRows = dgv.SelectedRows.Count;
			if (countRows > 0)
			{
				DataTable dt = new DataTable();
				string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
				dt = DataBase.OrderItem(vId);
				OrderItem.ORDERI_ID = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_ID"));
				OrderItem.ORDERI_DESCRIPTION = dt.Rows[0].Field<string>("ORDERI_DESCRIPTION").ToString();
				OrderItem.ORDERI_BARCODE = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_BARCODE"));
				OrderItem.ORDERI_PRICEUNITY = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_PRICEUNITY"));
				OrderItem.ORDERI_QUANTITY = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_QUANTITY"));
				OrderItem.ORDERI_DISCOUNT = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_DESCOUNT"));
				OrderItem.ORDERI_TOTALPRICE = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_TOTALPRICE"));
				OrderItem.ORDERI_INSERTEDAT = Convert.ToDateTime(dt.Rows[0].Field<DateTime>("ORDERI_TOTALPRICE"));
				OrderItem.ORDERI_PRODUCTID = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_TOTALPRICE"));
				OrderItem.ORDERI_ORDERID = Convert.ToInt32(dt.Rows[0].Field<Int64>("ORDERI_TOTALPRICE"));
				this.dgv_OrderItem.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
				this.dgv_OrderItem.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			}
		}

		private void tb_ProductID_Leave(object sender, EventArgs e)
		{
		//	tb_ProductID.Text = OrderItem.ORDERI_ID.ToString();
		//	tb_BarCode.Text = OrderItem.ORDERI_BARCODE.ToString();
		//	tb_Product.Text = OrderItem.ORDERI_DESCRIPTION.ToString();
		//	tb_Quantity.Text = OrderItem.ORDERI_QUANTITY.ToString();
		//	tb_Discount.Text = OrderItem.ORDERI_DISCOUNT.ToString();
		//	tb_ItemTotal.Text = OrderItem.ORDERI_TOTALPRICE.ToString();
		}

		private void frm_SalesOrder_Enter(object sender, EventArgs e)
		{

		}

		private void tb_Order_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
				int id = Convert.ToInt32(tb_Order.Text);
				DataBase.Order(id);
				try
                {
					Orderr.ORDER_ID = Convert.ToInt32(tb_Order.Text);
					tb_TotalOrder.Text = Orderr.ORDER_TOTAL.ToString();
					tb_ID.Text = Client.CLIENT_ID.ToString();
					tb_Client.Text = Client.CLIENT_NAME.ToString();
				}
				catch (Exception ex)
                {
					MessageBox.Show("Número do Pedido Não Encontrado");
				}
            }
		}
	}
}
