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
	public partial class frm_Principal : Form
	{
		public frm_Principal()
		{
			InitializeComponent();
			frm_Login login = new frm_Login(this);
			login.ShowDialog();
		}
	}
}
