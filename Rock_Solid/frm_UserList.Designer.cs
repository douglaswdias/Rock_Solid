namespace Rock_Solid
{
    partial class frm_UserList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Fechar = new System.Windows.Forms.Button();
			this.dgv_UserList = new System.Windows.Forms.DataGridView();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.lb_Search = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Fechar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 414);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(538, 36);
			this.panel1.TabIndex = 21;
			// 
			// btn_Fechar
			// 
			this.btn_Fechar.Location = new System.Drawing.Point(454, 1);
			this.btn_Fechar.Name = "btn_Fechar";
			this.btn_Fechar.Size = new System.Drawing.Size(72, 24);
			this.btn_Fechar.TabIndex = 2;
			this.btn_Fechar.Text = "Selecionar";
			this.btn_Fechar.UseVisualStyleBackColor = true;
			this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
			// 
			// dgv_UserList
			// 
			this.dgv_UserList.AllowUserToAddRows = false;
			this.dgv_UserList.AllowUserToDeleteRows = false;
			this.dgv_UserList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_UserList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_UserList.EnableHeadersVisualStyles = false;
			this.dgv_UserList.Location = new System.Drawing.Point(12, 49);
			this.dgv_UserList.MultiSelect = false;
			this.dgv_UserList.Name = "dgv_UserList";
			this.dgv_UserList.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_UserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_UserList.RowHeadersVisible = false;
			this.dgv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_UserList.Size = new System.Drawing.Size(514, 349);
			this.dgv_UserList.TabIndex = 22;
			this.dgv_UserList.SelectionChanged += new System.EventHandler(this.dgv_UserList_SelectionChanged);
			this.dgv_UserList.DoubleClick += new System.EventHandler(this.dgv_UserList_DoubleClick);
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(89, 14);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(437, 20);
			this.tb_Search.TabIndex = 23;
			this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
			// 
			// lb_Search
			// 
			this.lb_Search.AutoSize = true;
			this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Search.Location = new System.Drawing.Point(12, 14);
			this.lb_Search.Name = "lb_Search";
			this.lb_Search.Size = new System.Drawing.Size(71, 17);
			this.lb_Search.TabIndex = 24;
			this.lb_Search.Text = "Pesquisar";
			// 
			// frm_UserList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 450);
			this.Controls.Add(this.lb_Search);
			this.Controls.Add(this.tb_Search);
			this.Controls.Add(this.dgv_UserList);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_UserList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista de Usuários";
			this.Load += new System.EventHandler(this.frm_UserList_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label lb_Search;
        public System.Windows.Forms.DataGridView dgv_UserList;
        public System.Windows.Forms.TextBox tb_Search;
    }
}