namespace Rock_Solid
{
	partial class frm_ProductList
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
            this.lb_Filter = new System.Windows.Forms.Label();
            this.rb_BarCode = new System.Windows.Forms.RadioButton();
            this.rb_Description = new System.Windows.Forms.RadioButton();
            this.lb_Search = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.Location = new System.Drawing.Point(86, 5);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(35, 13);
            this.lb_Filter.TabIndex = 40;
            this.lb_Filter.Text = "Filtro: ";
            // 
            // rb_BarCode
            // 
            this.rb_BarCode.AutoSize = true;
            this.rb_BarCode.Location = new System.Drawing.Point(206, 3);
            this.rb_BarCode.Name = "rb_BarCode";
            this.rb_BarCode.Size = new System.Drawing.Size(106, 17);
            this.rb_BarCode.TabIndex = 39;
            this.rb_BarCode.Text = "Código de Barras";
            this.rb_BarCode.UseVisualStyleBackColor = true;
            // 
            // rb_Description
            // 
            this.rb_Description.AutoSize = true;
            this.rb_Description.Checked = true;
            this.rb_Description.Location = new System.Drawing.Point(127, 3);
            this.rb_Description.Name = "rb_Description";
            this.rb_Description.Size = new System.Drawing.Size(73, 17);
            this.rb_Description.TabIndex = 38;
            this.rb_Description.TabStop = true;
            this.rb_Description.Text = "Descrição";
            this.rb_Description.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(12, 27);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(71, 17);
            this.lb_Search.TabIndex = 37;
            this.lb_Search.Text = "Pesquisar";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(89, 26);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(519, 20);
            this.tb_Search.TabIndex = 36;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.AllowUserToAddRows = false;
            this.dgv_ProductList.AllowUserToDeleteRows = false;
            this.dgv_ProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProductList.EnableHeadersVisualStyles = false;
            this.dgv_ProductList.Location = new System.Drawing.Point(15, 51);
            this.dgv_ProductList.MultiSelect = false;
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ProductList.RowHeadersVisible = false;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(610, 386);
            this.dgv_ProductList.TabIndex = 35;
            this.dgv_ProductList.SelectionChanged += new System.EventHandler(this.dgv_ProductList_SelectionChanged);
            this.dgv_ProductList.DoubleClick += new System.EventHandler(this.dgv_ProductList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 36);
            this.panel1.TabIndex = 34;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(553, 1);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(72, 24);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Fechar";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // frm_ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 483);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Filter);
            this.Controls.Add(this.rb_BarCode);
            this.Controls.Add(this.rb_Description);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frm_ProductList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Search_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_Filter;
		private System.Windows.Forms.RadioButton rb_BarCode;
		private System.Windows.Forms.RadioButton rb_Description;
		private System.Windows.Forms.Label lb_Search;
		public System.Windows.Forms.TextBox tb_Search;
		public System.Windows.Forms.DataGridView dgv_ProductList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Select;
	}
}