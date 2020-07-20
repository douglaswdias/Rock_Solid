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
			this.btn_Search = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_New = new System.Windows.Forms.Button();
			this.tb_PostCode = new System.Windows.Forms.MaskedTextBox();
			this.lb_PostCode = new System.Windows.Forms.Label();
			this.tb_Email = new System.Windows.Forms.TextBox();
			this.lb_Email = new System.Windows.Forms.Label();
			this.pb_User = new System.Windows.Forms.PictureBox();
			this.clb_Phone = new System.Windows.Forms.CheckedListBox();
			this.clb_Cel = new System.Windows.Forms.CheckedListBox();
			this.lb_ProfileImg = new System.Windows.Forms.Label();
			this.tb_ProfileImg = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(10, 28);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(67, 20);
			this.tb_ID.TabIndex = 0;
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Location = new System.Drawing.Point(7, 12);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(40, 13);
			this.lb_ID.TabIndex = 1;
			this.lb_ID.Text = "Código";
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.Location = new System.Drawing.Point(84, 12);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(82, 13);
			this.lb_Name.TabIndex = 2;
			this.lb_Name.Text = "Nome Completo";
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(83, 28);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(377, 20);
			this.tb_Name.TabIndex = 3;
			// 
			// lb_Address
			// 
			this.lb_Address.AutoSize = true;
			this.lb_Address.Location = new System.Drawing.Point(84, 50);
			this.lb_Address.Name = "lb_Address";
			this.lb_Address.Size = new System.Drawing.Size(53, 13);
			this.lb_Address.TabIndex = 4;
			this.lb_Address.Text = "Endereço";
			// 
			// tb_Address
			// 
			this.tb_Address.Location = new System.Drawing.Point(83, 67);
			this.tb_Address.Name = "tb_Address";
			this.tb_Address.Size = new System.Drawing.Size(377, 20);
			this.tb_Address.TabIndex = 5;
			// 
			// lb_Number
			// 
			this.lb_Number.AutoSize = true;
			this.lb_Number.Location = new System.Drawing.Point(7, 93);
			this.lb_Number.Name = "lb_Number";
			this.lb_Number.Size = new System.Drawing.Size(44, 13);
			this.lb_Number.TabIndex = 6;
			this.lb_Number.Text = "Número";
			// 
			// tb_Number
			// 
			this.tb_Number.Location = new System.Drawing.Point(10, 109);
			this.tb_Number.Mask = "0000000000";
			this.tb_Number.Name = "tb_Number";
			this.tb_Number.Size = new System.Drawing.Size(67, 20);
			this.tb_Number.TabIndex = 7;
			this.tb_Number.ValidatingType = typeof(int);
			// 
			// tb_Neighborhood
			// 
			this.tb_Neighborhood.Location = new System.Drawing.Point(83, 109);
			this.tb_Neighborhood.Name = "tb_Neighborhood";
			this.tb_Neighborhood.Size = new System.Drawing.Size(377, 20);
			this.tb_Neighborhood.TabIndex = 9;
			// 
			// lb_Neighborhood
			// 
			this.lb_Neighborhood.AutoSize = true;
			this.lb_Neighborhood.Location = new System.Drawing.Point(84, 92);
			this.lb_Neighborhood.Name = "lb_Neighborhood";
			this.lb_Neighborhood.Size = new System.Drawing.Size(34, 13);
			this.lb_Neighborhood.TabIndex = 8;
			this.lb_Neighborhood.Text = "Bairro";
			// 
			// lb_State
			// 
			this.lb_State.AutoSize = true;
			this.lb_State.Location = new System.Drawing.Point(383, 139);
			this.lb_State.Name = "lb_State";
			this.lb_State.Size = new System.Drawing.Size(40, 13);
			this.lb_State.TabIndex = 11;
			this.lb_State.Text = "Estado";
			// 
			// lb_CPF
			// 
			this.lb_CPF.AutoSize = true;
			this.lb_CPF.Location = new System.Drawing.Point(7, 184);
			this.lb_CPF.Name = "lb_CPF";
			this.lb_CPF.Size = new System.Drawing.Size(27, 13);
			this.lb_CPF.TabIndex = 12;
			this.lb_CPF.Text = "CPF";
			// 
			// tb_CPF
			// 
			this.tb_CPF.Location = new System.Drawing.Point(10, 201);
			this.tb_CPF.Mask = "00.000.000-0";
			this.tb_CPF.Name = "tb_CPF";
			this.tb_CPF.Size = new System.Drawing.Size(74, 20);
			this.tb_CPF.TabIndex = 13;
			// 
			// rb_PhysicalPerson
			// 
			this.rb_PhysicalPerson.AutoSize = true;
			this.rb_PhysicalPerson.Checked = true;
			this.rb_PhysicalPerson.Location = new System.Drawing.Point(142, 184);
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
			this.rb_LegalPerson.Location = new System.Drawing.Point(142, 207);
			this.rb_LegalPerson.Name = "rb_LegalPerson";
			this.rb_LegalPerson.Size = new System.Drawing.Size(101, 17);
			this.rb_LegalPerson.TabIndex = 15;
			this.rb_LegalPerson.Text = "Pessoa Jurídica";
			this.rb_LegalPerson.UseVisualStyleBackColor = true;
			this.rb_LegalPerson.Click += new System.EventHandler(this.rb_LegalPerson_Click);
			// 
			// tb_City
			// 
			this.tb_City.Location = new System.Drawing.Point(10, 156);
			this.tb_City.Name = "tb_City";
			this.tb_City.Size = new System.Drawing.Size(373, 20);
			this.tb_City.TabIndex = 17;
			// 
			// lb_City
			// 
			this.lb_City.AutoSize = true;
			this.lb_City.Location = new System.Drawing.Point(7, 139);
			this.lb_City.Name = "lb_City";
			this.lb_City.Size = new System.Drawing.Size(40, 13);
			this.lb_City.TabIndex = 16;
			this.lb_City.Text = "Cidade";
			// 
			// lb_Phone
			// 
			this.lb_Phone.AutoSize = true;
			this.lb_Phone.Location = new System.Drawing.Point(7, 274);
			this.lb_Phone.Name = "lb_Phone";
			this.lb_Phone.Size = new System.Drawing.Size(49, 13);
			this.lb_Phone.TabIndex = 18;
			this.lb_Phone.Text = "Telefone";
			// 
			// tb_Phone
			// 
			this.tb_Phone.Location = new System.Drawing.Point(10, 290);
			this.tb_Phone.Mask = "(99)9999-9999";
			this.tb_Phone.Name = "tb_Phone";
			this.tb_Phone.Size = new System.Drawing.Size(100, 20);
			this.tb_Phone.TabIndex = 19;
			// 
			// tb_Cel
			// 
			this.tb_Cel.Location = new System.Drawing.Point(142, 290);
			this.tb_Cel.Mask = "(99)99999-9999";
			this.tb_Cel.Name = "tb_Cel";
			this.tb_Cel.Size = new System.Drawing.Size(100, 20);
			this.tb_Cel.TabIndex = 21;
			// 
			// lb_Cel
			// 
			this.lb_Cel.AutoSize = true;
			this.lb_Cel.Location = new System.Drawing.Point(139, 274);
			this.lb_Cel.Name = "lb_Cel";
			this.lb_Cel.Size = new System.Drawing.Size(39, 13);
			this.lb_Cel.TabIndex = 20;
			this.lb_Cel.Text = "Celular";
			// 
			// cb_State
			// 
			this.cb_State.FormattingEnabled = true;
			this.cb_State.Location = new System.Drawing.Point(389, 155);
			this.cb_State.Name = "cb_State";
			this.cb_State.Size = new System.Drawing.Size(71, 21);
			this.cb_State.TabIndex = 22;
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(385, 4);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(75, 23);
			this.btn_Search.TabIndex = 23;
			this.btn_Search.Text = "Pesquisar";
			this.btn_Search.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Delete);
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.btn_Save);
			this.panel1.Controls.Add(this.btn_New);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 453);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 28);
			this.panel1.TabIndex = 24;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(97, 0);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 24);
			this.btn_Delete.TabIndex = 3;
			this.btn_Delete.Text = "Excluir";
			this.btn_Delete.UseVisualStyleBackColor = true;
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(385, 0);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 24);
			this.btn_Close.TabIndex = 1;
			this.btn_Close.Text = "Fechar";
			this.btn_Close.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(304, 0);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 24);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Salvar";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// btn_New
			// 
			this.btn_New.Location = new System.Drawing.Point(16, 0);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(75, 24);
			this.btn_New.TabIndex = 2;
			this.btn_New.Text = "Novo";
			this.btn_New.UseVisualStyleBackColor = true;
			// 
			// tb_PostCode
			// 
			this.tb_PostCode.Location = new System.Drawing.Point(10, 66);
			this.tb_PostCode.Mask = "00.000-000";
			this.tb_PostCode.Name = "tb_PostCode";
			this.tb_PostCode.Size = new System.Drawing.Size(67, 20);
			this.tb_PostCode.TabIndex = 25;
			// 
			// lb_PostCode
			// 
			this.lb_PostCode.AutoSize = true;
			this.lb_PostCode.Location = new System.Drawing.Point(10, 50);
			this.lb_PostCode.Name = "lb_PostCode";
			this.lb_PostCode.Size = new System.Drawing.Size(28, 13);
			this.lb_PostCode.TabIndex = 26;
			this.lb_PostCode.Text = "CEP";
			// 
			// tb_Email
			// 
			this.tb_Email.Location = new System.Drawing.Point(10, 247);
			this.tb_Email.Name = "tb_Email";
			this.tb_Email.Size = new System.Drawing.Size(232, 20);
			this.tb_Email.TabIndex = 28;
			// 
			// lb_Email
			// 
			this.lb_Email.AutoSize = true;
			this.lb_Email.Location = new System.Drawing.Point(7, 230);
			this.lb_Email.Name = "lb_Email";
			this.lb_Email.Size = new System.Drawing.Size(36, 13);
			this.lb_Email.TabIndex = 27;
			this.lb_Email.Text = "E-Mail";
			// 
			// pb_User
			// 
			this.pb_User.Location = new System.Drawing.Point(289, 247);
			this.pb_User.Name = "pb_User";
			this.pb_User.Size = new System.Drawing.Size(171, 194);
			this.pb_User.TabIndex = 29;
			this.pb_User.TabStop = false;
			// 
			// clb_Phone
			// 
			this.clb_Phone.FormattingEnabled = true;
			this.clb_Phone.Location = new System.Drawing.Point(10, 317);
			this.clb_Phone.Name = "clb_Phone";
			this.clb_Phone.Size = new System.Drawing.Size(100, 124);
			this.clb_Phone.TabIndex = 30;
			// 
			// clb_Cel
			// 
			this.clb_Cel.FormattingEnabled = true;
			this.clb_Cel.Location = new System.Drawing.Point(142, 317);
			this.clb_Cel.Name = "clb_Cel";
			this.clb_Cel.Size = new System.Drawing.Size(100, 124);
			this.clb_Cel.TabIndex = 31;
			// 
			// lb_ProfileImg
			// 
			this.lb_ProfileImg.AutoSize = true;
			this.lb_ProfileImg.Location = new System.Drawing.Point(289, 201);
			this.lb_ProfileImg.Name = "lb_ProfileImg";
			this.lb_ProfileImg.Size = new System.Drawing.Size(113, 13);
			this.lb_ProfileImg.TabIndex = 32;
			this.lb_ProfileImg.Text = "Caminho Foto de Perfil";
			// 
			// tb_ProfileImg
			// 
			this.tb_ProfileImg.Location = new System.Drawing.Point(289, 221);
			this.tb_ProfileImg.Name = "tb_ProfileImg";
			this.tb_ProfileImg.Size = new System.Drawing.Size(171, 20);
			this.tb_ProfileImg.TabIndex = 33;
			// 
			// frm_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 481);
			this.Controls.Add(this.tb_ProfileImg);
			this.Controls.Add(this.lb_ProfileImg);
			this.Controls.Add(this.clb_Cel);
			this.Controls.Add(this.clb_Phone);
			this.Controls.Add(this.pb_User);
			this.Controls.Add(this.tb_Email);
			this.Controls.Add(this.lb_Email);
			this.Controls.Add(this.lb_PostCode);
			this.Controls.Add(this.tb_PostCode);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Search);
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
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
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
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.MaskedTextBox tb_PostCode;
		private System.Windows.Forms.Label lb_PostCode;
		private System.Windows.Forms.TextBox tb_Email;
		private System.Windows.Forms.Label lb_Email;
		private System.Windows.Forms.PictureBox pb_User;
		private System.Windows.Forms.CheckedListBox clb_Phone;
		private System.Windows.Forms.CheckedListBox clb_Cel;
		private System.Windows.Forms.Label lb_ProfileImg;
		private System.Windows.Forms.TextBox tb_ProfileImg;
	}
}