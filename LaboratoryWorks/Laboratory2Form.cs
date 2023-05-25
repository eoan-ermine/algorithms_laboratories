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
            double a, b, x, y;
            try
            {
                a = LaboratoryWorks.GetDouble(aInput);
                b = LaboratoryWorks.GetDouble(bInput);
                x = LaboratoryWorks.GetDouble(xInput);
                y = LaboratoryWorks.GetDouble(yInput);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое (маленькое) число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = LaboratoryWorks.Evaluate(a, b, x, y);
            LaboratoryWorks.OutputDouble(cOutput, result);
        }
    }
}
