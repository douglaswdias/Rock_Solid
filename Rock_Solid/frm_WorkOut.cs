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
	public partial class frm_WorkOut : Form
	{
		public frm_WorkOut()
		{
			InitializeComponent();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Print_Click(object sender, EventArgs e)
		{
			frm_Print print = new frm_Print();
			print.ShowDialog();
		}
	}
}
