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
			this.tc_SalesOrder = new System.Windows.Forms.TabControl();
			this.tp_Product = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_ItemTotal = new System.Windows.Forms.TextBox();
			this.lb_ProductID = new System.Windows.Forms.Label();
			this.tb_ProductID = new System.Windows.Forms.TextBox();
			this.dgv_OrderItem = new System.Windows.Forms.DataGridView();
			this.btn_DelProduct = new System.Windows.Forms.Button();
			this.btn_SearchProduct = new System.Windows.Forms.Button();
			this.btn_AddProduct = new System.Windows.Forms.Button();
			this.lb_Product = new System.Windows.Forms.Label();
			this.lb_Price = new System.Windows.Forms.Label();
			this.tb_Price = new System.Windows.Forms.TextBox();
			this.lb_Discount = new System.Windows.Forms.Label();
			this.tb_Discount = new System.Windows.Forms.TextBox();
			this.lb_Amount = new System.Windows.Forms.Label();
			this.tb_Quantity = new System.Windows.Forms.TextBox();
			this.tb_Product = new System.Windows.Forms.TextBox();
			this.lb_BarCode = new System.Windows.Forms.Label();
			this.tb_BarCode = new System.Windows.Forms.TextBox();
			this.tp_ExpirationDate = new System.Windows.Forms.TabPage();
			this.dgv_OrderDueDate = new System.Windows.Forms.DataGridView();
			this.btn_DelExpiration = new System.Windows.Forms.Button();
			this.btn_AddExpiration = new System.Windows.Forms.Button();
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
			this.lb_Order = new System.Windows.Forms.Label();
			this.tb_Order = new System.Windows.Forms.TextBox();
			this.btn_SearchOrder = new System.Windows.Forms.Button();
			this.btn_SearchClient = new System.Windows.Forms.Button();
			this.tc_SalesOrder.SuspendLayout();
			this.tp_Product.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItem)).BeginInit();
			this.tp_ExpirationDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDueDate)).BeginInit();
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
			this.tp_Product.Controls.Add(this.label2);
			this.tp_Product.Controls.Add(this.tb_ItemTotal);
			this.tp_Product.Controls.Add(this.lb_ProductID);
			this.tp_Product.Controls.Add(this.tb_ProductID);
			this.tp_Product.Controls.Add(this.dgv_OrderItem);
			this.tp_Product.Controls.Add(this.btn_DelProduct);
			this.tp_Product.Controls.Add(this.btn_SearchProduct);
			this.tp_Product.Controls.Add(this.btn_AddProduct);
			this.tp_Product.Controls.Add(this.lb_Product);
			this.tp_Product.Controls.Add(this.lb_Price);
			this.tp_Product.Controls.Add(this.tb_Price);
			this.tp_Product.Controls.Add(this.lb_Discount);
			this.tp_Product.Controls.Add(this.tb_Discount);
			this.tp_Product.Controls.Add(this.lb_Amount);
			this.tp_Product.Controls.Add(this.tb_Quantity);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(356, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 42;
			this.label2.Text = "Total";
			// 
			// tb_ItemTotal
			// 
			this.tb_ItemTotal.Location = new System.Drawing.Point(356, 75);
			this.tb_ItemTotal.Name = "tb_ItemTotal";
			this.tb_ItemTotal.Size = new System.Drawing.Size(106, 20);
			this.tb_ItemTotal.TabIndex = 41;
			// 
			// lb_ProductID
			// 
			this.lb_ProductID.AutoSize = true;
			this.lb_ProductID.Location = new System.Drawing.Point(11, 14);
			this.lb_ProductID.Name = "lb_ProductID";
			this.lb_ProductID.Size = new System.Drawing.Size(95, 13);
			this.lb_ProductID.TabIndex = 40;
			this.lb_ProductID.Text = "Código do Produto";
			// 
			// tb_ProductID
			// 
			this.tb_ProductID.Location = new System.Drawing.Point(11, 33);
			this.tb_ProductID.Name = "tb_ProductID";
			this.tb_ProductID.Size = new System.Drawing.Size(106, 20);
			this.tb_ProductID.TabIndex = 39;
			this.tb_ProductID.Leave += new System.EventHandler(this.tb_ProductID_Leave);
			// 
			// dgv_OrderItem
			// 
			this.dgv_OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_OrderItem.Location = new System.Drawing.Point(11, 101);
			this.dgv_OrderItem.Name = "dgv_OrderItem";
			this.dgv_OrderItem.Size = new System.Drawing.Size(650, 212);
			this.dgv_OrderItem.TabIndex = 38;
			this.dgv_OrderItem.DoubleClick += new System.EventHandler(this.dgv_OrderItem_DoubleClick);
			// 
			// btn_DelProduct
			// 
			this.btn_DelProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_DelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_DelProduct.FlatAppearance.BorderSize = 0;
			this.btn_DelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_DelProduct.Image = global::Rock_Solid.Properties.Resources.Uncheck_Button;
			this.btn_DelProduct.Location = new System.Drawing.Point(596, 68);
			this.btn_DelProduct.Name = "btn_DelProduct";
			this.btn_DelProduct.Size = new System.Drawing.Size(37, 27);
			this.btn_DelProduct.TabIndex = 37;
			this.btn_DelProduct.UseVisualStyleBackColor = true;
			// 
			// btn_SearchProduct
			// 
			this.btn_SearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_SearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_SearchProduct.FlatAppearance.BorderSize = 0;
			this.btn_SearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SearchProduct.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.btn_SearchProduct.Location = new System.Drawing.Point(633, 33);
			this.btn_SearchProduct.Name = "btn_SearchProduct";
			this.btn_SearchProduct.Size = new System.Drawing.Size(18, 20);
			this.btn_SearchProduct.TabIndex = 36;
			this.btn_SearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_SearchProduct.UseVisualStyleBackColor = true;
			// 
			// btn_AddProduct
			// 
			this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AddProduct.FlatAppearance.BorderSize = 0;
			this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddProduct.Image = global::Rock_Solid.Properties.Resources.Check_Button;
			this.btn_AddProduct.Location = new System.Drawing.Point(516, 68);
			this.btn_AddProduct.Name = "btn_AddProduct";
			this.btn_AddProduct.Size = new System.Drawing.Size(37, 27);
			this.btn_AddProduct.TabIndex = 10;
			this.btn_AddProduct.UseVisualStyleBackColor = true;
			// 
			// lb_Product
			// 
			this.lb_Product.AutoSize = true;
			this.lb_Product.Location = new System.Drawing.Point(242, 14);
			this.lb_Product.Name = "lb_Product";
			this.lb_Product.Size = new System.Drawing.Size(110, 13);
			this.lb_Product.TabIndex = 20;
			this.lb_Product.Text = "Descrição do Produto";
			// 
			// lb_Price
			// 
			this.lb_Price.AutoSize = true;
			this.lb_Price.Location = new System.Drawing.Point(124, 56);
			this.lb_Price.Name = "lb_Price";
			this.lb_Price.Size = new System.Drawing.Size(70, 13);
			this.lb_Price.TabIndex = 18;
			this.lb_Price.Text = "Valor Unitário";
			// 
			// tb_Price
			// 
			this.tb_Price.Location = new System.Drawing.Point(124, 75);
			this.tb_Price.Name = "tb_Price";
			this.tb_Price.Size = new System.Drawing.Size(106, 20);
			this.tb_Price.TabIndex = 17;
			// 
			// lb_Discount
			// 
			this.lb_Discount.AutoSize = true;
			this.lb_Discount.Location = new System.Drawing.Point(239, 56);
			this.lb_Discount.Name = "lb_Discount";
			this.lb_Discount.Size = new System.Drawing.Size(53, 13);
			this.lb_Discount.TabIndex = 16;
			this.lb_Discount.Text = "Desconto";
			// 
			// tb_Discount
			// 
			this.tb_Discount.Location = new System.Drawing.Point(239, 75);
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
			// tb_Quantity
			// 
			this.tb_Quantity.Location = new System.Drawing.Point(11, 75);
			this.tb_Quantity.Name = "tb_Quantity";
			this.tb_Quantity.Size = new System.Drawing.Size(106, 20);
			this.tb_Quantity.TabIndex = 13;
			// 
			// tb_Product
			// 
			this.tb_Product.Location = new System.Drawing.Point(242, 33);
			this.tb_Product.Name = "tb_Product";
			this.tb_Product.Size = new System.Drawing.Size(391, 20);
			this.tb_Product.TabIndex = 12;
			// 
			// lb_BarCode
			// 
			this.lb_BarCode.AutoSize = true;
			this.lb_BarCode.Location = new System.Drawing.Point(124, 14);
			this.lb_BarCode.Name = "lb_BarCode";
			this.lb_BarCode.Size = new System.Drawing.Size(88, 13);
			this.lb_BarCode.TabIndex = 11;
			this.lb_BarCode.Text = "Código de Barras";
			// 
			// tb_BarCode
			// 
			this.tb_BarCode.Location = new System.Drawing.Point(124, 33);
			this.tb_BarCode.Name = "tb_BarCode";
			this.tb_BarCode.Size = new System.Drawing.Size(106, 20);
			this.tb_BarCode.TabIndex = 10;
			// 
			// tp_ExpirationDate
			// 
			this.tp_ExpirationDate.BackColor = System.Drawing.SystemColors.Control;
			this.tp_ExpirationDate.Controls.Add(this.dgv_OrderDueDate);
			this.tp_ExpirationDate.Controls.Add(this.btn_DelExpiration);
			this.tp_ExpirationDate.Controls.Add(this.btn_AddExpiration);
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
			// dgv_OrderDueDate
			// 
			this.dgv_OrderDueDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_OrderDueDate.Location = new System.Drawing.Point(11, 56);
			this.dgv_OrderDueDate.Name = "dgv_OrderDueDate";
			this.dgv_OrderDueDate.Size = new System.Drawing.Size(650, 257);
			this.dgv_OrderDueDate.TabIndex = 40;
			// 
			// btn_DelExpiration
			// 
			this.btn_DelExpiration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_DelExpiration.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_DelExpiration.FlatAppearance.BorderSize = 0;
			this.btn_DelExpiration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_DelExpiration.Image = global::Rock_Solid.Properties.Resources.Uncheck_Button;
			this.btn_DelExpiration.Location = new System.Drawing.Point(592, 22);
			this.btn_DelExpiration.Name = "btn_DelExpiration";
			this.btn_DelExpiration.Size = new System.Drawing.Size(37, 27);
			this.btn_DelExpiration.TabIndex = 39;
			this.btn_DelExpiration.UseVisualStyleBackColor = true;
			// 
			// btn_AddExpiration
			// 
			this.btn_AddExpiration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_AddExpiration.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AddExpiration.FlatAppearance.BorderSize = 0;
			this.btn_AddExpiration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddExpiration.Image = global::Rock_Solid.Properties.Resources.Check_Button;
			this.btn_AddExpiration.Location = new System.Drawing.Point(512, 22);
			this.btn_AddExpiration.Name = "btn_AddExpiration";
			this.btn_AddExpiration.Size = new System.Drawing.Size(37, 27);
			this.btn_AddExpiration.TabIndex = 38;
			this.btn_AddExpiration.UseVisualStyleBackColor = true;
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
			this.tb_Client.Size = new System.Drawing.Size(439, 20);
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
			this.tb_Order.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Order_KeyDown);
			// 
			// btn_SearchOrder
			// 
			this.btn_SearchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_SearchOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_SearchOrder.FlatAppearance.BorderSize = 0;
			this.btn_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SearchOrder.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.btn_SearchOrder.Location = new System.Drawing.Point(78, 28);
			this.btn_SearchOrder.Name = "btn_SearchOrder";
			this.btn_SearchOrder.Size = new System.Drawing.Size(18, 20);
			this.btn_SearchOrder.TabIndex = 37;
			this.btn_SearchOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_SearchOrder.UseVisualStyleBackColor = true;
			// 
			// btn_SearchClient
			// 
			this.btn_SearchClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_SearchClient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_SearchClient.FlatAppearance.BorderSize = 0;
			this.btn_SearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SearchClient.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.btn_SearchClient.Location = new System.Drawing.Point(524, 84);
			this.btn_SearchClient.Name = "btn_SearchClient";
			this.btn_SearchClient.Size = new System.Drawing.Size(18, 20);
			this.btn_SearchClient.TabIndex = 36;
			this.btn_SearchClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_SearchClient.UseVisualStyleBackColor = true;
			// 
			// frm_SalesOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 458);
			this.Controls.Add(this.btn_SearchOrder);
			this.Controls.Add(this.btn_SearchClient);
			this.Controls.Add(this.btn_CloseOrder);
			this.Controls.Add(this.lb_Order);
			this.Controls.Add(this.btn_SaveOrder);
			this.Controls.Add(this.tb_Order);
			this.Controls.Add(this.btn_NewOrder);
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
			this.Enter += new System.EventHandler(this.frm_SalesOrder_Enter);
			this.tc_SalesOrder.ResumeLayout(false);
			this.tp_Product.ResumeLayout(false);
			this.tp_Product.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItem)).EndInit();
			this.tp_ExpirationDate.ResumeLayout(false);
			this.tp_ExpirationDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDueDate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tc_SalesOrder;
		private System.Windows.Forms.TabPage tp_Product;
		private System.Windows.Forms.TabPage tp_ExpirationDate;
		private System.Windows.Forms.Label lb_Price;
		private System.Windows.Forms.TextBox tb_Price;
		private System.Windows.Forms.Label lb_Discount;
		private System.Windows.Forms.TextBox tb_Discount;
		private System.Windows.Forms.Label lb_Amount;
		private System.Windows.Forms.TextBox tb_Quantity;
		private System.Windows.Forms.TextBox tb_Product;
		private System.Windows.Forms.Label lb_BarCode;
		private System.Windows.Forms.TextBox tb_BarCode;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.TextBox tb_Client;
		private System.Windows.Forms.TextBox tb_TotalOrder;
		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.Label lb_Client;
		private System.Windows.Forms.Label lb_TotalOrder;
		private System.Windows.Forms.Label lb_Order;
		private System.Windows.Forms.TextBox tb_Order;
		private System.Windows.Forms.Label lb_Product;
		private System.Windows.Forms.Button btn_CloseOrder;
		private System.Windows.Forms.Button btn_SaveOrder;
		private System.Windows.Forms.Button btn_NewOrder;
		private System.Windows.Forms.Button btn_AddProduct;
		private System.Windows.Forms.DateTimePicker dtp_ExpirationData;
		private System.Windows.Forms.Label lb_DocNumber;
		private System.Windows.Forms.TextBox tb_DocNumber;
		private System.Windows.Forms.Label lb_PaymentMethod;
		private System.Windows.Forms.Label lb_Installments;
		private System.Windows.Forms.TextBox tb_Installments;
		private System.Windows.Forms.Label lb_ExpirationData;
		private System.Windows.Forms.ComboBox cb_PaymentMethod;
		private System.Windows.Forms.Button btn_SearchProduct;
		private System.Windows.Forms.Button btn_SearchClient;
		private System.Windows.Forms.Button btn_SearchOrder;
		private System.Windows.Forms.Button btn_DelProduct;
		private System.Windows.Forms.Button btn_DelExpiration;
		private System.Windows.Forms.Button btn_AddExpiration;
		private System.Windows.Forms.DataGridView dgv_OrderItem;
		private System.Windows.Forms.DataGridView dgv_OrderDueDate;
		private System.Windows.Forms.Label lb_ProductID;
		private System.Windows.Forms.TextBox tb_ProductID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_ItemTotal;
	}
}