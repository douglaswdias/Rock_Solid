namespace Rock_Solid
{
	partial class frm_SalesOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Produto Teste",
            "7897897897897",
            "2",
            "0",
            "15,00",
            "30,00"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Vencimento/1",
            "25/10/2020",
            "210,50",
            "Dinheiro",
            ""}, -1);
			this.tc_SalesOrder = new System.Windows.Forms.TabControl();
			this.tp_Product = new System.Windows.Forms.TabPage();
			this.btn_SaveProduct = new System.Windows.Forms.Button();
			this.lb_Product = new System.Windows.Forms.Label();
			this.lv_Products = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lb_Price = new System.Windows.Forms.Label();
			this.tb_Price = new System.Windows.Forms.TextBox();
			this.lb_Discount = new System.Windows.Forms.Label();
			this.tb_Discount = new System.Windows.Forms.TextBox();
			this.lb_Amount = new System.Windows.Forms.Label();
			this.tb_Amount = new System.Windows.Forms.TextBox();
			this.tb_Product = new System.Windows.Forms.TextBox();
			this.lb_BarCode = new System.Windows.Forms.Label();
			this.tb_BarCode = new System.Windows.Forms.TextBox();
			this.tp_ExpirationDate = new System.Windows.Forms.TabPage();
			this.btn_Save = new System.Windows.Forms.Button();
			this.lv_Expirations = new System.Windows.Forms.ListView();
			this.cb_PaymentMethod = new System.Windows.Forms.ComboBox();
			this.dtp_ExpirationData = new System.Windows.Forms.DateTimePicker();
			this.lb_DocNumber = new System.Windows.Forms.Label();
			this.tb_DocNumber = new System.Windows.Forms.TextBox();
			this.lb_PaymentMethod = new System.Windows.Forms.Label();
			this.lb_Installments = new System.Windows.Forms.Label();
			this.tb_Installments = new System.Windows.Forms.TextBox();
			this.lb_ExpirationData = new System.Windows.Forms.Label();
			this.btn_CloseOrder = new System.Windows.Forms.Button();
			this.btn_SaveOrder = new System.Windows.Forms.Button();
			this.btn_NewOrder = new System.Windows.Forms.Button();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.tb_Client = new System.Windows.Forms.TextBox();
			this.tb_TotalOrder = new System.Windows.Forms.TextBox();
			this.lb_ID = new System.Windows.Forms.Label();
			this.lb_Client = new System.Windows.Forms.Label();
			this.lb_TotalOrder = new System.Windows.Forms.Label();
			this.btn_SerchClient = new System.Windows.Forms.Button();
			this.lb_Order = new System.Windows.Forms.Label();
			this.tb_Order = new System.Windows.Forms.TextBox();
			this.btn_OrderClose = new System.Windows.Forms.Button();
			this.btn_SearchProduct = new System.Windows.Forms.Button();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tc_SalesOrder.SuspendLayout();
			this.tp_Product.SuspendLayout();
			this.tp_ExpirationDate.SuspendLayout();
			this.SuspendLayout();
			// 
			// tc_SalesOrder
			// 
			this.tc_SalesOrder.Controls.Add(this.tp_Product);
			this.tc_SalesOrder.Controls.Add(this.tp_ExpirationDate);
			this.tc_SalesOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tc_SalesOrder.Location = new System.Drawing.Point(0, 111);
			this.tc_SalesOrder.Name = "tc_SalesOrder";
			this.tc_SalesOrder.SelectedIndex = 0;
			this.tc_SalesOrder.Size = new System.Drawing.Size(677, 347);
			this.tc_SalesOrder.TabIndex = 0;
			// 
			// tp_Product
			// 
			this.tp_Product.BackColor = System.Drawing.SystemColors.Control;
			this.tp_Product.Controls.Add(this.btn_SearchProduct);
			this.tp_Product.Controls.Add(this.btn_OrderClose);
			this.tp_Product.Controls.Add(this.btn_SaveProduct);
			this.tp_Product.Controls.Add(this.lb_Product);
			this.tp_Product.Controls.Add(this.lv_Products);
			this.tp_Product.Controls.Add(this.lb_Price);
			this.tp_Product.Controls.Add(this.tb_Price);
			this.tp_Product.Controls.Add(this.lb_Discount);
			this.tp_Product.Controls.Add(this.tb_Discount);
			this.tp_Product.Controls.Add(this.lb_Amount);
			this.tp_Product.Controls.Add(this.tb_Amount);
			this.tp_Product.Controls.Add(this.tb_Product);
			this.tp_Product.Controls.Add(this.lb_BarCode);
			this.tp_Product.Controls.Add(this.tb_BarCode);
			this.tp_Product.Location = new System.Drawing.Point(4, 22);
			this.tp_Product.Name = "tp_Product";
			this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Product.Size = new System.Drawing.Size(669, 321);
			this.tp_Product.TabIndex = 0;
			this.tp_Product.Text = "Produtos";
			// 
			// btn_SaveProduct
			// 
			this.btn_SaveProduct.Location = new System.Drawing.Point(432, 72);
			this.btn_SaveProduct.Name = "btn_SaveProduct";
			this.btn_SaveProduct.Size = new System.Drawing.Size(109, 24);
			this.btn_SaveProduct.TabIndex = 10;
			this.btn_SaveProduct.Text = "Salvar Produto";
			this.btn_SaveProduct.UseVisualStyleBackColor = true;
			// 
			// lb_Product
			// 
			this.lb_Product.AutoSize = true;
			this.lb_Product.Location = new System.Drawing.Point(129, 13);
			this.lb_Product.Name = "lb_Product";
			this.lb_Product.Size = new System.Drawing.Size(110, 13);
			this.lb_Product.TabIndex = 20;
			this.lb_Product.Text = "Descrição do Produto";
			// 
			// lv_Products
			// 
			this.lv_Products.AutoArrange = false;
			this.lv_Products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lv_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lv_Products.FullRowSelect = true;
			this.lv_Products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv_Products.HideSelection = false;
			this.lv_Products.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lv_Products.LabelWrap = false;
			this.lv_Products.Location = new System.Drawing.Point(11, 100);
			this.lv_Products.MultiSelect = false;
			this.lv_Products.Name = "lv_Products";
			this.lv_Products.Size = new System.Drawing.Size(650, 213);
			this.lv_Products.TabIndex = 19;
			this.lv_Products.TileSize = new System.Drawing.Size(180, 30);
			this.lv_Products.UseCompatibleStateImageBehavior = false;
			this.lv_Products.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Descrição";
			this.columnHeader1.Width = 260;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Código de Barras";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Qtde";
			this.columnHeader3.Width = 55;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Desconto";
			this.columnHeader4.Width = 64;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Valor Unit.";
			this.columnHeader5.Width = 69;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Total";
			this.columnHeader6.Width = 75;
			// 
			// lb_Price
			// 
			this.lb_Price.AutoSize = true;
			this.lb_Price.Location = new System.Drawing.Point(242, 56);
			this.lb_Price.Name = "lb_Price";
			this.lb_Price.Size = new System.Drawing.Size(70, 13);
			this.lb_Price.TabIndex = 18;
			this.lb_Price.Text = "Valor Unitário";
			// 
			// tb_Price
			// 
			this.tb_Price.Location = new System.Drawing.Point(242, 75);
			this.tb_Price.Name = "tb_Price";
			this.tb_Price.Size = new System.Drawing.Size(106, 20);
			this.tb_Price.TabIndex = 17;
			// 
			// lb_Discount
			// 
			this.lb_Discount.AutoSize = true;
			this.lb_Discount.Location = new System.Drawing.Point(126, 56);
			this.lb_Discount.Name = "lb_Discount";
			this.lb_Discount.Size = new System.Drawing.Size(53, 13);
			this.lb_Discount.TabIndex = 16;
			this.lb_Discount.Text = "Desconto";
			// 
			// tb_Discount
			// 
			this.tb_Discount.Location = new System.Drawing.Point(126, 75);
			this.tb_Discount.Name = "tb_Discount";
			this.tb_Discount.Size = new System.Drawing.Size(106, 20);
			this.tb_Discount.TabIndex = 15;
			// 
			// lb_Amount
			// 
			this.lb_Amount.AutoSize = true;
			this.lb_Amount.Location = new System.Drawing.Point(11, 56);
			this.lb_Amount.Name = "lb_Amount";
			this.lb_Amount.Size = new System.Drawing.Size(62, 13);
			this.lb_Amount.TabIndex = 14;
			this.lb_Amount.Text = "Quantidade";
			// 
			// tb_Amount
			// 
			this.tb_Amount.Location = new System.Drawing.Point(11, 75);
			this.tb_Amount.Name = "tb_Amount";
			this.tb_Amount.Size = new System.Drawing.Size(106, 20);
			this.tb_Amount.TabIndex = 13;
			// 
			// tb_Product
			// 
			this.tb_Product.Location = new System.Drawing.Point(129, 32);
			this.tb_Product.Name = "tb_Product";
			this.tb_Product.Size = new System.Drawing.Size(412, 20);
			this.tb_Product.TabIndex = 12;
			// 
			// lb_BarCode
			// 
			this.lb_BarCode.AutoSize = true;
			this.lb_BarCode.Location = new System.Drawing.Point(11, 13);
			this.lb_BarCode.Name = "lb_BarCode";
			this.lb_BarCode.Size = new System.Drawing.Size(88, 13);
			this.lb_BarCode.TabIndex = 11;
			this.lb_BarCode.Text = "Código de Barras";
			// 
			// tb_BarCode
			// 
			this.tb_BarCode.Location = new System.Drawing.Point(11, 32);
			this.tb_BarCode.Name = "tb_BarCode";
			this.tb_BarCode.Size = new System.Drawing.Size(106, 20);
			this.tb_BarCode.TabIndex = 10;
			// 
			// tp_ExpirationDate
			// 
			this.tp_ExpirationDate.BackColor = System.Drawing.SystemColors.Control;
			this.tp_ExpirationDate.Controls.Add(this.btn_Save);
			this.tp_ExpirationDate.Controls.Add(this.lv_Expirations);
			this.tp_ExpirationDate.Controls.Add(this.cb_PaymentMethod);
			this.tp_ExpirationDate.Controls.Add(this.dtp_ExpirationData);
			this.tp_ExpirationDate.Controls.Add(this.lb_DocNumber);
			this.tp_ExpirationDate.Controls.Add(this.tb_DocNumber);
			this.tp_ExpirationDate.Controls.Add(this.lb_PaymentMethod);
			this.tp_ExpirationDate.Controls.Add(this.lb_Installments);
			this.tp_ExpirationDate.Controls.Add(this.tb_Installments);
			this.tp_ExpirationDate.Controls.Add(this.lb_ExpirationData);
			this.tp_ExpirationDate.Location = new System.Drawing.Point(4, 22);
			this.tp_ExpirationDate.Name = "tp_ExpirationDate";
			this.tp_ExpirationDate.Padding = new System.Windows.Forms.Padding(3);
			this.tp_ExpirationDate.Size = new System.Drawing.Size(669, 321);
			this.tp_ExpirationDate.TabIndex = 1;
			this.tp_ExpirationDate.Text = "Vencimentos";
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(483, 26);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(133, 23);
			this.btn_Save.TabIndex = 21;
			this.btn_Save.Text = "Lançar Vencimento";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// lv_Expirations
			// 
			this.lv_Expirations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader10});
			this.lv_Expirations.HideSelection = false;
			this.lv_Expirations.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.lv_Expirations.Location = new System.Drawing.Point(11, 67);
			this.lv_Expirations.Name = "lv_Expirations";
			this.lv_Expirations.Size = new System.Drawing.Size(650, 246);
			this.lv_Expirations.TabIndex = 20;
			this.lv_Expirations.UseCompatibleStateImageBehavior = false;
			this.lv_Expirations.View = System.Windows.Forms.View.Details;
			// 
			// cb_PaymentMethod
			// 
			this.cb_PaymentMethod.FormattingEnabled = true;
			this.cb_PaymentMethod.Location = new System.Drawing.Point(234, 29);
			this.cb_PaymentMethod.Name = "cb_PaymentMethod";
			this.cb_PaymentMethod.Size = new System.Drawing.Size(121, 21);
			this.cb_PaymentMethod.TabIndex = 19;
			// 
			// dtp_ExpirationData
			// 
			this.dtp_ExpirationData.CustomFormat = "";
			this.dtp_ExpirationData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ExpirationData.Location = new System.Drawing.Point(14, 30);
			this.dtp_ExpirationData.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtp_ExpirationData.Name = "dtp_ExpirationData";
			this.dtp_ExpirationData.Size = new System.Drawing.Size(106, 20);
			this.dtp_ExpirationData.TabIndex = 18;
			this.dtp_ExpirationData.Value = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
			// 
			// lb_DocNumber
			// 
			this.lb_DocNumber.AutoSize = true;
			this.lb_DocNumber.Location = new System.Drawing.Point(372, 10);
			this.lb_DocNumber.Name = "lb_DocNumber";
			this.lb_DocNumber.Size = new System.Drawing.Size(77, 13);
			this.lb_DocNumber.TabIndex = 17;
			this.lb_DocNumber.Text = "Nº Documento";
			// 
			// tb_DocNumber
			// 
			this.tb_DocNumber.Location = new System.Drawing.Point(372, 29);
			this.tb_DocNumber.Name = "tb_DocNumber";
			this.tb_DocNumber.Size = new System.Drawing.Size(96, 20);
			this.tb_DocNumber.TabIndex = 16;
			// 
			// lb_PaymentMethod
			// 
			this.lb_PaymentMethod.AutoSize = true;
			this.lb_PaymentMethod.Location = new System.Drawing.Point(231, 11);
			this.lb_PaymentMethod.Name = "lb_PaymentMethod";
			this.lb_PaymentMethod.Size = new System.Drawing.Size(85, 13);
			this.lb_PaymentMethod.TabIndex = 15;
			this.lb_PaymentMethod.Text = "Tipo Pagamento";
			// 
			// lb_Installments
			// 
			this.lb_Installments.AutoSize = true;
			this.lb_Installments.Location = new System.Drawing.Point(135, 11);
			this.lb_Installments.Name = "lb_Installments";
			this.lb_Installments.Size = new System.Drawing.Size(70, 13);
			this.lb_Installments.TabIndex = 13;
			this.lb_Installments.Text = "Valor Parcela";
			// 
			// tb_Installments
			// 
			this.tb_Installments.Location = new System.Drawing.Point(135, 30);
			this.tb_Installments.Name = "tb_Installments";
			this.tb_Installments.Size = new System.Drawing.Size(84, 20);
			this.tb_Installments.TabIndex = 12;
			// 
			// lb_ExpirationData
			// 
			this.lb_ExpirationData.AutoSize = true;
			this.lb_ExpirationData.Location = new System.Drawing.Point(8, 12);
			this.lb_ExpirationData.Name = "lb_ExpirationData";
			this.lb_ExpirationData.Size = new System.Drawing.Size(61, 13);
			this.lb_ExpirationData.TabIndex = 11;
			this.lb_ExpirationData.Text = "Data Venc.";
			// 
			// btn_CloseOrder
			// 
			this.btn_CloseOrder.Location = new System.Drawing.Point(565, 81);
			this.btn_CloseOrder.Name = "btn_CloseOrder";
			this.btn_CloseOrder.Size = new System.Drawing.Size(100, 24);
			this.btn_CloseOrder.TabIndex = 1;
			this.btn_CloseOrder.Text = "Fechar";
			this.btn_CloseOrder.UseVisualStyleBackColor = true;
			// 
			// btn_SaveOrder
			// 
			this.btn_SaveOrder.Location = new System.Drawing.Point(565, 51);
			this.btn_SaveOrder.Name = "btn_SaveOrder";
			this.btn_SaveOrder.Size = new System.Drawing.Size(100, 24);
			this.btn_SaveOrder.TabIndex = 0;
			this.btn_SaveOrder.Text = "Salvar";
			this.btn_SaveOrder.UseVisualStyleBackColor = true;
			// 
			// btn_NewOrder
			// 
			this.btn_NewOrder.Location = new System.Drawing.Point(565, 21);
			this.btn_NewOrder.Name = "btn_NewOrder";
			this.btn_NewOrder.Size = new System.Drawing.Size(100, 24);
			this.btn_NewOrder.TabIndex = 2;
			this.btn_NewOrder.Text = "Novo";
			this.btn_NewOrder.UseVisualStyleBackColor = true;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(15, 84);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(63, 20);
			this.tb_ID.TabIndex = 1;
			// 
			// tb_Client
			// 
			this.tb_Client.Location = new System.Drawing.Point(85, 84);
			this.tb_Client.Name = "tb_Client";
			this.tb_Client.Size = new System.Drawing.Size(463, 20);
			this.tb_Client.TabIndex = 2;
			// 
			// tb_TotalOrder
			// 
			this.tb_TotalOrder.BackColor = System.Drawing.SystemColors.MenuBar;
			this.tb_TotalOrder.Location = new System.Drawing.Point(363, 28);
			this.tb_TotalOrder.Name = "tb_TotalOrder";
			this.tb_TotalOrder.ReadOnly = true;
			this.tb_TotalOrder.Size = new System.Drawing.Size(112, 20);
			this.tb_TotalOrder.TabIndex = 3;
			this.tb_TotalOrder.WordWrap = false;
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Location = new System.Drawing.Point(15, 65);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(40, 13);
			this.lb_ID.TabIndex = 4;
			this.lb_ID.Text = "Código";
			// 
			// lb_Client
			// 
			this.lb_Client.AutoSize = true;
			this.lb_Client.Location = new System.Drawing.Point(85, 64);
			this.lb_Client.Name = "lb_Client";
			this.lb_Client.Size = new System.Drawing.Size(39, 13);
			this.lb_Client.TabIndex = 5;
			this.lb_Client.Text = "Cliente";
			// 
			// lb_TotalOrder
			// 
			this.lb_TotalOrder.AutoSize = true;
			this.lb_TotalOrder.Location = new System.Drawing.Point(376, 9);
			this.lb_TotalOrder.Name = "lb_TotalOrder";
			this.lb_TotalOrder.Size = new System.Drawing.Size(82, 13);
			this.lb_TotalOrder.TabIndex = 6;
			this.lb_TotalOrder.Text = "Total do Pedido";
			// 
			// btn_SerchClient
			// 
			this.btn_SerchClient.Location = new System.Drawing.Point(473, 58);
			this.btn_SerchClient.Name = "btn_SerchClient";
			this.btn_SerchClient.Size = new System.Drawing.Size(75, 23);
			this.btn_SerchClient.TabIndex = 7;
			this.btn_SerchClient.Text = "Pesquisar";
			this.btn_SerchClient.UseVisualStyleBackColor = true;
			// 
			// lb_Order
			// 
			this.lb_Order.AutoSize = true;
			this.lb_Order.Location = new System.Drawing.Point(15, 9);
			this.lb_Order.Name = "lb_Order";
			this.lb_Order.Size = new System.Drawing.Size(40, 13);
			this.lb_Order.TabIndex = 9;
			this.lb_Order.Text = "Pedido";
			// 
			// tb_Order
			// 
			this.tb_Order.Location = new System.Drawing.Point(15, 28);
			this.tb_Order.Name = "tb_Order";
			this.tb_Order.Size = new System.Drawing.Size(63, 20);
			this.tb_Order.TabIndex = 8;
			// 
			// btn_OrderClose
			// 
			this.btn_OrderClose.BackColor = System.Drawing.Color.MintCream;
			this.btn_OrderClose.Location = new System.Drawing.Point(561, 32);
			this.btn_OrderClose.Name = "btn_OrderClose";
			this.btn_OrderClose.Size = new System.Drawing.Size(100, 62);
			this.btn_OrderClose.TabIndex = 21;
			this.btn_OrderClose.Text = "Finalizar Pedido";
			this.btn_OrderClose.UseVisualStyleBackColor = false;
			// 
			// btn_SearchProduct
			// 
			this.btn_SearchProduct.Location = new System.Drawing.Point(469, 6);
			this.btn_SearchProduct.Name = "btn_SearchProduct";
			this.btn_SearchProduct.Size = new System.Drawing.Size(75, 23);
			this.btn_SearchProduct.TabIndex = 10;
			this.btn_SearchProduct.Text = "Pesquisar";
			this.btn_SearchProduct.UseVisualStyleBackColor = true;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Número Doc.";
			this.columnHeader7.Width = 145;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Dava Venc.";
			this.columnHeader8.Width = 131;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Valor Parcela";
			this.columnHeader9.Width = 117;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Data Baixa";
			this.columnHeader10.Width = 109;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Tipo Pagamento";
			this.columnHeader11.Width = 127;
			// 
			// frm_SalesOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 458);
			this.Controls.Add(this.btn_CloseOrder);
			this.Controls.Add(this.lb_Order);
			this.Controls.Add(this.btn_SaveOrder);
			this.Controls.Add(this.tb_Order);
			this.Controls.Add(this.btn_NewOrder);
			this.Controls.Add(this.btn_SerchClient);
			this.Controls.Add(this.lb_TotalOrder);
			this.Controls.Add(this.lb_Client);
			this.Controls.Add(this.lb_ID);
			this.Controls.Add(this.tb_TotalOrder);
			this.Controls.Add(this.tb_Client);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.tc_SalesOrder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_SalesOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pedido de Vendas";
			this.tc_SalesOrder.ResumeLayout(false);
			this.tp_Product.ResumeLayout(false);
			this.tp_Product.PerformLayout();
			this.tp_ExpirationDate.ResumeLayout(false);
			this.tp_ExpirationDate.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tc_SalesOrder;
		private System.Windows.Forms.TabPage tp_Product;
		private System.Windows.Forms.TabPage tp_ExpirationDate;
		private System.Windows.Forms.ListView lv_Products;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label lb_Price;
		private System.Windows.Forms.TextBox tb_Price;
		private System.Windows.Forms.Label lb_Discount;
		private System.Windows.Forms.TextBox tb_Discount;
		private System.Windows.Forms.Label lb_Amount;
		private System.Windows.Forms.TextBox tb_Amount;
		private System.Windows.Forms.TextBox tb_Product;
		private System.Windows.Forms.Label lb_BarCode;
		private System.Windows.Forms.TextBox tb_BarCode;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.TextBox tb_Client;
		private System.Windows.Forms.TextBox tb_TotalOrder;
		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.Label lb_Client;
		private System.Windows.Forms.Label lb_TotalOrder;
		private System.Windows.Forms.Button btn_SerchClient;
		private System.Windows.Forms.Label lb_Order;
		private System.Windows.Forms.TextBox tb_Order;
		private System.Windows.Forms.Label lb_Product;
		private System.Windows.Forms.Button btn_CloseOrder;
		private System.Windows.Forms.Button btn_SaveOrder;
		private System.Windows.Forms.Button btn_NewOrder;
		private System.Windows.Forms.Button btn_SaveProduct;
		private System.Windows.Forms.DateTimePicker dtp_ExpirationData;
		private System.Windows.Forms.Label lb_DocNumber;
		private System.Windows.Forms.TextBox tb_DocNumber;
		private System.Windows.Forms.Label lb_PaymentMethod;
		private System.Windows.Forms.Label lb_Installments;
		private System.Windows.Forms.TextBox tb_Installments;
		private System.Windows.Forms.Label lb_ExpirationData;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.ListView lv_Expirations;
		private System.Windows.Forms.ComboBox cb_PaymentMethod;
		private System.Windows.Forms.Button btn_OrderClose;
		private System.Windows.Forms.Button btn_SearchProduct;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
	}
}