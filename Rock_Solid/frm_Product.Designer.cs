namespace Rock_Solid
{
	partial class frm_Product
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
			this.lb_ID = new System.Windows.Forms.Label();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.tb_Description = new System.Windows.Forms.TextBox();
			this.lb_Description = new System.Windows.Forms.Label();
			this.tb_Purchase = new System.Windows.Forms.TextBox();
			this.lb_Purchase = new System.Windows.Forms.Label();
			this.tb_MarkUp = new System.Windows.Forms.TextBox();
			this.lb_MarkUp = new System.Windows.Forms.Label();
			this.tb_Sell = new System.Windows.Forms.TextBox();
			this.lb_Sell = new System.Windows.Forms.Label();
			this.tb_BarCode = new System.Windows.Forms.TextBox();
			this.lb_BarCode = new System.Windows.Forms.Label();
			this.tb_Type = new System.Windows.Forms.TextBox();
			this.lb_Type = new System.Windows.Forms.Label();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.lb_Name = new System.Windows.Forms.Label();
			this.tc_Product = new System.Windows.Forms.TabControl();
			this.tp_Product = new System.Windows.Forms.TabPage();
			this.btn_Search = new System.Windows.Forms.Button();
			this.lb_Weight = new System.Windows.Forms.Label();
			this.tb_Weight = new System.Windows.Forms.TextBox();
			this.lb_Color = new System.Windows.Forms.Label();
			this.tb_Color = new System.Windows.Forms.TextBox();
			this.lb_Size = new System.Windows.Forms.Label();
			this.tb_Size = new System.Windows.Forms.TextBox();
			this.tb_Price = new System.Windows.Forms.TabPage();
			this.tb_UpdatedAt = new System.Windows.Forms.TextBox();
			this.lb_UpdatedAt = new System.Windows.Forms.Label();
			this.tb_CreatedAt = new System.Windows.Forms.TextBox();
			this.lb_CreatedAt = new System.Windows.Forms.Label();
			this.lb_Stock = new System.Windows.Forms.Label();
			this.tb_Stock = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tb_LastPurchase = new System.Windows.Forms.TextBox();
			this.lb_LastPurchase = new System.Windows.Forms.Label();
			this.tb_ProviderID = new System.Windows.Forms.TextBox();
			this.tb_ProviderName = new System.Windows.Forms.TextBox();
			this.lb_ProviderID = new System.Windows.Forms.Label();
			this.lb_ProviderName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_New = new System.Windows.Forms.Button();
			this.btn_ProfilePicture = new System.Windows.Forms.Button();
			this.pb_User = new System.Windows.Forms.PictureBox();
			this.tc_Product.SuspendLayout();
			this.tp_Product.SuspendLayout();
			this.tb_Price.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Location = new System.Drawing.Point(15, 15);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(18, 13);
			this.lb_ID.TabIndex = 0;
			this.lb_ID.Text = "ID";
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(18, 32);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(63, 20);
			this.tb_ID.TabIndex = 0;
			this.tb_ID.Text = "0";
			this.tb_ID.Enter += new System.EventHandler(this.tb_ID_Enter);
			this.tb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ID_KeyDown);
			// 
			// tb_Description
			// 
			this.tb_Description.Location = new System.Drawing.Point(18, 72);
			this.tb_Description.Name = "tb_Description";
			this.tb_Description.Size = new System.Drawing.Size(333, 20);
			this.tb_Description.TabIndex = 3;
			// 
			// lb_Description
			// 
			this.lb_Description.AutoSize = true;
			this.lb_Description.Location = new System.Drawing.Point(15, 55);
			this.lb_Description.Name = "lb_Description";
			this.lb_Description.Size = new System.Drawing.Size(100, 13);
			this.lb_Description.TabIndex = 2;
			this.lb_Description.Text = "Descrição Competa";
			// 
			// tb_Purchase
			// 
			this.tb_Purchase.Location = new System.Drawing.Point(25, 28);
			this.tb_Purchase.Name = "tb_Purchase";
			this.tb_Purchase.Size = new System.Drawing.Size(100, 20);
			this.tb_Purchase.TabIndex = 0;
			this.tb_Purchase.Text = "0";
			// 
			// lb_Purchase
			// 
			this.lb_Purchase.AutoSize = true;
			this.lb_Purchase.Location = new System.Drawing.Point(22, 11);
			this.lb_Purchase.Name = "lb_Purchase";
			this.lb_Purchase.Size = new System.Drawing.Size(58, 13);
			this.lb_Purchase.TabIndex = 4;
			this.lb_Purchase.Text = "Vlr Compra";
			// 
			// tb_MarkUp
			// 
			this.tb_MarkUp.Location = new System.Drawing.Point(131, 28);
			this.tb_MarkUp.Name = "tb_MarkUp";
			this.tb_MarkUp.Size = new System.Drawing.Size(100, 20);
			this.tb_MarkUp.TabIndex = 1;
			this.tb_MarkUp.Text = "0";
			this.tb_MarkUp.Leave += new System.EventHandler(this.tb_MarkUp_Leave);
			// 
			// lb_MarkUp
			// 
			this.lb_MarkUp.AutoSize = true;
			this.lb_MarkUp.Location = new System.Drawing.Point(128, 11);
			this.lb_MarkUp.Name = "lb_MarkUp";
			this.lb_MarkUp.Size = new System.Drawing.Size(75, 13);
			this.lb_MarkUp.TabIndex = 6;
			this.lb_MarkUp.Text = "Margem Lucro";
			// 
			// tb_Sell
			// 
			this.tb_Sell.Location = new System.Drawing.Point(237, 28);
			this.tb_Sell.Name = "tb_Sell";
			this.tb_Sell.Size = new System.Drawing.Size(100, 20);
			this.tb_Sell.TabIndex = 2;
			this.tb_Sell.Text = "0";
			this.tb_Sell.Leave += new System.EventHandler(this.tb_Sell_Leave);
			// 
			// lb_Sell
			// 
			this.lb_Sell.AutoSize = true;
			this.lb_Sell.Location = new System.Drawing.Point(234, 11);
			this.lb_Sell.Name = "lb_Sell";
			this.lb_Sell.Size = new System.Drawing.Size(51, 13);
			this.lb_Sell.TabIndex = 8;
			this.lb_Sell.Text = "Vr Venda";
			// 
			// tb_BarCode
			// 
			this.tb_BarCode.Location = new System.Drawing.Point(18, 114);
			this.tb_BarCode.Name = "tb_BarCode";
			this.tb_BarCode.Size = new System.Drawing.Size(110, 20);
			this.tb_BarCode.TabIndex = 4;
			this.tb_BarCode.Text = "0";
			// 
			// lb_BarCode
			// 
			this.lb_BarCode.AutoSize = true;
			this.lb_BarCode.Location = new System.Drawing.Point(15, 97);
			this.lb_BarCode.Name = "lb_BarCode";
			this.lb_BarCode.Size = new System.Drawing.Size(62, 13);
			this.lb_BarCode.TabIndex = 12;
			this.lb_BarCode.Text = "Cód. Barras";
			// 
			// tb_Type
			// 
			this.tb_Type.Location = new System.Drawing.Point(251, 114);
			this.tb_Type.Name = "tb_Type";
			this.tb_Type.Size = new System.Drawing.Size(100, 20);
			this.tb_Type.TabIndex = 5;
			// 
			// lb_Type
			// 
			this.lb_Type.AutoSize = true;
			this.lb_Type.Location = new System.Drawing.Point(248, 97);
			this.lb_Type.Name = "lb_Type";
			this.lb_Type.Size = new System.Drawing.Size(83, 13);
			this.lb_Type.TabIndex = 14;
			this.lb_Type.Text = "Tipo do Produto";
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(85, 32);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(246, 20);
			this.tb_Name.TabIndex = 1;
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.Location = new System.Drawing.Point(82, 15);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(94, 13);
			this.lb_Name.TabIndex = 16;
			this.lb_Name.Text = "Descrição Simples";
			// 
			// tc_Product
			// 
			this.tc_Product.Controls.Add(this.tp_Product);
			this.tc_Product.Controls.Add(this.tb_Price);
			this.tc_Product.Location = new System.Drawing.Point(12, 12);
			this.tc_Product.Name = "tc_Product";
			this.tc_Product.SelectedIndex = 0;
			this.tc_Product.Size = new System.Drawing.Size(381, 213);
			this.tc_Product.TabIndex = 1;
			// 
			// tp_Product
			// 
			this.tp_Product.Controls.Add(this.btn_Search);
			this.tp_Product.Controls.Add(this.lb_Weight);
			this.tp_Product.Controls.Add(this.tb_Weight);
			this.tp_Product.Controls.Add(this.lb_Color);
			this.tp_Product.Controls.Add(this.tb_Color);
			this.tp_Product.Controls.Add(this.lb_Size);
			this.tp_Product.Controls.Add(this.tb_Size);
			this.tp_Product.Controls.Add(this.tb_ID);
			this.tp_Product.Controls.Add(this.lb_ID);
			this.tp_Product.Controls.Add(this.lb_Description);
			this.tp_Product.Controls.Add(this.tb_Description);
			this.tp_Product.Controls.Add(this.lb_BarCode);
			this.tp_Product.Controls.Add(this.tb_BarCode);
			this.tp_Product.Controls.Add(this.lb_Type);
			this.tp_Product.Controls.Add(this.tb_Name);
			this.tp_Product.Controls.Add(this.tb_Type);
			this.tp_Product.Controls.Add(this.lb_Name);
			this.tp_Product.Location = new System.Drawing.Point(4, 22);
			this.tp_Product.Name = "tp_Product";
			this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Product.Size = new System.Drawing.Size(373, 187);
			this.tp_Product.TabIndex = 0;
			this.tp_Product.Text = "Produto";
			this.tp_Product.UseVisualStyleBackColor = true;
			// 
			// btn_Search
			// 
			this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Search.FlatAppearance.BorderSize = 0;
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Search.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.btn_Search.Location = new System.Drawing.Point(331, 32);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(18, 20);
			this.btn_Search.TabIndex = 2;
			this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// lb_Weight
			// 
			this.lb_Weight.AutoSize = true;
			this.lb_Weight.Location = new System.Drawing.Point(227, 137);
			this.lb_Weight.Name = "lb_Weight";
			this.lb_Weight.Size = new System.Drawing.Size(59, 13);
			this.lb_Weight.TabIndex = 26;
			this.lb_Weight.Text = "Qtde/Peso";
			// 
			// tb_Weight
			// 
			this.tb_Weight.Location = new System.Drawing.Point(230, 154);
			this.tb_Weight.Name = "tb_Weight";
			this.tb_Weight.Size = new System.Drawing.Size(100, 20);
			this.tb_Weight.TabIndex = 8;
			this.tb_Weight.Text = "0";
			// 
			// lb_Color
			// 
			this.lb_Color.AutoSize = true;
			this.lb_Color.Location = new System.Drawing.Point(121, 137);
			this.lb_Color.Name = "lb_Color";
			this.lb_Color.Size = new System.Drawing.Size(23, 13);
			this.lb_Color.TabIndex = 24;
			this.lb_Color.Text = "Cor";
			// 
			// tb_Color
			// 
			this.tb_Color.Location = new System.Drawing.Point(124, 154);
			this.tb_Color.Name = "tb_Color";
			this.tb_Color.Size = new System.Drawing.Size(100, 20);
			this.tb_Color.TabIndex = 7;
			// 
			// lb_Size
			// 
			this.lb_Size.AutoSize = true;
			this.lb_Size.Location = new System.Drawing.Point(15, 137);
			this.lb_Size.Name = "lb_Size";
			this.lb_Size.Size = new System.Drawing.Size(52, 13);
			this.lb_Size.TabIndex = 22;
			this.lb_Size.Text = "Tamanho";
			// 
			// tb_Size
			// 
			this.tb_Size.Location = new System.Drawing.Point(18, 154);
			this.tb_Size.Name = "tb_Size";
			this.tb_Size.Size = new System.Drawing.Size(100, 20);
			this.tb_Size.TabIndex = 6;
			// 
			// tb_Price
			// 
			this.tb_Price.Controls.Add(this.tb_UpdatedAt);
			this.tb_Price.Controls.Add(this.lb_UpdatedAt);
			this.tb_Price.Controls.Add(this.tb_CreatedAt);
			this.tb_Price.Controls.Add(this.lb_CreatedAt);
			this.tb_Price.Controls.Add(this.lb_Stock);
			this.tb_Price.Controls.Add(this.tb_Stock);
			this.tb_Price.Controls.Add(this.button1);
			this.tb_Price.Controls.Add(this.tb_LastPurchase);
			this.tb_Price.Controls.Add(this.lb_LastPurchase);
			this.tb_Price.Controls.Add(this.tb_ProviderID);
			this.tb_Price.Controls.Add(this.tb_ProviderName);
			this.tb_Price.Controls.Add(this.lb_ProviderID);
			this.tb_Price.Controls.Add(this.lb_ProviderName);
			this.tb_Price.Controls.Add(this.lb_Purchase);
			this.tb_Price.Controls.Add(this.tb_Sell);
			this.tb_Price.Controls.Add(this.tb_Purchase);
			this.tb_Price.Controls.Add(this.lb_Sell);
			this.tb_Price.Controls.Add(this.lb_MarkUp);
			this.tb_Price.Controls.Add(this.tb_MarkUp);
			this.tb_Price.Location = new System.Drawing.Point(4, 22);
			this.tb_Price.Name = "tb_Price";
			this.tb_Price.Padding = new System.Windows.Forms.Padding(3);
			this.tb_Price.Size = new System.Drawing.Size(373, 187);
			this.tb_Price.TabIndex = 1;
			this.tb_Price.Text = "Preço";
			this.tb_Price.UseVisualStyleBackColor = true;
			// 
			// tb_UpdatedAt
			// 
			this.tb_UpdatedAt.Location = new System.Drawing.Point(131, 155);
			this.tb_UpdatedAt.Name = "tb_UpdatedAt";
			this.tb_UpdatedAt.ReadOnly = true;
			this.tb_UpdatedAt.Size = new System.Drawing.Size(100, 20);
			this.tb_UpdatedAt.TabIndex = 38;
			this.tb_UpdatedAt.Text = "00/00/0000";
			// 
			// lb_UpdatedAt
			// 
			this.lb_UpdatedAt.AutoSize = true;
			this.lb_UpdatedAt.Location = new System.Drawing.Point(128, 138);
			this.lb_UpdatedAt.Name = "lb_UpdatedAt";
			this.lb_UpdatedAt.Size = new System.Drawing.Size(78, 13);
			this.lb_UpdatedAt.TabIndex = 40;
			this.lb_UpdatedAt.Text = "Data Alteração";
			// 
			// tb_CreatedAt
			// 
			this.tb_CreatedAt.Location = new System.Drawing.Point(25, 155);
			this.tb_CreatedAt.Name = "tb_CreatedAt";
			this.tb_CreatedAt.ReadOnly = true;
			this.tb_CreatedAt.Size = new System.Drawing.Size(100, 20);
			this.tb_CreatedAt.TabIndex = 37;
			this.tb_CreatedAt.Text = "00/00/0000";
			// 
			// lb_CreatedAt
			// 
			this.lb_CreatedAt.AutoSize = true;
			this.lb_CreatedAt.Location = new System.Drawing.Point(22, 138);
			this.lb_CreatedAt.Name = "lb_CreatedAt";
			this.lb_CreatedAt.Size = new System.Drawing.Size(69, 13);
			this.lb_CreatedAt.TabIndex = 39;
			this.lb_CreatedAt.Text = "Data Criação";
			// 
			// lb_Stock
			// 
			this.lb_Stock.AutoSize = true;
			this.lb_Stock.Location = new System.Drawing.Point(22, 51);
			this.lb_Stock.Name = "lb_Stock";
			this.lb_Stock.Size = new System.Drawing.Size(46, 13);
			this.lb_Stock.TabIndex = 36;
			this.lb_Stock.Text = "Estoque";
			// 
			// tb_Stock
			// 
			this.tb_Stock.Location = new System.Drawing.Point(25, 68);
			this.tb_Stock.Name = "tb_Stock";
			this.tb_Stock.Size = new System.Drawing.Size(100, 20);
			this.tb_Stock.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.button1.Location = new System.Drawing.Point(313, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(18, 20);
			this.button1.TabIndex = 35;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tb_LastPurchase
			// 
			this.tb_LastPurchase.Location = new System.Drawing.Point(131, 68);
			this.tb_LastPurchase.Name = "tb_LastPurchase";
			this.tb_LastPurchase.ReadOnly = true;
			this.tb_LastPurchase.Size = new System.Drawing.Size(100, 20);
			this.tb_LastPurchase.TabIndex = 4;
			this.tb_LastPurchase.Text = "00/00/0000";
			// 
			// lb_LastPurchase
			// 
			this.lb_LastPurchase.AutoSize = true;
			this.lb_LastPurchase.Location = new System.Drawing.Point(128, 51);
			this.lb_LastPurchase.Name = "lb_LastPurchase";
			this.lb_LastPurchase.Size = new System.Drawing.Size(75, 13);
			this.lb_LastPurchase.TabIndex = 30;
			this.lb_LastPurchase.Text = "Ultima Compra";
			// 
			// tb_ProviderID
			// 
			this.tb_ProviderID.Location = new System.Drawing.Point(25, 108);
			this.tb_ProviderID.Name = "tb_ProviderID";
			this.tb_ProviderID.Size = new System.Drawing.Size(72, 20);
			this.tb_ProviderID.TabIndex = 5;
			this.tb_ProviderID.Text = "0";
			// 
			// tb_ProviderName
			// 
			this.tb_ProviderName.Location = new System.Drawing.Point(103, 108);
			this.tb_ProviderName.Name = "tb_ProviderName";
			this.tb_ProviderName.Size = new System.Drawing.Size(210, 20);
			this.tb_ProviderName.TabIndex = 6;
			// 
			// lb_ProviderID
			// 
			this.lb_ProviderID.AutoSize = true;
			this.lb_ProviderID.Location = new System.Drawing.Point(22, 91);
			this.lb_ProviderID.Name = "lb_ProviderID";
			this.lb_ProviderID.Size = new System.Drawing.Size(75, 13);
			this.lb_ProviderID.TabIndex = 28;
			this.lb_ProviderID.Text = "ID Fornecedor";
			// 
			// lb_ProviderName
			// 
			this.lb_ProviderName.AutoSize = true;
			this.lb_ProviderName.Location = new System.Drawing.Point(100, 91);
			this.lb_ProviderName.Name = "lb_ProviderName";
			this.lb_ProviderName.Size = new System.Drawing.Size(92, 13);
			this.lb_ProviderName.TabIndex = 26;
			this.lb_ProviderName.Text = "Nome Fornecedor";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Delete);
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.btn_Save);
			this.panel1.Controls.Add(this.btn_New);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 388);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 34);
			this.panel1.TabIndex = 34;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(97, 0);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 24);
			this.btn_Delete.TabIndex = 1;
			this.btn_Delete.Text = "Excluir";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(314, 0);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 24);
			this.btn_Close.TabIndex = 3;
			this.btn_Close.Text = "Fechar";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(233, 0);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 24);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Salvar";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_New
			// 
			this.btn_New.Location = new System.Drawing.Point(16, 0);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(75, 24);
			this.btn_New.TabIndex = 2;
			this.btn_New.Text = "Novo";
			this.btn_New.UseVisualStyleBackColor = true;
			this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
			// 
			// btn_ProfilePicture
			// 
			this.btn_ProfilePicture.Location = new System.Drawing.Point(140, 225);
			this.btn_ProfilePicture.Name = "btn_ProfilePicture";
			this.btn_ProfilePicture.Size = new System.Drawing.Size(127, 23);
			this.btn_ProfilePicture.TabIndex = 35;
			this.btn_ProfilePicture.Text = "Adicionar Foto";
			this.btn_ProfilePicture.UseVisualStyleBackColor = true;
			this.btn_ProfilePicture.Click += new System.EventHandler(this.btn_ProfilePicture_Click);
			// 
			// pb_User
			// 
			this.pb_User.Image = global::Rock_Solid.Properties.Resources.Profile;
			this.pb_User.Location = new System.Drawing.Point(140, 254);
			this.pb_User.Name = "pb_User";
			this.pb_User.Size = new System.Drawing.Size(127, 122);
			this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_User.TabIndex = 36;
			this.pb_User.TabStop = false;
			// 
			// frm_Product
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 422);
			this.Controls.Add(this.btn_ProfilePicture);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tc_Product);
			this.Controls.Add(this.pb_User);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Product";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Produtos";
			this.Load += new System.EventHandler(this.frm_Product_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Product_KeyPress);
			this.tc_Product.ResumeLayout(false);
			this.tp_Product.ResumeLayout(false);
			this.tp_Product.PerformLayout();
			this.tb_Price.ResumeLayout(false);
			this.tb_Price.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.Label lb_Description;
		private System.Windows.Forms.Label lb_Purchase;
		private System.Windows.Forms.Label lb_MarkUp;
		private System.Windows.Forms.Label lb_Sell;
		private System.Windows.Forms.Label lb_BarCode;
		private System.Windows.Forms.Label lb_Type;
		private System.Windows.Forms.Label lb_Name;
		private System.Windows.Forms.Label lb_LastPurchase;
		private System.Windows.Forms.Label lb_ProviderID;
		private System.Windows.Forms.Label lb_ProviderName;
		private System.Windows.Forms.Label lb_Weight;
		private System.Windows.Forms.Label lb_Color;
		private System.Windows.Forms.Label lb_Size;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Search;
		public System.Windows.Forms.TextBox tb_ID;
		public System.Windows.Forms.TextBox tb_Description;
		public System.Windows.Forms.TextBox tb_Purchase;
		public System.Windows.Forms.TextBox tb_MarkUp;
		public System.Windows.Forms.TextBox tb_Sell;
		public System.Windows.Forms.TextBox tb_BarCode;
		public System.Windows.Forms.TextBox tb_Type;
		public System.Windows.Forms.TextBox tb_Name;
		public System.Windows.Forms.TabControl tc_Product;
		public System.Windows.Forms.TabPage tp_Product;
		public System.Windows.Forms.TabPage tb_Price;
		public System.Windows.Forms.TextBox tb_LastPurchase;
		public System.Windows.Forms.TextBox tb_ProviderID;
		public System.Windows.Forms.TextBox tb_ProviderName;
		public System.Windows.Forms.TextBox tb_Weight;
		public System.Windows.Forms.TextBox tb_Color;
		public System.Windows.Forms.TextBox tb_Size;
		public System.Windows.Forms.Button btn_Delete;
		public System.Windows.Forms.Button btn_Close;
		public System.Windows.Forms.Button btn_Save;
		public System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Label lb_Stock;
		public System.Windows.Forms.TextBox tb_Stock;
		public System.Windows.Forms.TextBox tb_UpdatedAt;
		private System.Windows.Forms.Label lb_UpdatedAt;
		public System.Windows.Forms.TextBox tb_CreatedAt;
		private System.Windows.Forms.Label lb_CreatedAt;
		private System.Windows.Forms.Button btn_ProfilePicture;
		public System.Windows.Forms.PictureBox pb_User;
	}
}