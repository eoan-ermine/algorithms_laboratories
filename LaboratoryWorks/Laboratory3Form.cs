using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
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
            double a = LaboratoryWorks.GetDouble(aInput);
            double b = LaboratoryWorks.GetDouble(bInput);
            double h = LaboratoryWorks.GetDouble(hInput);

            gridOutput.Rows.Clear();
            double min = LaboratoryWorks.TabulateFunction(gridOutput, a, b, h);
            LaboratoryWorks.OutputDouble(minOutput, min);
        }
    }
}
