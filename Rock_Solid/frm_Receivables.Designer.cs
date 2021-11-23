
namespace Rock_Solid
{
	partial class frm_Receivables
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tc_SalesOrder = new System.Windows.Forms.TabControl();
            this.tp_Product = new System.Windows.Forms.TabPage();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.tb_ProductID = new System.Windows.Forms.TextBox();
            this.dgv_OrderItem = new System.Windows.Forms.DataGridView();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tc_SalesOrder.SuspendLayout();
            this.tp_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItem)).BeginInit();
            this.tp_ExpirationDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDueDate)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Rock_Solid.Properties.Resources.Search_Button;
            this.button1.Location = new System.Drawing.Point(438, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 20);
            this.button1.TabIndex = 76;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(85, 28);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(353, 20);
            this.tb_Name.TabIndex = 75;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(82, 12);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(39, 13);
            this.lb_Name.TabIndex = 74;
            this.lb_Name.Text = "Cliente";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(9, 12);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(40, 13);
            this.lb_ID.TabIndex = 73;
            this.lb_ID.Text = "Código";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 28);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(67, 20);
            this.tb_ID.TabIndex = 72;
            // 
            // tc_SalesOrder
            // 
            this.tc_SalesOrder.Controls.Add(this.tp_Product);
            this.tc_SalesOrder.Controls.Add(this.tp_ExpirationDate);
            this.tc_SalesOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_SalesOrder.Location = new System.Drawing.Point(0, 76);
            this.tc_SalesOrder.Name = "tc_SalesOrder";
            this.tc_SalesOrder.SelectedIndex = 0;
            this.tc_SalesOrder.Size = new System.Drawing.Size(681, 347);
            this.tc_SalesOrder.TabIndex = 77;
            // 
            // tp_Product
            // 
            this.tp_Product.BackColor = System.Drawing.SystemColors.Control;
            this.tp_Product.Controls.Add(this.label1);
            this.tp_Product.Controls.Add(this.textBox1);
            this.tp_Product.Controls.Add(this.button2);
            this.tp_Product.Controls.Add(this.lb_ProductID);
            this.tp_Product.Controls.Add(this.tb_ProductID);
            this.tp_Product.Controls.Add(this.dgv_OrderItem);
            this.tp_Product.Controls.Add(this.lb_BarCode);
            this.tp_Product.Controls.Add(this.tb_BarCode);
            this.tp_Product.Location = new System.Drawing.Point(4, 22);
            this.tp_Product.Name = "tp_Product";
            this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Product.Size = new System.Drawing.Size(673, 321);
            this.tp_Product.TabIndex = 0;
            this.tp_Product.Text = "Documentos para Baixa";
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(11, 14);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(71, 13);
            this.lb_ProductID.TabIndex = 40;
            this.lb_ProductID.Text = "Baixar Parcial";
            // 
            // tb_ProductID
            // 
            this.tb_ProductID.Location = new System.Drawing.Point(11, 33);
            this.tb_ProductID.Name = "tb_ProductID";
            this.tb_ProductID.Size = new System.Drawing.Size(106, 20);
            this.tb_ProductID.TabIndex = 39;
            // 
            // dgv_OrderItem
            // 
            this.dgv_OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.dgv_OrderItem.Location = new System.Drawing.Point(11, 101);
            this.dgv_OrderItem.Name = "dgv_OrderItem";
            this.dgv_OrderItem.Size = new System.Drawing.Size(650, 212);
            this.dgv_OrderItem.TabIndex = 38;
            // 
            // lb_BarCode
            // 
            this.lb_BarCode.AutoSize = true;
            this.lb_BarCode.Location = new System.Drawing.Point(124, 14);
            this.lb_BarCode.Name = "lb_BarCode";
            this.lb_BarCode.Size = new System.Drawing.Size(66, 13);
            this.lb_BarCode.TabIndex = 11;
            this.lb_BarCode.Text = "Selecionado";
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
            this.tp_ExpirationDate.Size = new System.Drawing.Size(673, 321);
            this.tp_ExpirationDate.TabIndex = 1;
            this.tp_ExpirationDate.Text = "Todos os Documentos";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Baixar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 42;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selecionado";
            this.Selected.Name = "Selected";
            // 
            // frm_Receivables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 423);
            this.Controls.Add(this.tc_SalesOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.tb_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_Receivables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
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

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        public System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TabControl tc_SalesOrder;
        private System.Windows.Forms.TabPage tp_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.TextBox tb_ProductID;
        private System.Windows.Forms.DataGridView dgv_OrderItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Label lb_BarCode;
        private System.Windows.Forms.TextBox tb_BarCode;
        private System.Windows.Forms.TabPage tp_ExpirationDate;
        private System.Windows.Forms.DataGridView dgv_OrderDueDate;
        private System.Windows.Forms.Button btn_DelExpiration;
        private System.Windows.Forms.Button btn_AddExpiration;
        private System.Windows.Forms.ComboBox cb_PaymentMethod;
        private System.Windows.Forms.DateTimePicker dtp_ExpirationData;
        private System.Windows.Forms.Label lb_DocNumber;
        private System.Windows.Forms.TextBox tb_DocNumber;
        private System.Windows.Forms.Label lb_PaymentMethod;
        private System.Windows.Forms.Label lb_Installments;
        private System.Windows.Forms.TextBox tb_Installments;
        private System.Windows.Forms.Label lb_ExpirationData;
    }
}