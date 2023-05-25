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

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            if (xInput.Text == "" || yInput.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите исходные данные", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x, y;
            try
            {
                x = LaboratoryWorks.GetDouble(xInput);
                y = LaboratoryWorks.GetDouble(yInput);
            } catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } catch (OverflowException)
            {
                MessageBox.Show("Слишком большое (маленькое) число", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
