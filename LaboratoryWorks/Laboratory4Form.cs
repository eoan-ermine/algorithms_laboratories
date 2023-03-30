using System;
using System.Windows.Forms;

using Laboratory4Library;

namespace LaboratoryWorks
{
    public partial class Laboratory4Form : Form
    {
        public Laboratory4Form()
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
            Laboratory4TitleForm nextForm = new Laboratory4TitleForm();
            nextForm.Show();
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            double epsilon = Laboratory4.GetDouble(eInput);
            double y_0 = Laboratory4.GetDouble(yInput);

            gridOutput.Rows.Clear();
            double y = Laboratory4.TabulateFunction(gridOutput, y_0, epsilon);
            Laboratory4.OutputDouble(yOutput, y);
        }
    }
}
