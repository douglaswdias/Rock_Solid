
namespace Rock_Solid
{
	partial class frm_Supplier
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
            this.lb_PostCode = new System.Windows.Forms.Label();
            this.tb_PostCode = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_State = new System.Windows.Forms.Label();
            this.tb_Neighborhood = new System.Windows.Forms.TextBox();
            this.lb_Neighborhood = new System.Windows.Forms.Label();
            this.tb_Number = new System.Windows.Forms.MaskedTextBox();
            this.lb_Number = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_RG = new System.Windows.Forms.MaskedTextBox();
            this.lb_RG = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_CreatedAt = new System.Windows.Forms.TextBox();
            this.lb_CreatedAt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Rock_Solid.Properties.Resources.Search_Button;
            this.button1.Location = new System.Drawing.Point(436, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 20);
            this.button1.TabIndex = 71;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_PostCode
            // 
            this.lb_PostCode.AutoSize = true;
            this.lb_PostCode.Location = new System.Drawing.Point(10, 97);
            this.lb_PostCode.Name = "lb_PostCode";
            this.lb_PostCode.Size = new System.Drawing.Size(28, 13);
            this.lb_PostCode.TabIndex = 45;
            this.lb_PostCode.Text = "CEP";
            // 
            // tb_PostCode
            // 
            this.tb_PostCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_PostCode.Location = new System.Drawing.Point(10, 113);
            this.tb_PostCode.Mask = "00.000-000";
            this.tb_PostCode.Name = "tb_PostCode";
            this.tb_PostCode.Size = new System.Drawing.Size(67, 20);
            this.tb_PostCode.TabIndex = 44;
            this.tb_PostCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 28);
            this.panel1.TabIndex = 70;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(91, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 24);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Excluir";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(385, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 24);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Fechar";
            this.btn_Close.UseVisualStyleBackColor = true;
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
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(10, 0);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 24);
            this.btn_New.TabIndex = 17;
            this.btn_New.Text = "Novo";
            this.btn_New.UseVisualStyleBackColor = true;
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
            this.cb_State.Location = new System.Drawing.Point(389, 202);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(71, 21);
            this.cb_State.TabIndex = 54;
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(10, 203);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(373, 20);
            this.tb_City.TabIndex = 52;
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(7, 186);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(40, 13);
            this.lb_City.TabIndex = 53;
            this.lb_City.Text = "Cidade";
            // 
            // lb_State
            // 
            this.lb_State.AutoSize = true;
            this.lb_State.Location = new System.Drawing.Point(383, 186);
            this.lb_State.Name = "lb_State";
            this.lb_State.Size = new System.Drawing.Size(40, 13);
            this.lb_State.TabIndex = 55;
            this.lb_State.Text = "Estado";
            // 
            // tb_Neighborhood
            // 
            this.tb_Neighborhood.Location = new System.Drawing.Point(83, 156);
            this.tb_Neighborhood.Name = "tb_Neighborhood";
            this.tb_Neighborhood.Size = new System.Drawing.Size(377, 20);
            this.tb_Neighborhood.TabIndex = 51;
            // 
            // lb_Neighborhood
            // 
            this.lb_Neighborhood.AutoSize = true;
            this.lb_Neighborhood.Location = new System.Drawing.Point(84, 139);
            this.lb_Neighborhood.Name = "lb_Neighborhood";
            this.lb_Neighborhood.Size = new System.Drawing.Size(34, 13);
            this.lb_Neighborhood.TabIndex = 50;
            this.lb_Neighborhood.Text = "Bairro";
            // 
            // tb_Number
            // 
            this.tb_Number.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_Number.Location = new System.Drawing.Point(10, 156);
            this.tb_Number.Mask = "0000000000";
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(67, 20);
            this.tb_Number.TabIndex = 49;
            this.tb_Number.ValidatingType = typeof(int);
            // 
            // lb_Number
            // 
            this.lb_Number.AutoSize = true;
            this.lb_Number.Location = new System.Drawing.Point(7, 140);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new System.Drawing.Size(44, 13);
            this.lb_Number.TabIndex = 48;
            this.lb_Number.Text = "Número";
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(83, 114);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(377, 20);
            this.tb_Address.TabIndex = 46;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(84, 97);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(53, 13);
            this.lb_Address.TabIndex = 47;
            this.lb_Address.Text = "Endereço";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(83, 26);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(353, 20);
            this.tb_Name.TabIndex = 43;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(80, 10);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(70, 13);
            this.lb_Name.TabIndex = 42;
            this.lb_Name.Text = "Razão Social";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(7, 10);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(40, 13);
            this.lb_ID.TabIndex = 41;
            this.lb_ID.Text = "Código";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(10, 26);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(67, 20);
            this.tb_ID.TabIndex = 40;
            // 
            // tb_RG
            // 
            this.tb_RG.Location = new System.Drawing.Point(133, 246);
            this.tb_RG.Mask = "000.000.000.000";
            this.tb_RG.Name = "tb_RG";
            this.tb_RG.Size = new System.Drawing.Size(95, 20);
            this.tb_RG.TabIndex = 72;
            this.tb_RG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_RG
            // 
            this.lb_RG.AutoSize = true;
            this.lb_RG.Location = new System.Drawing.Point(130, 229);
            this.lb_RG.Name = "lb_RG";
            this.lb_RG.Size = new System.Drawing.Size(17, 13);
            this.lb_RG.TabIndex = 73;
            this.lb_RG.Text = "IE";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(236, 246);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(224, 20);
            this.tb_Email.TabIndex = 76;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(247, 229);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(36, 13);
            this.lb_Email.TabIndex = 77;
            this.lb_Email.Text = "E-Mail";
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(10, 246);
            this.tb_CPF.Mask = "00.000.000/0000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(114, 20);
            this.tb_CPF.TabIndex = 75;
            this.tb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Location = new System.Drawing.Point(7, 229);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(34, 13);
            this.lb_CPF.TabIndex = 74;
            this.lb_CPF.Text = "CNPJ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 78;
            // 
            // tb_CreatedAt
            // 
            this.tb_CreatedAt.Location = new System.Drawing.Point(10, 295);
            this.tb_CreatedAt.Name = "tb_CreatedAt";
            this.tb_CreatedAt.ReadOnly = true;
            this.tb_CreatedAt.Size = new System.Drawing.Size(100, 20);
            this.tb_CreatedAt.TabIndex = 82;
            this.tb_CreatedAt.Text = "00/00/0000";
            // 
            // lb_CreatedAt
            // 
            this.lb_CreatedAt.AutoSize = true;
            this.lb_CreatedAt.Location = new System.Drawing.Point(7, 278);
            this.lb_CreatedAt.Name = "lb_CreatedAt";
            this.lb_CreatedAt.Size = new System.Drawing.Size(75, 13);
            this.lb_CreatedAt.TabIndex = 83;
            this.lb_CreatedAt.Text = "Última Compra";
            // 
            // frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.tb_CreatedAt);
            this.Controls.Add(this.lb_CreatedAt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_RG);
            this.Controls.Add(this.lb_RG);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.lb_CPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_PostCode);
            this.Controls.Add(this.tb_PostCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_State);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.lb_City);
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
            this.Name = "frm_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_PostCode;
        public System.Windows.Forms.MaskedTextBox tb_PostCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        public System.Windows.Forms.ComboBox cb_State;
        public System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.Label lb_State;
        public System.Windows.Forms.TextBox tb_Neighborhood;
        private System.Windows.Forms.Label lb_Neighborhood;
        public System.Windows.Forms.MaskedTextBox tb_Number;
        private System.Windows.Forms.Label lb_Number;
        public System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lb_Address;
        public System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        public System.Windows.Forms.TextBox tb_ID;
        public System.Windows.Forms.MaskedTextBox tb_RG;
        private System.Windows.Forms.Label lb_RG;
        public System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Email;
        public System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.Label lb_CPF;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox tb_CreatedAt;
        private System.Windows.Forms.Label lb_CreatedAt;
    }
}