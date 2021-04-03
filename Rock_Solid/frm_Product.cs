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
	public partial class frm_Product : Form
	{
		public frm_Product()
		{
			InitializeComponent();
		}



        public void ClearTB()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Description.Clear();
            tb_BarCode.Clear();
            tb_Type.Clear();
            tb_Size.Clear();
            tb_Color.Clear();
            tb_Weight.Clear();
            tb_Stock.Clear();
            tb_Purchase.Clear();
            tb_MarkUp.Clear();
            tb_Sell.Clear();
            tb_LastPurchase.Clear();
            tb_ProviderID.Clear();
            tb_CreatedAt.Clear();
            tb_UpdatedAt.Clear();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Criar Novo Usuário?", "NOVO", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                ClearTB();
                Product.Clear();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            Product.PRODUCT_NAME = tb_Name.Text;
            Product.PRODUCT_DESCRIPTION = tb_Description.Text;
            Product.PRODUCT_BARCODE = Convert.ToInt32(tb_BarCode.Text);
            Product.PRODUCT_TYPE = tb_Type.Text;
            Product.PRODUCT_SIZE = tb_Size.Text;
            Product.PRODUCT_COLOR = tb_Color.Text;
            Product.PRODUCT_WEIGHT = Convert.ToInt32(tb_Weight.Text);
            Product.PRODUCT_STOCK = tb_Stock.Text;
            Product.PRODUCT_PURCHASEPRICE = Convert.ToDouble(tb_Purchase.Text);
            Product.PRODUCT_MARKUPPRICE = Convert.ToDouble(tb_MarkUp.Text);
            Product.PRODUCT_SELLINGPRICE = Convert.ToDouble(tb_Sell.Text);
            Product.PRODUCT_LASTPURCHASE = DateTime.Today;
            Product.PRODUCT_PROVIDERID = Convert.ToInt32(tb_ProviderID.Text);
            Product.PRODUCT_CREATEDAT = DateTime.Today;
            Product.PRODUCT_UPDATEDAT = DateTime.Today;
            DataBase.NewProduct(product);
            tb_ID.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (User.USER_ID != 0)
            {
                DialogResult res = MessageBox.Show("Confirma Exclusão do Usuário?", "EXCLUIR", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = DataBase.DeleteUser(tb_ID.Text);
                        MessageBox.Show("Usuário Excluído com Sucesso");
                        tb_ID.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir Usuário");
                        tb_ID.Focus();
                        throw ex;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Usuário Selecionado");
            }
            Product.Clear();
            ClearTB();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Product.Clear();
            ClearTB();
            Close();
        }

		private void btn_Search_Click(object sender, EventArgs e)
		{
            frm_ProductList product = new frm_ProductList();
            product.ShowDialog();
            tb_ID.Focus();
        }

		private void frm_Product_Load(object sender, EventArgs e)
		{
            tb_ID.Focus();
        }

		private void frm_Product_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)Keys.Enter) //Pode ser usado tambem (e.KeyCode == Keys.Enter)
            {
                this.ProcessTabKey(true);
                e.Handled = true; //Retira o som do windos na tecla
            }
        }

        private void tb_ID_Enter(object sender, EventArgs e)
        {
            tb_ID.Text = Product.PRODUCT_ID.ToString();
            tb_Name.Text = Product.PRODUCT_NAME;
            tb_Description.Text = Product.PRODUCT_DESCRIPTION;
            tb_BarCode.Text = Product.PRODUCT_BARCODE.ToString();
            tb_Type.Text = Product.PRODUCT_TYPE;
            tb_Size.Text = Product.PRODUCT_SIZE;
            tb_Color.Text = Product.PRODUCT_COLOR;
            tb_Weight.Text = Product.PRODUCT_WEIGHT.ToString();
            tb_Stock.Text = Product.PRODUCT_STOCK;
            tb_Purchase.Text = Product.PRODUCT_PURCHASEPRICE.ToString();
            tb_MarkUp.Text = Product.PRODUCT_MARKUPPRICE.ToString();
            tb_Sell.Text = Product.PRODUCT_SELLINGPRICE.ToString();
            tb_LastPurchase.Text = Product.PRODUCT_LASTPURCHASE.ToShortDateString().ToString();
            tb_ProviderID.Text = Product.PRODUCT_PROVIDERID.ToString();
            tb_CreatedAt.Text = Product.PRODUCT_CREATEDAT.ToShortDateString().ToString();
            tb_UpdatedAt.Text = Product.PRODUCT_UPDATEDAT.ToShortDateString().ToString();
        }

        private void tb_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = DataBase.ProductList(tb_ID.Text);
                    tb_Name.Text = dt.Rows[0].Field<string>("PRODUCT_NAME").ToString();
                    tb_Description.Text = dt.Rows[0].Field<string>("PRODUCT_DESCRIPTION").ToString();
                    tb_BarCode.Text = dt.Rows[0].Field<Int64>("PRODUCT_BARCODE").ToString();
                    tb_Type.Text = dt.Rows[0].Field<string>("PRODUCT_TYPE").ToString();
                    tb_Size.Text = dt.Rows[0].Field<string>("PRODUCT_SIZE").ToString();
                    tb_Color.Text = dt.Rows[0].Field<string>("PRODUCT_COLOR").ToString();
                    tb_Weight.Text = dt.Rows[0].Field<double>("PRODUCT_WEIGHT").ToString();
                    tb_Stock.Text = dt.Rows[0].Field<string>("PRODUCT_STOCK").ToString();
                    tb_Purchase.Text = dt.Rows[0].Field<double>("PRODUCT_PURCHASEPRICE").ToString();
                    tb_MarkUp.Text = dt.Rows[0].Field<double>("PRODUCT_MARKUPPRICE").ToString();
                    tb_Sell.Text = dt.Rows[0].Field<double>("PRODUCT_SELLINGPRICE").ToString();
                    tb_LastPurchase.Text = dt.Rows[0].Field<DateTime>("PRODUCT_LASTPURCHASE").ToShortDateString().ToString();
                    tb_ProviderID.Text = dt.Rows[0].Field<Int64>("PRODUCT_PROVIDERID").ToString();
                    tb_CreatedAt.Text = dt.Rows[0].Field<DateTime>("PRODUCT_CREATEDAT").ToShortDateString().ToString();
                    tb_UpdatedAt.Text = dt.Rows[0].Field<DateTime>("PRODUCT_UPDATEDAT").ToShortDateString().ToString();
                    Product.PRODUCT_NAME = tb_Name.Text;
                    Product.PRODUCT_DESCRIPTION = tb_Description.Text;
                    Product.PRODUCT_BARCODE = Convert.ToInt32(tb_BarCode.Text);
                    Product.PRODUCT_TYPE = tb_Type.Text;
                    Product.PRODUCT_SIZE = tb_Size.Text;
                    Product.PRODUCT_COLOR = tb_Color.Text;
                    Product.PRODUCT_WEIGHT = Convert.ToDouble(tb_Weight.Text);
                    Product.PRODUCT_STOCK = tb_Stock.Text;
                    Product.PRODUCT_PURCHASEPRICE = Convert.ToDouble(tb_Purchase.Text);
                    Product.PRODUCT_MARKUPPRICE = Convert.ToDouble(tb_MarkUp.Text);
                    Product.PRODUCT_SELLINGPRICE = Convert.ToDouble(tb_Sell.Text);
                    Product.PRODUCT_LASTPURCHASE = Convert.ToDateTime(tb_LastPurchase.Text);
                    Product.PRODUCT_PROVIDERID = Convert.ToInt32(tb_ProviderID.Text);
                    Product.PRODUCT_CREATEDAT = Convert.ToDateTime(tb_CreatedAt.Text);
                    Product.PRODUCT_UPDATEDAT = Convert.ToDateTime(tb_UpdatedAt.Text);
                    tb_Name.Focus();
                }
                catch (Exception ex)
                {
                    if (Client.CLIENT_ID != 0)
                    {
                        MessageBox.Show("Produto não Cadastrado");
                        ClearTB();
                        //ClearClient();
                        tb_ID.Focus();
                        //throw ex;
                    }
                }
            }
        }

		private void btn_ProfilePicture_Click(object sender, EventArgs e)
		{

		}


		private void tb_MarkUp_Leave(object sender, EventArgs e)
		{
            double sell = (Convert.ToDouble(tb_Purchase.Text) * Convert.ToDouble(tb_MarkUp.Text)) / 100;
            tb_Sell.Text = (Convert.ToDouble(tb_Purchase.Text) + sell).ToString();
        }

		private void tb_Sell_Leave(object sender, EventArgs e)
		{
            double markUp = (Convert.ToDouble(tb_Sell.Text) - Convert.ToDouble(tb_Purchase.Text)) * 10;
            tb_MarkUp.Text = markUp.ToString();
        }
	}

}
