namespace Rock_Solid
{
	partial class frm_ClientList
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
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_ClientList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Select = new System.Windows.Forms.Button();
            this.rb_Name = new System.Windows.Forms.RadioButton();
            this.rb_CPF = new System.Windows.Forms.RadioButton();
            this.lb_Filter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(12, 29);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(71, 17);
            this.lb_Search.TabIndex = 29;
            this.lb_Search.Text = "Pesquisar";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(89, 28);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(519, 20);
            this.tb_Search.TabIndex = 28;
            this.tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            // 
            // dgv_ClientList
            // 
            this.dgv_ClientList.AllowUserToAddRows = false;
            this.dgv_ClientList.AllowUserToDeleteRows = false;
            this.dgv_ClientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ClientList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ClientList.EnableHeadersVisualStyles = false;
            this.dgv_ClientList.Location = new System.Drawing.Point(15, 53);
            this.dgv_ClientList.MultiSelect = false;
            this.dgv_ClientList.Name = "dgv_ClientList";
            this.dgv_ClientList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ClientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ClientList.RowHeadersVisible = false;
            this.dgv_ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientList.Size = new System.Drawing.Size(610, 386);
            this.dgv_ClientList.TabIndex = 27;
            this.dgv_ClientList.SelectionChanged += new System.EventHandler(this.dgv_ClientList_SelectionChanged);
            this.dgv_ClientList.DoubleClick += new System.EventHandler(this.dgv_ClientList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 36);
            this.panel1.TabIndex = 26;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(553, 1);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(72, 24);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Selecionar";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // rb_Name
            // 
            this.rb_Name.AutoSize = true;
            this.rb_Name.Checked = true;
            this.rb_Name.Location = new System.Drawing.Point(127, 5);
            this.rb_Name.Name = "rb_Name";
            this.rb_Name.Size = new System.Drawing.Size(53, 17);
            this.rb_Name.TabIndex = 31;
            this.rb_Name.TabStop = true;
            this.rb_Name.Text = "Nome";
            this.rb_Name.UseVisualStyleBackColor = true;
            // 
            // rb_CPF
            // 
            this.rb_CPF.AutoSize = true;
            this.rb_CPF.Location = new System.Drawing.Point(189, 5);
            this.rb_CPF.Name = "rb_CPF";
            this.rb_CPF.Size = new System.Drawing.Size(77, 17);
            this.rb_CPF.TabIndex = 32;
            this.rb_CPF.Text = "CPF/CNPJ";
            this.rb_CPF.UseVisualStyleBackColor = true;
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.Location = new System.Drawing.Point(86, 7);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(35, 13);
            this.lb_Filter.TabIndex = 33;
            this.lb_Filter.Text = "Filtro: ";
            // 
            // frm_ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 481);
            this.Controls.Add(this.lb_Filter);
            this.Controls.Add(this.rb_CPF);
            this.Controls.Add(this.rb_Name);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_ClientList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ClientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.frm_ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_Search;
		public System.Windows.Forms.TextBox tb_Search;
		public System.Windows.Forms.DataGridView dgv_ClientList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Select;
		private System.Windows.Forms.RadioButton rb_Name;
		private System.Windows.Forms.RadioButton rb_CPF;
		private System.Windows.Forms.Label lb_Filter;
    }
}