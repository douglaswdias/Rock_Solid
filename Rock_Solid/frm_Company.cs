﻿using System;
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
	public partial class frm_Company : Form
	{
		public frm_Company()
		{
			InitializeComponent();
		}

        private void btn_Close_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}