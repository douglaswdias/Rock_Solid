﻿namespace Rock_Solid
{
    partial class frm_User
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
			this.lb_Name = new System.Windows.Forms.Label();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.lb_Username = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.lb_Password = new System.Windows.Forms.Label();
			this.lb_Level = new System.Windows.Forms.Label();
			this.tb_Level = new System.Windows.Forms.NumericUpDown();
			this.cb_Status = new System.Windows.Forms.ComboBox();
			this.lb_Status = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_New = new System.Windows.Forms.Button();
			this.lb_ID = new System.Windows.Forms.Label();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.btn_Search = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tb_Level)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Name.Location = new System.Drawing.Point(74, 9);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(41, 15);
			this.lb_Name.TabIndex = 2;
			this.lb_Name.Text = "Nome";
			// 
			// tb_Name
			// 
			this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Name.Location = new System.Drawing.Point(73, 30);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(308, 20);
			this.tb_Name.TabIndex = 3;
			// 
			// tb_Username
			// 
			this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Username.Location = new System.Drawing.Point(12, 73);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(231, 20);
			this.tb_Username.TabIndex = 5;
			// 
			// lb_Username
			// 
			this.lb_Username.AutoSize = true;
			this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Username.Location = new System.Drawing.Point(9, 53);
			this.lb_Username.Name = "lb_Username";
			this.lb_Username.Size = new System.Drawing.Size(104, 15);
			this.lb_Username.TabIndex = 4;
			this.lb_Username.Text = "Nome de Usuário";
			// 
			// tb_Password
			// 
			this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Password.Location = new System.Drawing.Point(249, 73);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(156, 20);
			this.tb_Password.TabIndex = 7;
			// 
			// lb_Password
			// 
			this.lb_Password.AutoSize = true;
			this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Password.Location = new System.Drawing.Point(246, 53);
			this.lb_Password.Name = "lb_Password";
			this.lb_Password.Size = new System.Drawing.Size(43, 15);
			this.lb_Password.TabIndex = 6;
			this.lb_Password.Text = "Senha";
			// 
			// lb_Level
			// 
			this.lb_Level.AutoSize = true;
			this.lb_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Level.Location = new System.Drawing.Point(142, 96);
			this.lb_Level.Name = "lb_Level";
			this.lb_Level.Size = new System.Drawing.Size(93, 15);
			this.lb_Level.TabIndex = 10;
			this.lb_Level.Text = "Nível de Acesso";
			// 
			// tb_Level
			// 
			this.tb_Level.Location = new System.Drawing.Point(145, 120);
			this.tb_Level.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.tb_Level.Name = "tb_Level";
			this.tb_Level.Size = new System.Drawing.Size(98, 20);
			this.tb_Level.TabIndex = 11;
			// 
			// cb_Status
			// 
			this.cb_Status.FormattingEnabled = true;
			this.cb_Status.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado",
            "Inativo"});
			this.cb_Status.Location = new System.Drawing.Point(12, 119);
			this.cb_Status.Name = "cb_Status";
			this.cb_Status.Size = new System.Drawing.Size(125, 21);
			this.cb_Status.TabIndex = 9;
			this.cb_Status.Text = "Ativo";
			// 
			// lb_Status
			// 
			this.lb_Status.AutoSize = true;
			this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Status.Location = new System.Drawing.Point(9, 96);
			this.lb_Status.Name = "lb_Status";
			this.lb_Status.Size = new System.Drawing.Size(41, 15);
			this.lb_Status.TabIndex = 8;
			this.lb_Status.Text = "Status";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Delete);
			this.panel1.Controls.Add(this.btn_Close);
			this.panel1.Controls.Add(this.btn_Save);
			this.panel1.Controls.Add(this.btn_New);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 172);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 28);
			this.panel1.TabIndex = 12;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(97, 0);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 24);
			this.btn_Delete.TabIndex = 3;
			this.btn_Delete.Text = "Excluir";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(330, 0);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 24);
			this.btn_Close.TabIndex = 1;
			this.btn_Close.Text = "Fechar";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(249, 0);
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
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ID.Location = new System.Drawing.Point(13, 9);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(19, 15);
			this.lb_ID.TabIndex = 0;
			this.lb_ID.Text = "ID";
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(12, 30);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(55, 20);
			this.tb_ID.TabIndex = 1;
			this.tb_ID.Enter += new System.EventHandler(this.tb_ID_Enter);
			this.tb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ID_KeyDown);
			// 
			// btn_Search
			// 
			this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Search.FlatAppearance.BorderSize = 0;
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Search.Image = global::Rock_Solid.Properties.Resources.Search_Button;
			this.btn_Search.Location = new System.Drawing.Point(381, 30);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(18, 20);
			this.btn_Search.TabIndex = 37;
			this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// frm_User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 200);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.lb_ID);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lb_Status);
			this.Controls.Add(this.cb_Status);
			this.Controls.Add(this.tb_Level);
			this.Controls.Add(this.lb_Level);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.lb_Password);
			this.Controls.Add(this.tb_Username);
			this.Controls.Add(this.lb_Username);
			this.Controls.Add(this.tb_Name);
			this.Controls.Add(this.lb_Name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frm_User";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Usuários";
			this.Activated += new System.EventHandler(this.tb_ID_Enter);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_User_FormClosed);
			this.Load += new System.EventHandler(this.frm_User_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_User_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.tb_Level)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.NumericUpDown tb_Level;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lb_ID;
        public System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Search;
	}
}