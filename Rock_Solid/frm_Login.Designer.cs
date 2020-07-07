namespace Rock_Solid
{
	partial class frm_Login
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
			this.lb_UserName = new System.Windows.Forms.Label();
			this.tb_UserName = new System.Windows.Forms.TextBox();
			this.lb_Password = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Logout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_UserName
			// 
			this.lb_UserName.AutoSize = true;
			this.lb_UserName.Location = new System.Drawing.Point(20, 38);
			this.lb_UserName.Name = "lb_UserName";
			this.lb_UserName.Size = new System.Drawing.Size(43, 13);
			this.lb_UserName.TabIndex = 0;
			this.lb_UserName.Text = "Usuário";
			// 
			// tb_UserName
			// 
			this.tb_UserName.Location = new System.Drawing.Point(23, 55);
			this.tb_UserName.Name = "tb_UserName";
			this.tb_UserName.Size = new System.Drawing.Size(160, 20);
			this.tb_UserName.TabIndex = 1;
			// 
			// lb_Password
			// 
			this.lb_Password.AutoSize = true;
			this.lb_Password.Location = new System.Drawing.Point(23, 92);
			this.lb_Password.Name = "lb_Password";
			this.lb_Password.Size = new System.Drawing.Size(38, 13);
			this.lb_Password.TabIndex = 2;
			this.lb_Password.Text = "Senha";
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(26, 109);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(157, 20);
			this.tb_Password.TabIndex = 3;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(45, 147);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(122, 23);
			this.btn_Login.TabIndex = 4;
			this.btn_Login.Text = "Entrar";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Logout
			// 
			this.btn_Logout.Location = new System.Drawing.Point(45, 188);
			this.btn_Logout.Name = "btn_Logout";
			this.btn_Logout.Size = new System.Drawing.Size(122, 23);
			this.btn_Logout.TabIndex = 5;
			this.btn_Logout.Text = "Sair";
			this.btn_Logout.UseVisualStyleBackColor = true;
			this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
			// 
			// frm_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 262);
			this.Controls.Add(this.btn_Logout);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.lb_Password);
			this.Controls.Add(this.tb_UserName);
			this.Controls.Add(this.lb_UserName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_UserName;
		private System.Windows.Forms.TextBox tb_UserName;
		private System.Windows.Forms.Label lb_Password;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Logout;
	}
}