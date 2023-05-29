using System;
using System.Windows.Forms;

using LaboratoryWorksLibrary;

namespace LaboratoryWorksGUI
{
    public partial class Laboratory8Form : Form
    {
        int rows = 0, columns = 0, length = 0;
        int[] elements = null;
        int[,] sourceMatrix = null;
        int? minElement = null;

        public Laboratory8Form()
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
            Laboratory8TitleForm nextForm = new Laboratory8TitleForm();
            nextForm.Show();
        }

        public bool assertMatrix()
        {
            if (sourceMatrix == null)
            {
                MessageBox.Show("Пожалуйста, сгенерируйте матрицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool assertMinimum()
        {
            if (minElement == null)
            {
                MessageBox.Show("Пожалуйста, найдите минимальный элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool assertArray()
        {
            if (elements == null)
            {
                MessageBox.Show("Пожалуйста, сформируйте новый массив", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                columns = LaboratoryWorks.GetInt(columnsInput);
                rows = LaboratoryWorks.GetInt(rowsInput);
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

            if (columns <= 0 || rows <= 0 || columns > 25 || rows > 25)
            {
                MessageBox.Show("Количество строк (столбцов) должно лежать в диапазоне от 1 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            minElement = null;
            elements = null;
            sourceMatrix = new int[rows, columns];

            LaboratoryWorks.GenerateMatrix(sourceMatrix, rows, columns);
            LaboratoryWorks.OutputMatrix(sourceView, sourceMatrix, rows, columns);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix() || !assertMinimum())
                return;

            LaboratoryWorks.GetArrayFromMatrix(sourceMatrix, rows, columns, (int) minElement, ref elements, ref length);

            // Инициализация DataGridView
            resultView.ColumnCount = length;
            resultView.RowCount = 2;
            // Вывод массива в DataGridView
            for (int i = 0; i != length; ++i)
            {
                // Вывод индекса
                resultView.Rows[0].Cells[i].Value = "[" + i + "]";
                // Вывод значения
                resultView.Rows[1].Cells[i].Value = elements[i];
            }
        }

        private void createDatabaseButton_Click(object sender, EventArgs e)
        {
            LaboratoryWorks.CreateDatabase();
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            LaboratoryWorks.CreateMatrixTable(columns);
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix())
                return;

            LaboratoryWorks.WriteMatrixToPlainText(sourceMatrix, rows, columns);
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix() || !assertMinimum() || !assertArray())
                return;

            LaboratoryWorks.WriteResultToWord(sourceMatrix, rows, columns, elements, length);
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix() || !assertMinimum() || !assertArray())
                return;

            LaboratoryWorks.WriteResultToExcel(sourceMatrix, rows, columns, elements, length);
        }

        private void accessButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix())
                return;

            LaboratoryWorks.WriteMatrixToAccess(sourceMatrix, rows, columns);

        }

        private void minButton_Click(object sender, EventArgs e)
        {
            if (!assertMatrix())
                return;

            minElement = LaboratoryWorks.MinimumEvenElement(sourceMatrix, rows, columns);
            MessageBox.Show("Минимальный элемент среди четных элементов: " + minElement, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
