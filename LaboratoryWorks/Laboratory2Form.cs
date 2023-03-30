using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
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
            double a = LaboratoryWorks.GetDouble(aInput);
            double b = LaboratoryWorks.GetDouble(bInput);
            double x = LaboratoryWorks.GetDouble(xInput);
            double y = LaboratoryWorks.GetDouble(yInput);

            double result = LaboratoryWorks.Evaluate(a, b, x, y);
            LaboratoryWorks.OutputDouble(cOutput, result);
        }
    }
}
