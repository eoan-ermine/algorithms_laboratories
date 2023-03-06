using System;
using System.Windows.Forms;

using Laboratory2Library;

namespace LaboratoryWorks
{
    public partial class Laboratory2Form : Form
    {
        public Laboratory2Form()
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
            Laboratory2TitleForm nextForm = new Laboratory2TitleForm();
            nextForm.Show();
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            double a = Laboratory2.GetDouble(aInput);
            double b = Laboratory2.GetDouble(bInput);
            double x = Laboratory2.GetDouble(xInput);
            double y = Laboratory2.GetDouble(yInput);

            double result = Laboratory2.Evaluate(a, b, x, y);
            Laboratory2.OutputDouble(cOutput, result);
        }
    }
}
