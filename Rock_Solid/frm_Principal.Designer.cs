namespace Rock_Solid
{
	partial class frm_Principal
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pb_Login = new System.Windows.Forms.PictureBox();
			this.lb_Access = new System.Windows.Forms.Label();
			this.lb_AccessText = new System.Windows.Forms.Label();
			this.lb_User = new System.Windows.Forms.Label();
			this.lb_UserName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Controls.Add(this.lb_UserName);
			this.panel1.Controls.Add(this.lb_User);
			this.panel1.Controls.Add(this.lb_AccessText);
			this.panel1.Controls.Add(this.lb_Access);
			this.panel1.Controls.Add(this.pb_Login);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 652);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1264, 29);
			this.panel1.TabIndex = 0;
			// 
			// pb_Login
			// 
			this.pb_Login.Image = global::Rock_Solid.Properties.Resources.Red_Button;
			this.pb_Login.Location = new System.Drawing.Point(12, 4);
			this.pb_Login.Name = "pb_Login";
			this.pb_Login.Size = new System.Drawing.Size(27, 22);
			this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Login.TabIndex = 0;
			this.pb_Login.TabStop = false;
			// 
			// lb_Access
			// 
			this.lb_Access.AutoSize = true;
			this.lb_Access.Location = new System.Drawing.Point(45, 7);
			this.lb_Access.Name = "lb_Access";
			this.lb_Access.Size = new System.Drawing.Size(45, 13);
			this.lb_Access.TabIndex = 1;
			this.lb_Access.Text = "Acesso:";
			// 
			// lb_AccessText
			// 
			this.lb_AccessText.AutoSize = true;
			this.lb_AccessText.Location = new System.Drawing.Point(97, 7);
			this.lb_AccessText.Name = "lb_AccessText";
			this.lb_AccessText.Size = new System.Drawing.Size(13, 13);
			this.lb_AccessText.TabIndex = 2;
			this.lb_AccessText.Text = "0";
			// 
			// lb_User
			// 
			this.lb_User.AutoSize = true;
			this.lb_User.Location = new System.Drawing.Point(172, 7);
			this.lb_User.Name = "lb_User";
			this.lb_User.Size = new System.Drawing.Size(46, 13);
			this.lb_User.TabIndex = 3;
			this.lb_User.Text = "Usuário:";
			// 
			// lb_UserName
			// 
			this.lb_UserName.AutoSize = true;
			this.lb_UserName.Location = new System.Drawing.Point(225, 7);
			this.lb_UserName.Name = "lb_UserName";
			this.lb_UserName.Size = new System.Drawing.Size(22, 13);
			this.lb_UserName.TabIndex = 4;
			this.lb_UserName.Text = "-----";
			// 
			// frm_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frm_Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rock Solid Academy";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lb_User;
		private System.Windows.Forms.Label lb_Access;
		public System.Windows.Forms.PictureBox pb_Login;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lb_UserName;
		public System.Windows.Forms.Label lb_AccessText;
	}
}

