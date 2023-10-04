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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txbA.Text), b = double.Parse(txbB.Text);
            if(rbBac1.Checked == true)
            {

                if(a == 0)
                {
                    txbKQ.Text = "Phương trình không phải bậc nhất.";
                }
                else
                {
                    double x = - b/a;
                    txbKQ.Text = "Nghiệm của phương trình: x = " + x;
                }
            }
            else if(rbBac2.Checked == true)
            {
                double c = double.Parse(txbC.Text);
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txbKQ.Text = "Phương trình không có nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txbKQ.Text = "Nghiệm kép của phương trình: x = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txbKQ.Text = "Nghiệm của phương trình: x1 = " + x1 + ", x2 = " + x2;
                }

            }
        }

        private void rbBac2_CheckedChanged(object sender, EventArgs e)
        {
            lbC.Enabled = true;
            txbC.Enabled = true;

        }

        private void rbBac1_CheckedChanged(object sender, EventArgs e)
        {
            lbC.Enabled = false;
            txbC.Enabled = false;
        }
        private void txbC_TextChanged(object sender, EventArgs e)
        {
            if (rbBac1.Checked == true)
            {
                if (!string.IsNullOrEmpty(txbA.Text) && !string.IsNullOrEmpty(txbB.Text))
                    btnGiai.Enabled = true;
                else
                    btnGiai.Enabled = false;
            }
            else if (rbBac2.Checked == true)
            {
                if (!string.IsNullOrEmpty(txbA.Text) && !string.IsNullOrEmpty(txbB.Text) && !string.IsNullOrEmpty(txbC.Text))
                    btnGiai.Enabled = true;
                else
                    btnGiai.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txbA.Clear();
            txbB.Clear();
            txbC.Clear();
            txbKQ.Clear();

            txbA.Focus();
        }
    }
}
