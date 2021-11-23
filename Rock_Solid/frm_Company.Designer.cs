
namespace Rock_Solid
{
	partial class frm_Company
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
            this.tb_RG = new System.Windows.Forms.MaskedTextBox();
            this.lb_RG = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PostCode = new System.Windows.Forms.Label();
            this.tb_PostCode = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.tb_Cel = new System.Windows.Forms.MaskedTextBox();
            this.lb_Cel = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.lb_State = new System.Windows.Forms.Label();
            this.tb_Neighborhood = new System.Windows.Forms.TextBox();
            this.lb_Neighborhood = new System.Windows.Forms.Label();
            this.tb_Number = new System.Windows.Forms.MaskedTextBox();
            this.lb_Number = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_RG
            // 
            this.tb_RG.Location = new System.Drawing.Point(133, 251);
            this.tb_RG.Mask = "000.000.000.000";
            this.tb_RG.Name = "tb_RG";
            this.tb_RG.Size = new System.Drawing.Size(95, 20);
            this.tb_RG.TabIndex = 56;
            this.tb_RG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_RG
            // 
            this.lb_RG.AutoSize = true;
            this.lb_RG.Location = new System.Drawing.Point(130, 234);
            this.lb_RG.Name = "lb_RG";
            this.lb_RG.Size = new System.Drawing.Size(17, 13);
            this.lb_RG.TabIndex = 57;
            this.lb_RG.Text = "IE";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(236, 251);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(224, 20);
            this.tb_Email.TabIndex = 60;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(247, 234);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(36, 13);
            this.lb_Email.TabIndex = 61;
            this.lb_Email.Text = "E-Mail";
            // 
            // lb_PostCode
            // 
            this.lb_PostCode.AutoSize = true;
            this.lb_PostCode.Location = new System.Drawing.Point(10, 96);
            this.lb_PostCode.Name = "lb_PostCode";
            this.lb_PostCode.Size = new System.Drawing.Size(28, 13);
            this.lb_PostCode.TabIndex = 45;
            this.lb_PostCode.Text = "CEP";
            // 
            // tb_PostCode
            // 
            this.tb_PostCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_PostCode.Location = new System.Drawing.Point(10, 112);
            this.tb_PostCode.Mask = "00.000-000";
            this.tb_PostCode.Name = "tb_PostCode";
            this.tb_PostCode.Size = new System.Drawing.Size(67, 20);
            this.tb_PostCode.TabIndex = 44;
            this.tb_PostCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 28);
            this.panel1.TabIndex = 70;
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
            this.cb_State.Location = new System.Drawing.Point(389, 201);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(71, 21);
            this.cb_State.TabIndex = 54;
            // 
            // tb_Cel
            // 
            this.tb_Cel.Location = new System.Drawing.Point(134, 302);
            this.tb_Cel.Mask = "(99)99999-9999";
            this.tb_Cel.Name = "tb_Cel";
            this.tb_Cel.Size = new System.Drawing.Size(100, 20);
            this.tb_Cel.TabIndex = 65;
            this.tb_Cel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_Cel
            // 
            this.lb_Cel.AutoSize = true;
            this.lb_Cel.Location = new System.Drawing.Point(131, 286);
            this.lb_Cel.Name = "lb_Cel";
            this.lb_Cel.Size = new System.Drawing.Size(39, 13);
            this.lb_Cel.TabIndex = 64;
            this.lb_Cel.Text = "Celular";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(13, 302);
            this.tb_Phone.Mask = "(99)9999-9999";
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(100, 20);
            this.tb_Phone.TabIndex = 63;
            this.tb_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(10, 286);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(49, 13);
            this.lb_Phone.TabIndex = 62;
            this.lb_Phone.Text = "Telefone";
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(10, 202);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(373, 20);
            this.tb_City.TabIndex = 52;
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(7, 185);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(40, 13);
            this.lb_City.TabIndex = 53;
            this.lb_City.Text = "Cidade";
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(10, 251);
            this.tb_CPF.Mask = "00.000.000/0000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(114, 20);
            this.tb_CPF.TabIndex = 59;
            this.tb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Location = new System.Drawing.Point(7, 234);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(34, 13);
            this.lb_CPF.TabIndex = 58;
            this.lb_CPF.Text = "CNPJ";
            // 
            // lb_State
            // 
            this.lb_State.AutoSize = true;
            this.lb_State.Location = new System.Drawing.Point(383, 185);
            this.lb_State.Name = "lb_State";
            this.lb_State.Size = new System.Drawing.Size(40, 13);
            this.lb_State.TabIndex = 55;
            this.lb_State.Text = "Estado";
            // 
            // tb_Neighborhood
            // 
            this.tb_Neighborhood.Location = new System.Drawing.Point(83, 155);
            this.tb_Neighborhood.Name = "tb_Neighborhood";
            this.tb_Neighborhood.Size = new System.Drawing.Size(377, 20);
            this.tb_Neighborhood.TabIndex = 51;
            // 
            // lb_Neighborhood
            // 
            this.lb_Neighborhood.AutoSize = true;
            this.lb_Neighborhood.Location = new System.Drawing.Point(84, 138);
            this.lb_Neighborhood.Name = "lb_Neighborhood";
            this.lb_Neighborhood.Size = new System.Drawing.Size(34, 13);
            this.lb_Neighborhood.TabIndex = 50;
            this.lb_Neighborhood.Text = "Bairro";
            // 
            // tb_Number
            // 
            this.tb_Number.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_Number.Location = new System.Drawing.Point(10, 155);
            this.tb_Number.Mask = "0000000000";
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(67, 20);
            this.tb_Number.TabIndex = 49;
            this.tb_Number.ValidatingType = typeof(int);
            // 
            // lb_Number
            // 
            this.lb_Number.AutoSize = true;
            this.lb_Number.Location = new System.Drawing.Point(7, 139);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new System.Drawing.Size(44, 13);
            this.lb_Number.TabIndex = 48;
            this.lb_Number.Text = "Número";
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(83, 113);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(377, 20);
            this.tb_Address.TabIndex = 46;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(84, 96);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(53, 13);
            this.lb_Address.TabIndex = 47;
            this.lb_Address.Text = "Endereço";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(10, 25);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(450, 20);
            this.tb_Name.TabIndex = 43;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(7, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(78, 13);
            this.lb_Name.TabIndex = 42;
            this.lb_Name.Text = "Nome Fantasia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 20);
            this.textBox1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Razão Social";
            // 
            // frm_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 369);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RG);
            this.Controls.Add(this.lb_RG);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        public System.Windows.Forms.MaskedTextBox tb_RG;
        private System.Windows.Forms.Label lb_RG;
        public System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PostCode;
        public System.Windows.Forms.MaskedTextBox tb_PostCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.ComboBox cb_State;
        public System.Windows.Forms.MaskedTextBox tb_Cel;
        private System.Windows.Forms.Label lb_Cel;
        public System.Windows.Forms.MaskedTextBox tb_Phone;
        private System.Windows.Forms.Label lb_Phone;
        public System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label lb_City;
        public System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.Label lb_CPF;
        private System.Windows.Forms.Label lb_State;
        public System.Windows.Forms.TextBox tb_Neighborhood;
        private System.Windows.Forms.Label lb_Neighborhood;
        public System.Windows.Forms.MaskedTextBox tb_Number;
        private System.Windows.Forms.Label lb_Number;
        public System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lb_Address;
        public System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}