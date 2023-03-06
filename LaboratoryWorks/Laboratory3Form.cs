using System;
using System.Windows.Forms;

using Laboratory3Library;

namespace LaboratoryWorks
{
    public partial class Laboratory3Form : Form
    {
        public Laboratory3Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratory3TitleForm nextForm = new Laboratory3TitleForm();
            nextForm.Show();
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            double a = Laboratory3.GetDouble(aInput);
            double b = Laboratory3.GetDouble(bInput);
            double h = Laboratory3.GetDouble(hInput);

            double sum = Laboratory3.TabulateFunction(a, b, h, gridOutput);
            Laboratory3.OutputDouble(sumOutput, sum);
        }
    }
}
