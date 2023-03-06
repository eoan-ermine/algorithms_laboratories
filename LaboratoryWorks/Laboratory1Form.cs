using System;
using System.Windows.Forms;

using Laboratory1Library;

namespace LaboratoryWorks
{
    public partial class Laboratory1Form : Form
    {
        public Laboratory1Form()
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
            Laboratory1TitleForm nextForm = new Laboratory1TitleForm();
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Laboratory1.GetDouble(xInput);
            double y = Laboratory1.GetDouble(yInput);

            double z = Laboratory1.Evaluate(x, y);
            Laboratory1.OutputDouble(zOutput1, z);

            Laboratory1.Evaluate(x, y, out double res);
            Laboratory1.OutputDouble(zOutput2, res);

            double result = 0;
            Laboratory1.ReferenceEvaluate(x, y, ref result);
            Laboratory1.OutputDouble(zOutput3, result);
        }
    }
}
