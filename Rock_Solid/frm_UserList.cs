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
    public partial class frm_UserList : Form
    {
        public frm_UserList()
        {
            InitializeComponent();
        }

        private void frm_UserList_Load(object sender, EventArgs e)
        {
            dgv_UserList.DataSource = DataBase.UserList();
        }
    }
}
