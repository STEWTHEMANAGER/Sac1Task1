using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac1Task1
{
    public partial class Form1 : Form
    {
        float depreciation;
        float total;
        float value;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            value = calculate_worth((float)nudPrice.Value, (float)nudAge.Value);
            lblWorth.Text = "It is worth $" + value;
            total += value;
            lblTotalWorth.Text = "The collection so far is worth $" + total;
        }

        public float calculate_worth(float purchaseVal, float age)
        {
            depreciation = purchaseVal * 0.2f * age;
            if (depreciation > purchaseVal) { return 0f; }
            return purchaseVal - depreciation;
        }

        private void btnEndQuote_Click(object sender, EventArgs e)
        {
            total = 0;
            lblTotalWorth.Text = "";
            lblWorth.Text = "";
            nudPrice.Value = 0;
            nudAge.Value = 0;
        }
    }
}
