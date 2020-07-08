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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.lb_Filter = new System.Windows.Forms.Label();
            this.rb_Name = new System.Windows.Forms.RadioButton();
            this.rb_CPF = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 28);
            this.panel1.TabIndex = 21;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(271, 0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(72, 24);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(190, 0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(72, 24);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Selecionar";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.AllowUserToAddRows = false;
            this.dgv_UserList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.EnableHeadersVisualStyles = false;
            this.dgv_UserList.Location = new System.Drawing.Point(12, 71);
            this.dgv_UserList.MultiSelect = false;
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.ReadOnly = true;
            this.dgv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserList.Size = new System.Drawing.Size(514, 272);
            this.dgv_UserList.TabIndex = 22;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(89, 36);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(437, 20);
            this.tb_Search.TabIndex = 23;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(12, 36);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(71, 17);
            this.lb_Search.TabIndex = 24;
            this.lb_Search.Text = "Pesquisar";
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.Location = new System.Drawing.Point(86, 13);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(29, 13);
            this.lb_Filter.TabIndex = 25;
            this.lb_Filter.Text = "Filtro";
            // 
            // rb_Name
            // 
            this.rb_Name.AutoSize = true;
            this.rb_Name.Location = new System.Drawing.Point(131, 13);
            this.rb_Name.Name = "rb_Name";
            this.rb_Name.Size = new System.Drawing.Size(53, 17);
            this.rb_Name.TabIndex = 26;
            this.rb_Name.TabStop = true;
            this.rb_Name.Text = "Nome";
            this.rb_Name.UseVisualStyleBackColor = true;
            // 
            // rb_CPF
            // 
            this.rb_CPF.AutoSize = true;
            this.rb_CPF.Location = new System.Drawing.Point(190, 13);
            this.rb_CPF.Name = "rb_CPF";
            this.rb_CPF.Size = new System.Drawing.Size(45, 17);
            this.rb_CPF.TabIndex = 27;
            this.rb_CPF.TabStop = true;
            this.rb_CPF.Text = "CPF";
            this.rb_CPF.UseVisualStyleBackColor = true;
            // 
            // frm_UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.rb_CPF);
            this.Controls.Add(this.rb_Name);
            this.Controls.Add(this.lb_Filter);
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
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label lb_Filter;
        private System.Windows.Forms.RadioButton rb_Name;
        private System.Windows.Forms.RadioButton rb_CPF;
    }
}