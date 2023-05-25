using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
{
    public partial class Laboratory7Form : Form
    {
        int length = 0;
        int[] array;

        public Laboratory7Form()
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
            Laboratory7TitleForm nextForm = new Laboratory7TitleForm();
            nextForm.Show();
        }

        bool assertGeneration()
        {
            if (length == 0)
            {
                MessageBox.Show("Пожалуйста, сгенерируйте массив", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (lengthInput.Text == "" || lengthInput.Text == "0")
            {
                MessageBox.Show("Пожалуйста, введите корректное количество элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lengthInput.Focus();
                return;
            }
            if (aInput.Text == "" || bInput.Text == "")
            {
                MessageBox.Show("Пожалуйста, задайте корректные пределы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            length = LaboratoryWorks.GetInt(lengthInput);
            int A = LaboratoryWorks.GetInt(aInput);
            int B = LaboratoryWorks.GetInt(bInput);

            array = new int[length];

            LaboratoryWorks.GenerateArray(array, length, A, B + 1);
            LaboratoryWorks.OutputArray(outputView, array, length);
            LaboratoryWorks.ArrayElementsSum(array, length, out int sum);
            LaboratoryWorks.CountElements(array, length, out int odd, out int even);

            if (sum % 2 == 0)
                LaboratoryWorks.OutputResult(odd);
            else
                LaboratoryWorks.OutputResult(even);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            string userInput = Interaction.InputBox("Пожалуйста, введите индекс элемента для удаления", "Ввод", "0");
            try
            {
                int index = Convert.ToInt32(userInput);
                if (index < 0 || index >= length)
                {
                    MessageBox.Show("Введенный индекс лежит вне границ массива", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LaboratoryWorks.RemoveElement(array, ref length, index);
                LaboratoryWorks.OutputArray(outputView, array, length);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректный индекс элемента для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monotonicButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            bool isMonotonic = length == 1 || LaboratoryWorks.IsMonotonic(array, length);
            if (isMonotonic)
            {
                MessageBox.Show(
                    "Последовательность элементов массива является монотонно убывающей", "Вывод",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            } else
            {
                MessageBox.Show(
                    "Последовательность элементов массива не является монотонно убывающей", "Вывод",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            LaboratoryWorks.BinarySort(array, length);
            LaboratoryWorks.OutputArray(outputView, array, length);
            MessageBox.Show("Сортировка выполнена успешно", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            LaboratoryWorks.WriteArrayToPdf(array, length);
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            LaboratoryWorks.WriteArrayToWord(array, length);

        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            LaboratoryWorks.WriteArrayToExcel(array, length);

        }

        private void createDatabaseButton_Click(object sender, EventArgs e)
        {
            LaboratoryWorks.CreateDatabase();
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            LaboratoryWorks.CreateArrayTable();
        }

        private void accessButton_Click(object sender, EventArgs e)
        {
            if (assertGeneration())
                return;

            LaboratoryWorks.WriteArrayToAccess(array, length);
        }

        private void macroButton_Click(object sender, EventArgs e)
        {
            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbooks books = app.Workbooks;
            Microsoft.Office.Interop.Excel._Workbook book = null;
            try
            {
                book = books.Open(path + "\\output.xlsm");
                app.Run((object)"Button1_Click");
                app.ScreenUpdating = true;
            }
            catch (Exception exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
