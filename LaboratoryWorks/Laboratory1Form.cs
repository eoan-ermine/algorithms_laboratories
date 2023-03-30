using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
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
            double x = LaboratoryWorks.GetDouble(xInput);
            double y = LaboratoryWorks.GetDouble(yInput);

            double z = LaboratoryWorks.Evaluate(x, y);
            LaboratoryWorks.OutputDouble(zOutput1, z);

            LaboratoryWorks.Evaluate(x, y, out double res);
            LaboratoryWorks.OutputDouble(zOutput2, res);

            double result = 0;
            LaboratoryWorks.ReferenceEvaluate(x, y, ref result);
            LaboratoryWorks.OutputDouble(zOutput3, result);
        }
    }
}
