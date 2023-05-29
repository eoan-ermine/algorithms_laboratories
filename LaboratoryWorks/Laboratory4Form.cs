using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
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
            double epsilon, y_0;
            try
            {
                epsilon = LaboratoryWorks.GetDouble(eInput);
                y_0 = LaboratoryWorks.GetDouble(yInput);
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

            gridOutput.Rows.Clear();
            double y = LaboratoryWorks.TabulateSequence(gridOutput, y_0, epsilon);
            LaboratoryWorks.OutputDouble(yOutput, y);
        }
    }
}
