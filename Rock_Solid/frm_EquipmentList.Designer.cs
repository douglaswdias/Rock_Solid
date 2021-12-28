
namespace Rock_Solid
{
    partial class frm_EquipmentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lb_Filter.Location = new System.Drawing.Point(86, 4);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(35, 13);
            this.lb_Filter.TabIndex = 47;
            this.lb_Filter.Text = "Filtro: ";
            // 
            // rb_BarCode
            // 
            this.rb_BarCode.AutoSize = true;
            this.rb_BarCode.Location = new System.Drawing.Point(206, 2);
            this.rb_BarCode.Name = "rb_BarCode";
            this.rb_BarCode.Size = new System.Drawing.Size(106, 17);
            this.rb_BarCode.TabIndex = 46;
            this.rb_BarCode.Text = "Código de Barras";
            this.rb_BarCode.UseVisualStyleBackColor = true;
            // 
            // rb_Description
            // 
            this.rb_Description.AutoSize = true;
            this.rb_Description.Checked = true;
            this.rb_Description.Location = new System.Drawing.Point(127, 2);
            this.rb_Description.Name = "rb_Description";
            this.rb_Description.Size = new System.Drawing.Size(73, 17);
            this.rb_Description.TabIndex = 45;
            this.rb_Description.TabStop = true;
            this.rb_Description.Text = "Descrição";
            this.rb_Description.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(12, 26);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(71, 17);
            this.lb_Search.TabIndex = 44;
            this.lb_Search.Text = "Pesquisar";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(89, 25);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(519, 20);
            this.tb_Search.TabIndex = 43;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.AllowUserToAddRows = false;
            this.dgv_ProductList.AllowUserToDeleteRows = false;
            this.dgv_ProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ProductList.EnableHeadersVisualStyles = false;
            this.dgv_ProductList.Location = new System.Drawing.Point(15, 50);
            this.dgv_ProductList.MultiSelect = false;
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ProductList.RowHeadersVisible = false;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(610, 386);
            this.dgv_ProductList.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 36);
            this.panel1.TabIndex = 41;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(553, 1);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(72, 24);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Fechar";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // frm_EquipmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 480);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Filter);
            this.Controls.Add(this.rb_BarCode);
            this.Controls.Add(this.rb_Description);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_EquipmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EquipmentList";
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