using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbTang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTang.Checked == true)
            {
                gbXoa.Enabled = true;
                gbThem.Enabled = true;
            }
            else
            {
                gbXoa.Enabled = false;
                gbThem.Enabled = false;
            }


        }

    }
}
