using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Solid
{
	public partial class frm_Client : Form
	{
		public frm_Client()
		{
			InitializeComponent();
		}

		private void rb_PhysicalPerson_Click(object sender, EventArgs e)
		{
			tb_CPF.Clear();
			tb_CPF.Size = new Size(73, 20);
			lb_CPF.Text = "CFP";
			tb_CPF.Mask = "00.000.000-0";
		}

		private void rb_LegalPerson_Click(object sender, EventArgs e)
		{
			tb_CPF.Clear();
			tb_CPF.Size = new Size(107, 20);
			lb_CPF.Text = "CNPJ";
			tb_CPF.Mask = "00.000.000/0000-00";
		}
	}
}
