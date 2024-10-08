namespace Rock_Solid
{
	partial class frm_Initial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Initial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Version = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_VersionTXT = new System.Windows.Forms.Label();
            this.lb_AccessText = new System.Windows.Forms.Label();
            this.lb_Access = new System.Windows.Forms.Label();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            this.ms_Initial = new System.Windows.Forms.MenuStrip();
            this.tsmi_Company = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Register = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_User = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Client = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Equipment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Query = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UserQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ClientQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ProductQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_EquipmentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SalesOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Financial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AccountsReceivable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AccountsPayable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.ms_Initial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lb_Version);
            this.panel1.Controls.Add(this.lb_UserName);
            this.panel1.Controls.Add(this.lb_User);
            this.panel1.Controls.Add(this.lb_VersionTXT);
            this.panel1.Controls.Add(this.lb_AccessText);
            this.panel1.Controls.Add(this.lb_Access);
            this.panel1.Controls.Add(this.pb_Login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 34);
            this.panel1.TabIndex = 0;
            // 
            // lb_Version
            // 
            this.lb_Version.AutoSize = true;
            this.lb_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Version.Location = new System.Drawing.Point(564, 6);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(0, 20);
            this.lb_Version.TabIndex = 6;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(239, 7);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(186, 20);
            this.lb_UserName.TabIndex = 4;
            this.lb_UserName.Text = "Nenhum Usuário Logado";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(172, 7);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(68, 20);
            this.lb_User.TabIndex = 3;
            this.lb_User.Text = "Usuário:";
            // 
            // lb_VersionTXT
            // 
            this.lb_VersionTXT.AutoSize = true;
            this.lb_VersionTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VersionTXT.Location = new System.Drawing.Point(501, 6);
            this.lb_VersionTXT.Name = "lb_VersionTXT";
            this.lb_VersionTXT.Size = new System.Drawing.Size(64, 20);
            this.lb_VersionTXT.TabIndex = 5;
            this.lb_VersionTXT.Text = "Versão:";
            // 
            // lb_AccessText
            // 
            this.lb_AccessText.AutoSize = true;
            this.lb_AccessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccessText.Location = new System.Drawing.Point(109, 7);
            this.lb_AccessText.Name = "lb_AccessText";
            this.lb_AccessText.Size = new System.Drawing.Size(18, 20);
            this.lb_AccessText.TabIndex = 2;
            this.lb_AccessText.Text = "0";
            // 
            // lb_Access
            // 
            this.lb_Access.AutoSize = true;
            this.lb_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Access.Location = new System.Drawing.Point(45, 7);
            this.lb_Access.Name = "lb_Access";
            this.lb_Access.Size = new System.Drawing.Size(66, 20);
            this.lb_Access.TabIndex = 1;
            this.lb_Access.Text = "Acesso:";
            // 
            // pb_Login
            // 
            this.pb_Login.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login.Image")));
            this.pb_Login.Location = new System.Drawing.Point(12, 4);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(27, 22);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 0;
            this.pb_Login.TabStop = false;
            // 
            // ms_Initial
            // 
            this.ms_Initial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Company,
            this.tsmi_Register,
            this.tsmi_Query,
            this.tsmi_Sale,
            this.tsmi_Financial,
            this.tsmi_LogIn});
            this.ms_Initial.Location = new System.Drawing.Point(0, 0);
            this.ms_Initial.Name = "ms_Initial";
            this.ms_Initial.Size = new System.Drawing.Size(1264, 59);
            this.ms_Initial.TabIndex = 1;
            this.ms_Initial.Text = "menuStrip1";
            // 
            // tsmi_Company
            // 
            this.tsmi_Company.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_Company.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.tsmi_Company.Name = "tsmi_Company";
            this.tsmi_Company.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_Company.Size = new System.Drawing.Size(104, 55);
            this.tsmi_Company.Text = "Empresa";
            this.tsmi_Company.Click += new System.EventHandler(this.tsmi_Company_Click);
            // 
            // tsmi_Register
            // 
            this.tsmi_Register.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_User,
            this.tsmi_Client,
            this.tsmi_Product,
            this.tsmi_Supplier,
            this.tsmi_Equipment});
            this.tsmi_Register.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_Register.Name = "tsmi_Register";
            this.tsmi_Register.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_Register.Size = new System.Drawing.Size(113, 55);
            this.tsmi_Register.Text = "Cadastros";
            // 
            // tsmi_User
            // 
            this.tsmi_User.Name = "tsmi_User";
            this.tsmi_User.Size = new System.Drawing.Size(172, 26);
            this.tsmi_User.Text = "Usuário";
            this.tsmi_User.Click += new System.EventHandler(this.tsmi_User_Click);
            // 
            // tsmi_Client
            // 
            this.tsmi_Client.Name = "tsmi_Client";
            this.tsmi_Client.Size = new System.Drawing.Size(172, 26);
            this.tsmi_Client.Text = "Cliente";
            this.tsmi_Client.Click += new System.EventHandler(this.tsmi_Client_Click);
            // 
            // tsmi_Product
            // 
            this.tsmi_Product.Name = "tsmi_Product";
            this.tsmi_Product.Size = new System.Drawing.Size(172, 26);
            this.tsmi_Product.Text = "Produto";
            this.tsmi_Product.Click += new System.EventHandler(this.tsmi_Product_Click);
            // 
            // tsmi_Supplier
            // 
            this.tsmi_Supplier.Name = "tsmi_Supplier";
            this.tsmi_Supplier.Size = new System.Drawing.Size(172, 26);
            this.tsmi_Supplier.Text = "Fornecedor";
            this.tsmi_Supplier.Click += new System.EventHandler(this.tsmi_Supplier_Click);
            // 
            // tsmi_Equipment
            // 
            this.tsmi_Equipment.Name = "tsmi_Equipment";
            this.tsmi_Equipment.Size = new System.Drawing.Size(172, 26);
            this.tsmi_Equipment.Text = "Equipamento";
            this.tsmi_Equipment.Click += new System.EventHandler(this.tsmi_Equipment_Click);
            // 
            // tsmi_Query
            // 
            this.tsmi_Query.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_UserQuery,
            this.tsmi_ClientQuery,
            this.tsmi_ProductQuery,
            this.tsmi_SupplierList,
            this.tsmi_EquipmentList});
            this.tsmi_Query.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_Query.Name = "tsmi_Query";
            this.tsmi_Query.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_Query.Size = new System.Drawing.Size(112, 55);
            this.tsmi_Query.Text = "Consultas";
            // 
            // tsmi_UserQuery
            // 
            this.tsmi_UserQuery.Name = "tsmi_UserQuery";
            this.tsmi_UserQuery.Size = new System.Drawing.Size(172, 26);
            this.tsmi_UserQuery.Text = "Usuários";
            this.tsmi_UserQuery.Click += new System.EventHandler(this.tsmi_UserQuery_Click);
            // 
            // tsmi_ClientQuery
            // 
            this.tsmi_ClientQuery.Name = "tsmi_ClientQuery";
            this.tsmi_ClientQuery.Size = new System.Drawing.Size(172, 26);
            this.tsmi_ClientQuery.Text = "Clientes";
            this.tsmi_ClientQuery.Click += new System.EventHandler(this.tsmi_ClientQuery_Click);
            // 
            // tsmi_ProductQuery
            // 
            this.tsmi_ProductQuery.Name = "tsmi_ProductQuery";
            this.tsmi_ProductQuery.Size = new System.Drawing.Size(172, 26);
            this.tsmi_ProductQuery.Text = "Produtos";
            this.tsmi_ProductQuery.Click += new System.EventHandler(this.tsmi_ProductQuery_Click);
            // 
            // tsmi_SupplierList
            // 
            this.tsmi_SupplierList.Name = "tsmi_SupplierList";
            this.tsmi_SupplierList.Size = new System.Drawing.Size(172, 26);
            this.tsmi_SupplierList.Text = "Fornecedor";
            // 
            // tsmi_EquipmentList
            // 
            this.tsmi_EquipmentList.Name = "tsmi_EquipmentList";
            this.tsmi_EquipmentList.Size = new System.Drawing.Size(172, 26);
            this.tsmi_EquipmentList.Text = "Equipamento";
            // 
            // tsmi_Sale
            // 
            this.tsmi_Sale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_SalesOrder});
            this.tsmi_Sale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_Sale.Name = "tsmi_Sale";
            this.tsmi_Sale.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_Sale.Size = new System.Drawing.Size(94, 55);
            this.tsmi_Sale.Text = "Vendas";
            // 
            // tsmi_SalesOrder
            // 
            this.tsmi_SalesOrder.Name = "tsmi_SalesOrder";
            this.tsmi_SalesOrder.Size = new System.Drawing.Size(202, 26);
            this.tsmi_SalesOrder.Text = "Pedidos de Venda";
            this.tsmi_SalesOrder.Click += new System.EventHandler(this.tsmi_SalesOrder_Click);
            // 
            // tsmi_Financial
            // 
            this.tsmi_Financial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AccountsReceivable,
            this.tsmi_AccountsPayable});
            this.tsmi_Financial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_Financial.Name = "tsmi_Financial";
            this.tsmi_Financial.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_Financial.Size = new System.Drawing.Size(116, 55);
            this.tsmi_Financial.Text = "Financeiro";
            // 
            // tsmi_AccountsReceivable
            // 
            this.tsmi_AccountsReceivable.Name = "tsmi_AccountsReceivable";
            this.tsmi_AccountsReceivable.Size = new System.Drawing.Size(200, 26);
            this.tsmi_AccountsReceivable.Text = "Contas a Receber";
            this.tsmi_AccountsReceivable.Click += new System.EventHandler(this.tsmi_AccountsReceivable_Click);
            // 
            // tsmi_AccountsPayable
            // 
            this.tsmi_AccountsPayable.Name = "tsmi_AccountsPayable";
            this.tsmi_AccountsPayable.Size = new System.Drawing.Size(200, 26);
            this.tsmi_AccountsPayable.Text = "Contas a Pagar";
            this.tsmi_AccountsPayable.Click += new System.EventHandler(this.tsmi_AccountsPayable_Click);
            // 
            // tsmi_LogIn
            // 
            this.tsmi_LogIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_UserChange,
            this.tsmi_LogOff});
            this.tsmi_LogIn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmi_LogIn.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.tsmi_LogIn.Name = "tsmi_LogIn";
            this.tsmi_LogIn.Padding = new System.Windows.Forms.Padding(15);
            this.tsmi_LogIn.Size = new System.Drawing.Size(83, 55);
            this.tsmi_LogIn.Text = "Login";
            // 
            // tsmi_UserChange
            // 
            this.tsmi_UserChange.Name = "tsmi_UserChange";
            this.tsmi_UserChange.Size = new System.Drawing.Size(181, 26);
            this.tsmi_UserChange.Text = "Trocar Usuário";
            this.tsmi_UserChange.Click += new System.EventHandler(this.tsmi_UserChange_Click);
            // 
            // tsmi_LogOff
            // 
            this.tsmi_LogOff.Name = "tsmi_LogOff";
            this.tsmi_LogOff.Size = new System.Drawing.Size(181, 26);
            this.tsmi_LogOff.Text = "Logoff";
            this.tsmi_LogOff.Click += new System.EventHandler(this.tsmi_LogOff_Click);
            // 
            // frm_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ms_Initial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms_Initial;
            this.Name = "frm_Initial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Solid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ms_Initial.ResumeLayout(false);
            this.ms_Initial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_User;
		private System.Windows.Forms.Label lb_Access;
		public System.Windows.Forms.PictureBox pb_Login;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lb_UserName;
		public System.Windows.Forms.Label lb_AccessText;
        private System.Windows.Forms.MenuStrip ms_Initial;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogIn;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UserChange;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogOff;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Query;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ClientQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Register;
        private System.Windows.Forms.ToolStripMenuItem tsmi_User;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Client;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Product;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Equipment;
		public System.Windows.Forms.Label lb_Version;
		private System.Windows.Forms.Label lb_VersionTXT;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Sale;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Financial;
		private System.Windows.Forms.ToolStripMenuItem tsmi_AccountsReceivable;
		private System.Windows.Forms.ToolStripMenuItem tsmi_AccountsPayable;
		private System.Windows.Forms.ToolStripMenuItem tsmi_SalesOrder;
		private System.Windows.Forms.ToolStripMenuItem tsmi_UserQuery;
		private System.Windows.Forms.ToolStripMenuItem tsmi_ProductQuery;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Supplier;
		private System.Windows.Forms.ToolStripMenuItem tsmi_Company;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SupplierList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_EquipmentList;
    }
}

