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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Client));
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
			this.rb_Individual = new System.Windows.Forms.RadioButton();
			this.rb_LegalPerson = new System.Windows.Forms.RadioButton();
			this.tb_City = new System.Windows.Forms.TextBox();
			this.lb_City = new System.Windows.Forms.Label();
			this.lb_Phone = new System.Windows.Forms.Label();
			this.tb_Phone = new System.Windows.Forms.MaskedTextBox();
			this.tb_Cel = new System.Windows.Forms.MaskedTextBox();
			this.lb_Cel = new System.Windows.Forms.Label();
			this.cb_State = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_New = new System.Windows.Forms.Button();
			this.tb_PostCode = new System.Windows.Forms.MaskedTextBox();
			this.lb_PostCode = new System.Windows.Forms.Label();
			this.tb_Email = new System.Windows.Forms.TextBox();
			this.lb_Email = new System.Windows.Forms.Label();
			this.btn_ProfilePicture = new System.Windows.Forms.Button();
			this.ofd_Client = new System.Windows.Forms.OpenFileDialog();
			this.tb_RG = new System.Windows.Forms.MaskedTextBox();
			this.lb_RG = new System.Windows.Forms.Label();
			this.pb_User = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_Workout = new System.Windows.Forms.Button();
			this.lbx_Phone = new System.Windows.Forms.ListBox();
			this.lbx_Cel = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(10, 28);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(67, 20);
			this.tb_ID.TabIndex = 1;
			this.tb_ID.Enter += new System.EventHandler(this.tb_ID_Enter);
			this.tb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ID_KeyDown);
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
			this.lb_Name.Location = new System.Drawing.Point(80, 12);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(82, 13);
			this.lb_Name.TabIndex = 2;
			this.lb_Name.Text = "Nome Completo";
			// 
			// tb_Name
			// 
			this.tb_Name.Location = new System.Drawing.Point(83, 28);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(353, 20);
			this.tb_Name.TabIndex = 2;
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
			this.tb_Address.TabIndex = 4;
			// 
			// lb_Number
			// 
			this.lb_Number.AutoSize = true;
			this.lb_Number.Location = new System.Drawing.Point(7, 93);
			this.lb_Number.Name = "lb_Number";
			this.lb_Number.Size = new System.Drawing.Size(44, 13);
			this.lb_Number.TabIndex = 5;
			this.lb_Number.Text = "Número";
			// 
			// tb_Number
			// 
			this.tb_Number.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.tb_Number.Location = new System.Drawing.Point(10, 109);
			this.tb_Number.Mask = "0000000000";
			this.tb_Number.Name = "tb_Number";
			this.tb_Number.Size = new System.Drawing.Size(67, 20);
			this.tb_Number.TabIndex = 5;
			this.tb_Number.ValidatingType = typeof(int);
			// 
			// tb_Neighborhood
			// 
			this.tb_Neighborhood.Location = new System.Drawing.Point(83, 109);
			this.tb_Neighborhood.Name = "tb_Neighborhood";
			this.tb_Neighborhood.Size = new System.Drawing.Size(377, 20);
			this.tb_Neighborhood.TabIndex = 6;
			// 
			// lb_Neighborhood
			// 
			this.lb_Neighborhood.AutoSize = true;
			this.lb_Neighborhood.Location = new System.Drawing.Point(84, 92);
			this.lb_Neighborhood.Name = "lb_Neighborhood";
			this.lb_Neighborhood.Size = new System.Drawing.Size(34, 13);
			this.lb_Neighborhood.TabIndex = 6;
			this.lb_Neighborhood.Text = "Bairro";
			// 
			// lb_State
			// 
			this.lb_State.AutoSize = true;
			this.lb_State.Location = new System.Drawing.Point(383, 139);
			this.lb_State.Name = "lb_State";
			this.lb_State.Size = new System.Drawing.Size(40, 13);
			this.lb_State.TabIndex = 8;
			this.lb_State.Text = "Estado";
			// 
			// lb_CPF
			// 
			this.lb_CPF.AutoSize = true;
			this.lb_CPF.Location = new System.Drawing.Point(301, 188);
			this.lb_CPF.Name = "lb_CPF";
			this.lb_CPF.Size = new System.Drawing.Size(27, 13);
			this.lb_CPF.TabIndex = 10;
			this.lb_CPF.Text = "CPF";
			// 
			// tb_CPF
			// 
			this.tb_CPF.Location = new System.Drawing.Point(304, 205);
			this.tb_CPF.Mask = "000.000.000-00";
			this.tb_CPF.Name = "tb_CPF";
			this.tb_CPF.Size = new System.Drawing.Size(88, 20);
			this.tb_CPF.TabIndex = 10;
			this.tb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// rb_Individual
			// 
			this.rb_Individual.AutoSize = true;
			this.rb_Individual.Checked = true;
			this.rb_Individual.Location = new System.Drawing.Point(59, 188);
			this.rb_Individual.Name = "rb_Individual";
			this.rb_Individual.Size = new System.Drawing.Size(92, 17);
			this.rb_Individual.TabIndex = 20;
			this.rb_Individual.TabStop = true;
			this.rb_Individual.Text = "Pessoa Física";
			this.rb_Individual.UseVisualStyleBackColor = true;
			this.rb_Individual.Click += new System.EventHandler(this.rb_Individual_Click);
			// 
			// rb_LegalPerson
			// 
			this.rb_LegalPerson.AutoSize = true;
			this.rb_LegalPerson.Location = new System.Drawing.Point(59, 211);
			this.rb_LegalPerson.Name = "rb_LegalPerson";
			this.rb_LegalPerson.Size = new System.Drawing.Size(101, 17);
			this.rb_LegalPerson.TabIndex = 21;
			this.rb_LegalPerson.Text = "Pessoa Jurídica";
			this.rb_LegalPerson.UseVisualStyleBackColor = true;
			this.rb_LegalPerson.Click += new System.EventHandler(this.rb_LegalPerson_Click);
			// 
			// tb_City
			// 
			this.tb_City.Location = new System.Drawing.Point(10, 156);
			this.tb_City.Name = "tb_City";
			this.tb_City.Size = new System.Drawing.Size(373, 20);
			this.tb_City.TabIndex = 7;
			// 
			// lb_City
			// 
			this.lb_City.AutoSize = true;
			this.lb_City.Location = new System.Drawing.Point(7, 139);
			this.lb_City.Name = "lb_City";
			this.lb_City.Size = new System.Drawing.Size(40, 13);
			this.lb_City.TabIndex = 7;
			this.lb_City.Text = "Cidade";
			// 
			// lb_Phone
			// 
			this.lb_Phone.AutoSize = true;
			this.lb_Phone.Location = new System.Drawing.Point(7, 274);
			this.lb_Phone.Name = "lb_Phone";
			this.lb_Phone.Size = new System.Drawing.Size(49, 13);
			this.lb_Phone.TabIndex = 12;
			this.lb_Phone.Text = "Telefone";
			// 
			// tb_Phone
			// 
			this.tb_Phone.Location = new System.Drawing.Point(10, 290);
			this.tb_Phone.Mask = "(99)9999-9999";
			this.tb_Phone.Name = "tb_Phone";
			this.tb_Phone.Size = new System.Drawing.Size(100, 20);
			this.tb_Phone.TabIndex = 12;
			this.tb_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// tb_Cel
			// 
			this.tb_Cel.Location = new System.Drawing.Point(142, 290);
			this.tb_Cel.Mask = "(99)99999-9999";
			this.tb_Cel.Name = "tb_Cel";
			this.tb_Cel.Size = new System.Drawing.Size(100, 20);
			this.tb_Cel.TabIndex = 13;
			this.tb_Cel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lb_Cel
			// 
			this.lb_Cel.AutoSize = true;
			this.lb_Cel.Location = new System.Drawing.Point(139, 274);
			this.lb_Cel.Name = "lb_Cel";
			this.lb_Cel.Size = new System.Drawing.Size(39, 13);
			this.lb_Cel.TabIndex = 13;
			this.lb_Cel.Text = "Celular";
			// 
			// cb_State
			// 
			this.cb_State.FormattingEnabled = true;
			this.cb_State.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
			this.cb_State.Location = new System.Drawing.Point(389, 155);
			this.cb_State.Name = "cb_State";
			this.cb_State.Size = new System.Drawing.Size(71, 21);
			this.cb_State.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Delete);
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.btn_Save);
			this.panel1.Controls.Add(this.btn_New);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 483);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 28);
			this.panel1.TabIndex = 33;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(91, 0);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 24);
			this.btn_Delete.TabIndex = 18;
			this.btn_Delete.Text = "Excluir";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(385, 0);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 24);
			this.btn_Close.TabIndex = 16;
			this.btn_Close.Text = "Fechar";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(304, 0);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 24);
			this.btn_Save.TabIndex = 15;
			this.btn_Save.Text = "Salvar";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_New
			// 
			this.btn_New.Location = new System.Drawing.Point(10, 0);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(75, 24);
			this.btn_New.TabIndex = 17;
			this.btn_New.Text = "Novo";
			this.btn_New.UseVisualStyleBackColor = true;
			this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
			// 
			// tb_PostCode
			// 
			this.tb_PostCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.tb_PostCode.Location = new System.Drawing.Point(10, 66);
			this.tb_PostCode.Mask = "00.000-000";
			this.tb_PostCode.Name = "tb_PostCode";
			this.tb_PostCode.Size = new System.Drawing.Size(67, 20);
			this.tb_PostCode.TabIndex = 3;
			this.tb_PostCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lb_PostCode
			// 
			this.lb_PostCode.AutoSize = true;
			this.lb_PostCode.Location = new System.Drawing.Point(10, 50);
			this.lb_PostCode.Name = "lb_PostCode";
			this.lb_PostCode.Size = new System.Drawing.Size(28, 13);
			this.lb_PostCode.TabIndex = 3;
			this.lb_PostCode.Text = "CEP";
			// 
			// tb_Email
			// 
			this.tb_Email.Location = new System.Drawing.Point(10, 247);
			this.tb_Email.Name = "tb_Email";
			this.tb_Email.Size = new System.Drawing.Size(232, 20);
			this.tb_Email.TabIndex = 11;
			// 
			// lb_Email
			// 
			this.lb_Email.AutoSize = true;
			this.lb_Email.Location = new System.Drawing.Point(7, 230);
			this.lb_Email.Name = "lb_Email";
			this.lb_Email.Size = new System.Drawing.Size(36, 13);
			this.lb_Email.TabIndex = 11;
			this.lb_Email.Text = "E-Mail";
			// 
			// btn_ProfilePicture
			// 
			this.btn_ProfilePicture.Location = new System.Drawing.Point(304, 244);
			this.btn_ProfilePicture.Name = "btn_ProfilePicture";
			this.btn_ProfilePicture.Size = new System.Drawing.Size(156, 23);
			this.btn_ProfilePicture.TabIndex = 14;
			this.btn_ProfilePicture.Text = "Adicionar Foto";
			this.btn_ProfilePicture.UseVisualStyleBackColor = true;
			this.btn_ProfilePicture.Click += new System.EventHandler(this.btn_ProfilePicture_Click);
			// 
			// ofd_Client
			// 
			this.ofd_Client.FileName = "ofd_Client";
			this.ofd_Client.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
			// 
			// tb_RG
			// 
			this.tb_RG.Location = new System.Drawing.Point(191, 205);
			this.tb_RG.Mask = "00.000.000-0";
			this.tb_RG.Name = "tb_RG";
			this.tb_RG.Size = new System.Drawing.Size(73, 20);
			this.tb_RG.TabIndex = 9;
			this.tb_RG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lb_RG
			// 
			this.lb_RG.AutoSize = true;
			this.lb_RG.Location = new System.Drawing.Point(188, 188);
			this.lb_RG.Name = "lb_RG";
			this.lb_RG.Size = new System.Drawing.Size(23, 13);
			this.lb_RG.TabIndex = 9;
			this.lb_RG.Text = "RG";
			// 
			// pb_User
			// 
			this.pb_User.Image = ((System.Drawing.Image)(resources.GetObject("pb_User.Image")));
			this.pb_User.Location = new System.Drawing.Point(304, 274);
			this.pb_User.Name = "pb_User";
			this.pb_User.Size = new System.Drawing.Size(156, 167);
			this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_User.TabIndex = 29;
			this.pb_User.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.button1.Location = new System.Drawing.Point(436, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(18, 20);
			this.button1.TabIndex = 36;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Workout
			// 
			this.btn_Workout.Location = new System.Drawing.Point(10, 448);
			this.btn_Workout.Name = "btn_Workout";
			this.btn_Workout.Size = new System.Drawing.Size(450, 29);
			this.btn_Workout.TabIndex = 37;
			this.btn_Workout.Text = "Treino";
			this.btn_Workout.UseVisualStyleBackColor = true;
			this.btn_Workout.Click += new System.EventHandler(this.btn_Workout_Click);
			// 
			// lbx_Phone
			// 
			this.lbx_Phone.FormattingEnabled = true;
			this.lbx_Phone.Location = new System.Drawing.Point(13, 322);
			this.lbx_Phone.Name = "lbx_Phone";
			this.lbx_Phone.Size = new System.Drawing.Size(97, 121);
			this.lbx_Phone.TabIndex = 38;
			// 
			// lbx_Cel
			// 
			this.lbx_Cel.FormattingEnabled = true;
			this.lbx_Cel.Location = new System.Drawing.Point(142, 322);
			this.lbx_Cel.Name = "lbx_Cel";
			this.lbx_Cel.Size = new System.Drawing.Size(97, 121);
			this.lbx_Cel.TabIndex = 39;
			// 
			// frm_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 511);
			this.Controls.Add(this.lbx_Cel);
			this.Controls.Add(this.lbx_Phone);
			this.Controls.Add(this.btn_Workout);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_RG);
			this.Controls.Add(this.lb_RG);
			this.Controls.Add(this.btn_ProfilePicture);
			this.Controls.Add(this.pb_User);
			this.Controls.Add(this.tb_Email);
			this.Controls.Add(this.lb_Email);
			this.Controls.Add(this.lb_PostCode);
			this.Controls.Add(this.tb_PostCode);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cb_State);
			this.Controls.Add(this.tb_Cel);
			this.Controls.Add(this.lb_Cel);
			this.Controls.Add(this.tb_Phone);
			this.Controls.Add(this.lb_Phone);
			this.Controls.Add(this.tb_City);
			this.Controls.Add(this.lb_City);
			this.Controls.Add(this.rb_LegalPerson);
			this.Controls.Add(this.rb_Individual);
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
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Client";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Clientes";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Client_FormClosed);
			this.Load += new System.EventHandler(this.frm_Client_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Client_KeyPress);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.Label lb_Name;
		private System.Windows.Forms.Label lb_Address;
		private System.Windows.Forms.Label lb_Number;
		private System.Windows.Forms.Label lb_Neighborhood;
		private System.Windows.Forms.Label lb_State;
		private System.Windows.Forms.Label lb_CPF;
		private System.Windows.Forms.RadioButton rb_Individual;
		private System.Windows.Forms.RadioButton rb_LegalPerson;
		private System.Windows.Forms.Label lb_City;
		private System.Windows.Forms.Label lb_Phone;
		private System.Windows.Forms.Label lb_Cel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Label lb_PostCode;
		private System.Windows.Forms.Label lb_Email;
		public System.Windows.Forms.TextBox tb_ID;
		public System.Windows.Forms.TextBox tb_Name;
		public System.Windows.Forms.TextBox tb_Address;
		public System.Windows.Forms.MaskedTextBox tb_Number;
		public System.Windows.Forms.TextBox tb_Neighborhood;
		public System.Windows.Forms.MaskedTextBox tb_CPF;
		public System.Windows.Forms.TextBox tb_City;
		public System.Windows.Forms.MaskedTextBox tb_Phone;
		public System.Windows.Forms.MaskedTextBox tb_Cel;
		public System.Windows.Forms.ComboBox cb_State;
		public System.Windows.Forms.MaskedTextBox tb_PostCode;
		public System.Windows.Forms.TextBox tb_Email;
		public System.Windows.Forms.PictureBox pb_User;
		private System.Windows.Forms.Button btn_ProfilePicture;
		private System.Windows.Forms.OpenFileDialog ofd_Client;
		public System.Windows.Forms.MaskedTextBox tb_RG;
		private System.Windows.Forms.Label lb_RG;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_Workout;
		private System.Windows.Forms.ListBox lbx_Phone;
		private System.Windows.Forms.ListBox lbx_Cel;
	}
}