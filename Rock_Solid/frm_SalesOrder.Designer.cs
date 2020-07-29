namespace Rock_Solid
{
	partial class frm_SalesOrder
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
			this.tc_SalesOrder = new System.Windows.Forms.TabControl();
			this.tp_Product = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label8 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.tp_ExpirationDate = new System.Windows.Forms.TabPage();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_New = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.button3 = new System.Windows.Forms.Button();
			this.tc_SalesOrder.SuspendLayout();
			this.tp_Product.SuspendLayout();
			this.tp_ExpirationDate.SuspendLayout();
			this.SuspendLayout();
			// 
			// tc_SalesOrder
			// 
			this.tc_SalesOrder.Controls.Add(this.tp_Product);
			this.tc_SalesOrder.Controls.Add(this.tp_ExpirationDate);
			this.tc_SalesOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tc_SalesOrder.Location = new System.Drawing.Point(0, 111);
			this.tc_SalesOrder.Name = "tc_SalesOrder";
			this.tc_SalesOrder.SelectedIndex = 0;
			this.tc_SalesOrder.Size = new System.Drawing.Size(677, 347);
			this.tc_SalesOrder.TabIndex = 0;
			// 
			// tp_Product
			// 
			this.tp_Product.BackColor = System.Drawing.SystemColors.Control;
			this.tp_Product.Controls.Add(this.button2);
			this.tp_Product.Controls.Add(this.label9);
			this.tp_Product.Controls.Add(this.listView1);
			this.tp_Product.Controls.Add(this.label8);
			this.tp_Product.Controls.Add(this.textBox9);
			this.tp_Product.Controls.Add(this.label7);
			this.tp_Product.Controls.Add(this.textBox8);
			this.tp_Product.Controls.Add(this.label6);
			this.tp_Product.Controls.Add(this.textBox7);
			this.tp_Product.Controls.Add(this.textBox6);
			this.tp_Product.Controls.Add(this.label5);
			this.tp_Product.Controls.Add(this.textBox5);
			this.tp_Product.Location = new System.Drawing.Point(4, 22);
			this.tp_Product.Name = "tp_Product";
			this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Product.Size = new System.Drawing.Size(669, 321);
			this.tp_Product.TabIndex = 0;
			this.tp_Product.Text = "Produtos";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(432, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 24);
			this.button2.TabIndex = 10;
			this.button2.Text = "Salvar Produto";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(129, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Descrição do Produto";
			// 
			// listView1
			// 
			this.listView1.AutoArrange = false;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.LabelWrap = false;
			this.listView1.Location = new System.Drawing.Point(11, 100);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(650, 213);
			this.listView1.TabIndex = 19;
			this.listView1.TileSize = new System.Drawing.Size(180, 30);
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Descrição";
			this.columnHeader1.Width = 277;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Código de Barras";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Qtde";
			this.columnHeader3.Width = 55;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Desconto";
			this.columnHeader4.Width = 64;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Valor Unit.";
			this.columnHeader5.Width = 69;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Total";
			this.columnHeader6.Width = 75;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(242, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "Valor Unitário";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(242, 75);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(106, 20);
			this.textBox9.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(126, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Desconto";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(126, 75);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(106, 20);
			this.textBox8.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Quantidade";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(11, 75);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(106, 20);
			this.textBox7.TabIndex = 13;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(129, 32);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(412, 20);
			this.textBox6.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Código de Barras";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(11, 32);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(106, 20);
			this.textBox5.TabIndex = 10;
			// 
			// tp_ExpirationDate
			// 
			this.tp_ExpirationDate.BackColor = System.Drawing.SystemColors.Control;
			this.tp_ExpirationDate.Controls.Add(this.button3);
			this.tp_ExpirationDate.Controls.Add(this.listView2);
			this.tp_ExpirationDate.Controls.Add(this.comboBox1);
			this.tp_ExpirationDate.Controls.Add(this.dateTimePicker1);
			this.tp_ExpirationDate.Controls.Add(this.label13);
			this.tp_ExpirationDate.Controls.Add(this.textBox13);
			this.tp_ExpirationDate.Controls.Add(this.label12);
			this.tp_ExpirationDate.Controls.Add(this.label11);
			this.tp_ExpirationDate.Controls.Add(this.textBox11);
			this.tp_ExpirationDate.Controls.Add(this.label10);
			this.tp_ExpirationDate.Location = new System.Drawing.Point(4, 22);
			this.tp_ExpirationDate.Name = "tp_ExpirationDate";
			this.tp_ExpirationDate.Padding = new System.Windows.Forms.Padding(3);
			this.tp_ExpirationDate.Size = new System.Drawing.Size(669, 321);
			this.tp_ExpirationDate.TabIndex = 1;
			this.tp_ExpirationDate.Text = "Vencimentos";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(14, 30);
			this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
			this.dateTimePicker1.TabIndex = 18;
			this.dateTimePicker1.Value = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(372, 10);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 13);
			this.label13.TabIndex = 17;
			this.label13.Text = "Nº Documento";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(372, 29);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(96, 20);
			this.textBox13.TabIndex = 16;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(231, 11);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "Cobrança";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(135, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Valor Parcela";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(135, 30);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(84, 20);
			this.textBox11.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Data Venc.";
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(565, 81);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(100, 24);
			this.btn_Close.TabIndex = 1;
			this.btn_Close.Text = "Fechar";
			this.btn_Close.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(565, 51);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(100, 24);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Salvar";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// btn_New
			// 
			this.btn_New.Location = new System.Drawing.Point(565, 21);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(100, 24);
			this.btn_New.TabIndex = 2;
			this.btn_New.Text = "Novo";
			this.btn_New.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 84);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(63, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(85, 84);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(463, 20);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
			this.textBox3.Location = new System.Drawing.Point(363, 28);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(112, 20);
			this.textBox3.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(376, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Total do Pedido";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(473, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Pesquisar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Pedido";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(15, 43);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(63, 20);
			this.textBox4.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(234, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 19;
			// 
			// listView2
			// 
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(11, 67);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(650, 246);
			this.listView2.TabIndex = 20;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(483, 26);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(133, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Lançar Vencimento";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// frm_SalesOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 458);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.btn_New);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tc_SalesOrder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_SalesOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_SalesOrder";
			this.tc_SalesOrder.ResumeLayout(false);
			this.tp_Product.ResumeLayout(false);
			this.tp_Product.PerformLayout();
			this.tp_ExpirationDate.ResumeLayout(false);
			this.tp_ExpirationDate.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tc_SalesOrder;
		private System.Windows.Forms.TabPage tp_Product;
		private System.Windows.Forms.TabPage tp_ExpirationDate;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}