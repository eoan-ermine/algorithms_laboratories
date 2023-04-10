using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
{
    public partial class Laboratory5Form : Form
    {
        public Laboratory5Form()
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
            Laboratory5TitleForm nextForm = new Laboratory5TitleForm();
            nextForm.Show();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (lengthInput.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите количество элементов", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lengthInput.Focus();
                return;
            }
            
            int length = LaboratoryWorks.GetInt(lengthInput);
            int A = LaboratoryWorks.GetInt(aInput);
            int B = LaboratoryWorks.GetInt(bInput);

            int[] array = new int[length];

            LaboratoryWorks.GenerateArray(array, length, A, B + 1);
            LaboratoryWorks.OutputArray(outputView, array, length);
            LaboratoryWorks.ArrayElementsSum(array, length, out int sum);
            LaboratoryWorks.CountElements(array, length, out int odd, out int even);

            if (sum % 2 == 0)
                LaboratoryWorks.OutputResult(odd);
            else
                LaboratoryWorks.OutputResult(even);
        }
    }
}
