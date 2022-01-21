using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneUpgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            double monthlyCost = 0.0;

            if (cmbBoxModel.Text == "iPhone 12")
                {
                    monthlyCost = monthlyCost + 35.0;
                }
            else if (cmbBoxModel.Text == "iPhone 11")
                {
                    monthlyCost = monthlyCost + 30.0;
                }
            else if (cmbBoxModel.Text == "iPhone SE")
                {
                    monthlyCost = monthlyCost + 25.0;
                }

            if (rdoWhite.Checked)
                {
                monthlyCost = monthlyCost + 0.50;
                }

            foreach (String item in chckdListContract.CheckedItems)
                {
                    monthlyCost = monthlyCost + 5.0;
                }

            if (rdo64.Checked)
            {
                monthlyCost = monthlyCost + 2.50;
            }

            if (rdo128.Checked)
            {
                monthlyCost = monthlyCost + 5.0;
            }

            foreach (String item in chckdListAccessories.CheckedItems)
            {
                monthlyCost = monthlyCost + 0.50;
            }

            MessageBox.Show(monthlyCost.ToString());
        }
    }
}
