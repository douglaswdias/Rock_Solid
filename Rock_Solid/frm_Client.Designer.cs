namespace Rock_Solid
{
	partial class frm_Client
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
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.lb_ID = new System.Windows.Forms.Label();
			this.lb_Name = new System.Windows.Forms.Label();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.lb_Address = new System.Windows.Forms.Label();
			this.tb_Address = new System.Windows.Forms.TextBox();
			this.lb_Number = new System.Windows.Forms.Label();
			this.tb_Number = new System.Windows.Forms.MaskedTextBox();
			this.tb_Neighborhood = new System.Windows.Forms.TextBox();
			this.lb_Neighborhood = new System.Windows.Forms.Label();
			this.lb_State = new System.Windows.Forms.Label();
			this.lb_CPF = new System.Windows.Forms.Label();
			this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
			this.rb_PhysicalPerson = new System.Windows.Forms.RadioButton();
			this.rb_LegalPerson = new System.Windows.Forms.RadioButton();
			this.tb_City = new System.Windows.Forms.TextBox();
			this.lb_City = new System.Windows.Forms.Label();
			this.lb_Phone = new System.Windows.Forms.Label();
			this.tb_Phone = new System.Windows.Forms.MaskedTextBox();
			this.tb_Cel = new System.Windows.Forms.MaskedTextBox();
			this.lb_Cel = new System.Windows.Forms.Label();
			this.cb_State = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(12, 19);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(61, 20);
			this.tb_ID.TabIndex = 0;
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Location = new System.Drawing.Point(9, 3);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(40, 13);
			this.lb_ID.TabIndex = 1;
			this.lb_ID.Text = "Código";
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.Location = new System.Drawing.Point(86, 3);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(82, 13);
			this.lb_Name.TabIndex = 2;
			this.lb_Name.Text = "Nome Completo";
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(79, 19);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(376, 20);
			this.tb_Name.TabIndex = 3;
			// 
			// lb_Address
			// 
			this.lb_Address.AutoSize = true;
			this.lb_Address.Location = new System.Drawing.Point(9, 41);
			this.lb_Address.Name = "lb_Address";
			this.lb_Address.Size = new System.Drawing.Size(53, 13);
			this.lb_Address.TabIndex = 4;
			this.lb_Address.Text = "Endereço";
			// 
			// tb_Address
			// 
			this.tb_Address.Location = new System.Drawing.Point(12, 58);
			this.tb_Address.Name = "tb_Address";
			this.tb_Address.Size = new System.Drawing.Size(366, 20);
			this.tb_Address.TabIndex = 5;
			// 
			// lb_Number
			// 
			this.lb_Number.AutoSize = true;
			this.lb_Number.Location = new System.Drawing.Point(384, 42);
			this.lb_Number.Name = "lb_Number";
			this.lb_Number.Size = new System.Drawing.Size(44, 13);
			this.lb_Number.TabIndex = 6;
			this.lb_Number.Text = "Número";
			// 
			// tb_Number
			// 
			this.tb_Number.Location = new System.Drawing.Point(388, 58);
			this.tb_Number.Mask = "00000";
			this.tb_Number.Name = "tb_Number";
			this.tb_Number.Size = new System.Drawing.Size(67, 20);
			this.tb_Number.TabIndex = 7;
			this.tb_Number.ValidatingType = typeof(int);
			// 
			// tb_Neighborhood
			// 
			this.tb_Neighborhood.Location = new System.Drawing.Point(12, 98);
			this.tb_Neighborhood.Name = "tb_Neighborhood";
			this.tb_Neighborhood.Size = new System.Drawing.Size(366, 20);
			this.tb_Neighborhood.TabIndex = 9;
			// 
			// lb_Neighborhood
			// 
			this.lb_Neighborhood.AutoSize = true;
			this.lb_Neighborhood.Location = new System.Drawing.Point(9, 81);
			this.lb_Neighborhood.Name = "lb_Neighborhood";
			this.lb_Neighborhood.Size = new System.Drawing.Size(34, 13);
			this.lb_Neighborhood.TabIndex = 8;
			this.lb_Neighborhood.Text = "Bairro";
			// 
			// lb_State
			// 
			this.lb_State.AutoSize = true;
			this.lb_State.Location = new System.Drawing.Point(385, 122);
			this.lb_State.Name = "lb_State";
			this.lb_State.Size = new System.Drawing.Size(40, 13);
			this.lb_State.TabIndex = 11;
			this.lb_State.Text = "Estado";
			// 
			// lb_CPF
			// 
			this.lb_CPF.AutoSize = true;
			this.lb_CPF.Location = new System.Drawing.Point(9, 161);
			this.lb_CPF.Name = "lb_CPF";
			this.lb_CPF.Size = new System.Drawing.Size(27, 13);
			this.lb_CPF.TabIndex = 12;
			this.lb_CPF.Text = "CPF";
			// 
			// tb_CPF
			// 
			this.tb_CPF.Location = new System.Drawing.Point(12, 178);
			this.tb_CPF.Mask = "00.000.000-0";
			this.tb_CPF.Name = "tb_CPF";
			this.tb_CPF.Size = new System.Drawing.Size(74, 20);
			this.tb_CPF.TabIndex = 13;
			// 
			// rb_PhysicalPerson
			// 
			this.rb_PhysicalPerson.AutoSize = true;
			this.rb_PhysicalPerson.Checked = true;
			this.rb_PhysicalPerson.Location = new System.Drawing.Point(476, 20);
			this.rb_PhysicalPerson.Name = "rb_PhysicalPerson";
			this.rb_PhysicalPerson.Size = new System.Drawing.Size(92, 17);
			this.rb_PhysicalPerson.TabIndex = 14;
			this.rb_PhysicalPerson.TabStop = true;
			this.rb_PhysicalPerson.Text = "Pessoa Física";
			this.rb_PhysicalPerson.UseVisualStyleBackColor = true;
			this.rb_PhysicalPerson.Click += new System.EventHandler(this.rb_PhysicalPerson_Click);
			// 
			// rb_LegalPerson
			// 
			this.rb_LegalPerson.AutoSize = true;
			this.rb_LegalPerson.Location = new System.Drawing.Point(476, 44);
			this.rb_LegalPerson.Name = "rb_LegalPerson";
			this.rb_LegalPerson.Size = new System.Drawing.Size(101, 17);
			this.rb_LegalPerson.TabIndex = 15;
			this.rb_LegalPerson.Text = "Pessoa Jurídica";
			this.rb_LegalPerson.UseVisualStyleBackColor = true;
			this.rb_LegalPerson.Click += new System.EventHandler(this.rb_LegalPerson_Click);
			// 
			// tb_City
			// 
			this.tb_City.Location = new System.Drawing.Point(12, 138);
			this.tb_City.Name = "tb_City";
			this.tb_City.Size = new System.Drawing.Size(366, 20);
			this.tb_City.TabIndex = 17;
			// 
			// lb_City
			// 
			this.lb_City.AutoSize = true;
			this.lb_City.Location = new System.Drawing.Point(9, 121);
			this.lb_City.Name = "lb_City";
			this.lb_City.Size = new System.Drawing.Size(40, 13);
			this.lb_City.TabIndex = 16;
			this.lb_City.Text = "Cidade";
			// 
			// lb_Phone
			// 
			this.lb_Phone.AutoSize = true;
			this.lb_Phone.Location = new System.Drawing.Point(9, 206);
			this.lb_Phone.Name = "lb_Phone";
			this.lb_Phone.Size = new System.Drawing.Size(49, 13);
			this.lb_Phone.TabIndex = 18;
			this.lb_Phone.Text = "Telefone";
			// 
			// tb_Phone
			// 
			this.tb_Phone.Location = new System.Drawing.Point(12, 222);
			this.tb_Phone.Mask = "(99)9999-9999";
			this.tb_Phone.Name = "tb_Phone";
			this.tb_Phone.Size = new System.Drawing.Size(100, 20);
			this.tb_Phone.TabIndex = 19;
			// 
			// tb_Cel
			// 
			this.tb_Cel.Location = new System.Drawing.Point(122, 222);
			this.tb_Cel.Mask = "(99)99999-9999";
			this.tb_Cel.Name = "tb_Cel";
			this.tb_Cel.Size = new System.Drawing.Size(100, 20);
			this.tb_Cel.TabIndex = 21;
			// 
			// lb_Cel
			// 
			this.lb_Cel.AutoSize = true;
			this.lb_Cel.Location = new System.Drawing.Point(119, 206);
			this.lb_Cel.Name = "lb_Cel";
			this.lb_Cel.Size = new System.Drawing.Size(39, 13);
			this.lb_Cel.TabIndex = 20;
			this.lb_Cel.Text = "Celular";
			// 
			// cb_State
			// 
			this.cb_State.FormattingEnabled = true;
			this.cb_State.Location = new System.Drawing.Point(384, 138);
			this.cb_State.Name = "cb_State";
			this.cb_State.Size = new System.Drawing.Size(71, 21);
			this.cb_State.TabIndex = 22;
			// 
			// frm_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 481);
			this.Controls.Add(this.cb_State);
			this.Controls.Add(this.tb_Cel);
			this.Controls.Add(this.lb_Cel);
			this.Controls.Add(this.tb_Phone);
			this.Controls.Add(this.lb_Phone);
			this.Controls.Add(this.tb_City);
			this.Controls.Add(this.lb_City);
			this.Controls.Add(this.rb_LegalPerson);
			this.Controls.Add(this.rb_PhysicalPerson);
			this.Controls.Add(this.tb_CPF);
			this.Controls.Add(this.lb_CPF);
			this.Controls.Add(this.lb_State);
			this.Controls.Add(this.tb_Neighborhood);
			this.Controls.Add(this.lb_Neighborhood);
			this.Controls.Add(this.tb_Number);
			this.Controls.Add(this.lb_Number);
			this.Controls.Add(this.tb_Address);
			this.Controls.Add(this.lb_Address);
			this.Controls.Add(this.tb_Name);
			this.Controls.Add(this.lb_Name);
			this.Controls.Add(this.lb_ID);
			this.Controls.Add(this.tb_ID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Client";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Clientes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.Label lb_Name;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.Label lb_Address;
		private System.Windows.Forms.TextBox tb_Address;
		private System.Windows.Forms.Label lb_Number;
		private System.Windows.Forms.MaskedTextBox tb_Number;
		private System.Windows.Forms.TextBox tb_Neighborhood;
		private System.Windows.Forms.Label lb_Neighborhood;
		private System.Windows.Forms.Label lb_State;
		private System.Windows.Forms.Label lb_CPF;
		private System.Windows.Forms.MaskedTextBox tb_CPF;
		private System.Windows.Forms.RadioButton rb_PhysicalPerson;
		private System.Windows.Forms.RadioButton rb_LegalPerson;
		private System.Windows.Forms.TextBox tb_City;
		private System.Windows.Forms.Label lb_City;
		private System.Windows.Forms.Label lb_Phone;
		private System.Windows.Forms.MaskedTextBox tb_Phone;
		private System.Windows.Forms.MaskedTextBox tb_Cel;
		private System.Windows.Forms.Label lb_Cel;
		private System.Windows.Forms.ComboBox cb_State;
	}
}