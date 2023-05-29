using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LaboratoryWorksLibrary
{
    public class LaboratoryWorks
    {
        /* Все лабораторные работы */
        public static double GetDouble(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void OutputDouble(TextBox t, double value)
        {
            t.Text = Convert.ToString(value);
        }

        /* Первая лабораторная работа */
        public static double Evaluate(double x, double y)
        {
            return Math.Pow(1 + (1 / (x * x)), x) - 12 * x * x * y;
        }
        public static void Evaluate(double x, double y, out double z)
        {
            z = Math.Pow(1 + (1 / (x * x)), x) - 12 * x * x * y;
        }
        public static void ReferenceEvaluate(double x, double y, ref double z)
        {
            z = Math.Pow(1 + (1 / (x * x)), x) - 12 * x * x * y;
        }

        /* Вторая лабораторная работа */
        public static double Evaluate(double a, double b, double x, double y)
        {
            double z;
            if (x > a && y > 0)
            {
                double maxOp1 = x * x + y * y;
                double maxOp2 = Math.Pow(a, x) + Math.Pow(y, a);

                double maxVal = maxOp1;
                if (maxOp2 > maxVal) maxVal = maxOp2;

                double minOp = Math.Sqrt(x) + Math.Sqrt(Math.Pow(a, x));
                if (maxVal < minOp) z = maxVal;
                else z = minOp;
            }
            else if (x <= a && y >= 0 && y <= 3 * x)
            {
                double minOp1 = a + b;
                double minOp2 = Math.Pow(x, a + b);

                double minVal = minOp1;
                if (minOp2 < minVal) minVal = minOp2;

                z = minVal / (1 + a + Math.Pow(b, a));
            }
            else z = Math.Pow(Math.Tan(Math.Abs(x + y)), 2);
            return z;
        }

        /* Третья лабораторная работа */
        public static double CalculateExpression(double x)
        {
            return Math.Pow(Math.Log(x), 2) / x;
        }
        public static void OutputViewRow(DataGridView view, double x, double y)
        {
            view.Rows.Add(x, y);
        }
        public static double TabulateFunction(DataGridView view, double a, double b, double h)
        {
            double min = Double.MaxValue;
            double x = a;
            int n = Convert.ToInt32(Math.Round((b - a) / h + 1));

            for (int i = 1; i <= n; ++i)
            {
                double y = LaboratoryWorks.CalculateExpression(x);
                if (y < min) min = y;
                LaboratoryWorks.OutputViewRow(view, x, y);
                x += h;
            }

            return min;
        }

        /* Четвертая лабораторная работа */
        public static double CalculateSequenceMember(double previous)
        {
            return (previous + 1) / (previous + 2);
        }
        public static double TabulateSequence(DataGridView view, double start, double e)
        {
            double previous = start;
            double current = LaboratoryWorks.CalculateSequenceMember(previous);

            LaboratoryWorks.OutputViewRow(view, 0, previous);
            LaboratoryWorks.OutputViewRow(view, 1, current);

            int i = 2;
            while (current - previous >= e)
            {
                previous = current;
                current = LaboratoryWorks.CalculateSequenceMember(previous);
                LaboratoryWorks.OutputViewRow(view, i, current);
                i += 1;
            }

            return current;
        }

        /* Пятая лабораторная работа */
        // Конвертация текста из TextBox в целочисленное значение
        public static int GetInt(TextBox t)
        {
            return Convert.ToInt32(t.Text);
        }
        
        // Генерация массива — заполнение его случайными числами
        public static void GenerateArray(int[] array, int length, int a, int b)
        {
            // Инициализация генератора рандомных чисел
            Random rnd = new Random();
            // Заполнение массива рандомными числами
            for (int i = 0; i != length; ++i)
                array[i] = rnd.Next(a, b);
        }

        // Вывод массива в элемент DataGridView
        public static void OutputArray(DataGridView grid, int[] array, int length)
        {
            // Инициализация DataGridView
            grid.ColumnCount = length;
            grid.RowCount = 2;
            // Вывод массива в DataGridView
            for (int i = 0; i != length; ++i)
            {
                // Вывод индекса
                grid.Rows[0].Cells[i].Value = "[" + i + "]";
                // Вывод значения
                grid.Rows[1].Cells[i].Value = array[i];
            }
        }

        // Подсчет суммы элементов массива (по значению)
        public static void ArrayElementsSum(int[] array, int length, out int sum)
        {
            // Инициализация суммы
            sum = 0;
            // Подсчет суммы элементов массива (по значению)
            for (int i = 0; i != length; ++i)
                sum += array[i];
        }

        // Подсчет количества четных и нечетных элементов в массиве
        public static void CountElements(int[] array, int length, out int odd, out int even)
        {
            // Инициализация счетчиков четных и нечетных чисел
            odd = 0;
            even = 0;

            // Итерируемся по массиву и обновляем счетчики
            for (int i = 0; i != length; ++i)
                if (array[i] % 2 == 0)
                    even += 1;
                else
                    odd += 1;
        }

        // Вывод результата
        public static void OutputResult(int result)
        {
            MessageBox.Show("Ответ: " + result, "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Шестая лабораторная работа */
        // Удаление элемента из одномерного массива
        public static void RemoveElement(int[] array, ref int length, int index)
        {
            // Элементы, входящие в диапазон [index + 1; length] сдвигаются на один элемент влево
            for (int i = index; i != length - 1; ++i)
            {
                array[i] = array[i + 1];
            }
            // Обновление длины массива
            length = length - 1;
        }

        // Определение на монотонность
        public static bool IsMonotonic(int[] array, int length)
        {
            // Текущий индекс
            int i = 1;
            // Флаг — составляют ли элементы массива монотонно убывающую последовательность
            bool flag = true;

            // Итерируемся до (не включительно) последнего элемента массива
            // Причем, если мы уже обнаружили, что монотонность нарушается — итерироваться дальше нет смысла
            while (i <= length - 1 && flag == true)
                // Проверка условия монотонности
                if (array[i] >= array[i + 1])
                    i = i + 1;
                else
                    flag = false;

            return flag;
        }

        // Сортировка бинарными вставками (включениями)
        public static void BinarySort(int[] array, int length)
        {
            // Начинаем цикл для перебора всех элементов исходного массива
            for (int i = 1; i != length; ++i)
            {
                // Присваиваем x значение очередного элемента массива
                int x = array[i];
                // left — левая граница отсортированного массива, right — его правая граница
                // Устанавливаем левую и правую границы отсортированной части массива
                int left = 0, right = i - 1;

                // Пока левая граница отсортированного масисва не превосходит правую, выполняем тело цикла
                while (left <= right)
                {
                    // Нахождение среднего по положению элеента отсортированной части массива
                    int middle = (left + right) / 2;
                    // Сравнение значения с найденным элементом
                    if (x < array[middle])
                        // Корректируем правую границу массива
                        right = middle - 1;
                    else
                        // Корректируем левую границу массива
                        left = middle + 1;
                }
                // Мы нашли положение вставляемого элемента
                // Сдвиг элементов массива для вставки значения x
                for (int j = i - 1; j >= left; --j)
                    array[j + 1] = array[j];
                // Вставка значения в отсортированную часть массива
                array[left] = x;
            }
        }

        /* Седьмая лабораторная работа */
        
        // Запись массива в pdf файл
        public static void WriteArrayToPdf(int[] array, int length)
        {
            var document = new Document();
            // Создание файла
            var instance = PdfWriter.GetInstance(document, new System.IO.FileStream("output.pdf", System.IO.FileMode.Create));
            document.Open();
            // Создание шрифта
            var baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);
            var font = new Font(baseFont, 10, Font.NORMAL, BaseColor.BLUE);
            // Создание таблицы
            var table = new PdfPTable(1);
            
            // Создание заголовка таблицы
            var cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Colspan = 2;
            cell.Border = 0;
            cell.FixedHeight = 16.0F;
            cell.Phrase = new Phrase("Массив", font);
            table.AddCell(cell);
            cell.BackgroundColor = BaseColor.WHITE;
            cell.Colspan = 1;
            cell.Border = 15;

            // Заполнение таблицы значениями
            for (int i = 0; i != length; ++i)
            {
                cell.Phrase = new Phrase(array[i].ToString(), font);
                table.AddCell(cell);
            }

            // Вывод таблицы в pdf файл
            table.TotalWidth = document.PageSize.Width - 500;
            table.WriteSelectedRows(0, -1, 150, 750, instance.DirectContent);
            document.Close();
            instance.Close();
            // Запуск браузера для просмотра pdf файла
            System.Diagnostics.Process.Start("msedge.exe", System.IO.Directory.GetCurrentDirectory() + @"\output.pdf");
        }

        // Запись массива в документ Microsoft Word
        public static void WriteArrayToWord(int[] array, int length)
        {
            // Создание приложения Microsoft Word
            var Word = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true
            };
            var inf = Type.Missing;
            // Создание нового документа
            var Document = Word.Documents.Add(inf);
            // Добавление заголовка
            Word.Selection.TypeText("Массив");

            object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

            // Создание таблицы
            var table = Word.ActiveDocument.Tables.Add(Word.Selection.Range, 2, length, t1, t2);
            for (int i = 0; i != length; ++i)
            {
                // Индекс элемента в массиве
                table.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                // Значение элемента
                table.Cell(2, i + 1).Range.InsertAfter(String.Format("{0:f0}", array[i]));
            }
        }

        // Запись массива в документ Microsoft Excel, создание макроса и кнопки
        public static void WriteArrayToExcel(int[] array, int length)
        {
            // Создание приложения Microsoft Excel
            var Excel = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            var workBook = Excel.Workbooks.Add();

            // Создание рабочего листа
            var workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            // Задание названия рабочего листа
            workSheet.Name = "Массив";
            // Заголовок массива
            workSheet.Cells[1, 1] = "Массив";

            // Вывод элементов массива
            for (int i = 0; i != length; ++i)
            {
                workSheet.Cells[2, i + 1] = "[" + i + "]";
                workSheet.Cells[3, i + 1] = array[i].ToString();
            }

            // Форматирование элементов массива: установка шрифта, установка границ
            Microsoft.Office.Interop.Excel.Range range = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[3, length]];
            range.Cells.Font.Name = "Times New Roman";
            range.Cells.Font.Size = 14;
            range.Cells.Columns.AutoFit();
            range.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle
                    = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // нижняя граница для всего диапазона
            range.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle
                = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // правая граница для всего диапазона
            range.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal).LineStyle
                    = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // горизонтальная граница для внутренних ячеек
            range.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical).LineStyle
                    = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // вертикальная граница для внутренних ячеек
            range.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle
                    = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // верхняя граница для всего диапазона

            // Создание модуля для записи макроса
            var newStandardModule = workBook.VBProject.VBComponents.Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule);
            var codeModule = newStandardModule.CodeModule;

            // Запись макроса для построения диаграммы
            var lineNum = codeModule.CountOfLines + 1;
            var macroName = "Button1_Click";
            var codeText = "Public Sub " + macroName + "()" + "\r\n";
            codeText += string.Format(@"Range(""A5"").Select
    ActiveCell.FormulaR1C1 = ""Количество четных элементов""
    Range(""A6"").Select
    ActiveCell.FormulaR1C1 = ""Количество нечетных элементов""
    Range(""B5"").Select
    ActiveCell.Formula2R1C1 = _
        ""=SUMPRODUCT(ISNUMBER(R[-2]C[-1]:R[-2]C[16377])*(MOD(R[-2]C[-1]:R[-2]C[16377],2)=0))""
    Range(""B6"").Select
    ActiveCell.Formula2R1C1 = _
        ""=SUMPRODUCT(ISNUMBER(R[-3]C[-1]:R[-3]C[16377])*(MOD(R[-3]C[-1]:R[-3]C[16377],2)<>0))""
    Range(""A5:B6"").Select
    ActiveSheet.Shapes.AddChart2(216, xlBarClustered).Select
    ActiveChart.SetSourceData Source:=Range(""Массив!$A$5:$B$6"")
    ActiveChart.ChartTitle.Select
    ActiveChart.ChartTitle.Text = ""Элементы по четности""
    Selection.Format.TextFrame2.TextRange.Characters.Text = ""Элементы по четности""
", length, length + 1);
            codeText += "End Sub";

            // Запись макроса в модуль
            codeModule.InsertLines(lineNum, codeText);

            // Добавление кнопки для построения диаграммы
            range = workSheet.get_Range("A8:J9");
            Microsoft.Office.Interop.Excel.Buttons xlButtons = workSheet.Buttons();
            Microsoft.Office.Interop.Excel.Button xlButton = xlButtons.Add((double)range.Left, (double)range.Top, (double)range.Width, (double)range.Height);

            xlButton.Name = "macroButton";
            xlButton.Text = "Построить диаграмму";
            xlButton.OnAction = "Button1_Click";

            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            // Сохраняем документ
            workBook.SaveAs(path + "\\output.xlsm", (object)Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled);
            Excel.UserControl = true;
        }

        // Создание базы данных Microsoft Access
        public static void CreateDatabase()
        {
            // Каталог объектов Active X
            var catalog = new ADOX.Catalog();
            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            try
            {
                // Создаем новую базу данных
                catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" +
                    path.ToString().Replace("\\", "\\\\") + "\\Database.mdb");
            } catch (System.Runtime.InteropServices.COMException exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                catalog = null;
            }
        }

        private static OleDbConnection ConnectToDatabase()
        {
            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            // Устанавливаем соединение с базой данных
            var connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " +
        path.ToString().Replace("\\", "\\\\") + "\\Database.mdb");
            connection.Open();

            return connection;
        }

        private static void ExecuteCommand(OleDbConnection connection, String query)
        {
            // Формируем запрос к базе данных
            var command = new OleDbCommand(query, connection);
            // Исполняем запрос
            command.ExecuteNonQuery();
        }

        // Создание таблицы в базе данных Microsoft Access
        public static void CreateArrayTable()
        {            
            try
            {
                // Устанавливаем соединение с базой данных
                var connection = ConnectToDatabase();

                // Формируем запрос на создание таблицы с двумя колонками: индекс, значение
                ExecuteCommand(connection, "CREATE TABLE [array]([Индекс] numeric, [Значение] numeric)");

                // Завершаем соединение
                connection.Close();
            }
            catch (Exception exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Запись массива в базу данных Microsoft Access
        public static void WriteArrayToAccess(int[] array, int length)
        {
            try
            {
                // Устанавливаем соединение с базой данных
                var connection = ConnectToDatabase();

                // Исполняем запрос на удаление всех строк в базе данных
                ExecuteCommand(connection, "DELETE * FROM [array]");

                for (int i = 0; i != length; ++i)
                {
                    ExecuteCommand(connection, "INSERT INTO[array]([Индекс], [Значение]) VALUES(" + i + ", " + array[i].ToString() + ")");
                }

                // Завершаем соединение
                connection.Close();
            }
            catch (Exception exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RunAccessMacro()
        {
            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbooks books = app.Workbooks;
            Microsoft.Office.Interop.Excel._Workbook book = null;

            book = books.Open(path + "\\output.xlsm");
            app.Run((object)"Button1_Click");
            app.ScreenUpdating = true;
        }

        /* Восьмая лабораторная работа */

        public static void CreateMatrixTable(int columns)
        {
            try
            {
                // Устанавливаем соединение с базой данных
                var connection = ConnectToDatabase();

                ExecuteCommand(connection, "DROP TABLE Matrix");
                var query = "CREATE TABLE [Matrix]([Rows] counter";
                for (int i = 0; i != columns; ++i)
                {
                    query = query + ", [" + "Col" + Convert.ToString(i + 1) + "] char(5)";
                }
                ExecuteCommand(connection, query + ")");

                // Завершаем соединение
                connection.Close();
            }
            catch (Exception exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void WriteMatrixToAccess(int[,] matrix, int rows, int columns)
        {
            try
            {
                var connection = ConnectToDatabase();

                // Исполняем запрос на удаление всех строк в базе данных
                ExecuteCommand(connection, "DELETE * FROM [Matrix]");
                for (int i = 0; i != rows; ++i)
                {
                    var cmdString = "INSERT INTO [Matrix] ([Rows]";
                    var cmdString2 = ") VALUES (" + "'" + Convert.ToString(i + 1) + "'";
                    for (int j = 0; j != columns; ++j)
                    {
                        cmdString = cmdString + ", [Col" + Convert.ToString(j + 1) + "]";
                        cmdString2 = cmdString2 + ", '" + Convert.ToString(matrix[i, j]) + "'";
                    }
                    cmdString2 = cmdString2 + ")";
                    ExecuteCommand(connection, cmdString + cmdString2);
                }
                connection.Close();
            }
            catch (Exception exception)
            {
                // Если что-то пошло не так, выводим информацию об ошибке
                MessageBox.Show(exception.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void WriteMatrixToPlainText(int[,] matrix, int rows, int columns)
        {
            StreamWriter stream = new StreamWriter("output.txt");
            for (int i = 0; i != columns; ++i)
            {
                for (int j = 0; j != rows; ++j)
                    stream.Write(matrix[i, j] + "\t");
                stream.WriteLine("\n");
            }
            stream.Close();

            // Запуск блокнота для просмотра файла
            System.Diagnostics.Process.Start("notepad.exe", System.IO.Directory.GetCurrentDirectory() + @"\output.txt");

        }

        public static void WriteResultToExcel(int[,] matrix, int rows, int columns, int[] array, int length)
        {
            // Создание приложения Microsoft Excel
            var Excel = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            var workBook = Excel.Workbooks.Add();
            // Создание рабочего листа
            var workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            // Задание названия рабочего листа
            workSheet.Name = "Массивы";

            for (int i = 0; i != columns; ++i)
            {
                for (int j = 0; j != rows; ++j)
                {
                    workSheet.Cells[i + 1, j + 1] = matrix[i, j];
                }
            }
            workSheet.Cells[rows + 3, 1] = "Результирующий массив";
            for (int i = 0; i != length; ++i)
            {
                workSheet.Cells[rows + 4, i + 1] = "[" + i + "]";
                workSheet.Cells[rows + 5, i + 1] = array[i];
            }


            // Создание модуля для записи макроса
            var newStandardModule = workBook.VBProject.VBComponents.Add(Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule);
            var codeModule = newStandardModule.CodeModule;

            // Запись макроса для форматирования таблицы
            var lineNum = codeModule.CountOfLines + 1;
            var macroName = "Button1_Click";
            var codeText = "Public Sub " + macroName + "()" + "\r\n";
            var columnCharacter = (char) (64 + columns);
            codeText += string.Format(@"Range(""A1:{0}{1}"").Select
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
", columnCharacter, rows);
            codeText += "End Sub";

            // Запись макроса в модуль
            codeModule.InsertLines(lineNum, codeText);

            // Добавление кнопки для построения диаграммы
            var range = workSheet.get_Range(String.Format("A{0}:J{1}", rows + 7, rows + 8));
            Microsoft.Office.Interop.Excel.Buttons xlButtons = workSheet.Buttons();
            Microsoft.Office.Interop.Excel.Button xlButton = xlButtons.Add((double)range.Left, (double)range.Top, (double)range.Width, (double)range.Height);

            xlButton.Name = "macroButton";
            xlButton.Text = "Отформатировать таблицу";
            xlButton.OnAction = "Button1_Click";

            // Находим директорию, в которой находится исполняемый файл
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = System.IO.Path.GetDirectoryName(location);

            // Сохраняем документ
            workBook.SaveAs(path + "\\output.xlsm", (object)Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled);
            Excel.UserControl = true;
        }

        public static void WriteResultToWord(int[,] matrix, int rows, int columns, int[] array, int length)
        {
            // Создание приложения Microsoft Word
            var Word = new Microsoft.Office.Interop.Word.Application();
            var inf = Type.Missing;
            // Создание нового документа
            var Document = Word.Documents.Add(inf);
            // Добавление заголовка
            Word.Selection.TypeText("Исходный массив");

            object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

            // Создание таблицы
            var table = Word.ActiveDocument.Tables.Add(Word.Selection.Range, columns + 1, rows + 1, t1, t2);
            for (int i = 0; i != columns; ++i)
                table.Cell(i + 2, 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
            for (int j = 0; j != rows; ++j)
                table.Cell(1, j + 2).Range.InsertAfter("[" + Convert.ToString(j) + "]");
            for (int i = 0; i != columns; ++i)
                for (int j = 0; j != rows; ++j)
                {
                    var str = String.Format("{0:f2}", matrix[i, j]);
                    table.Cell(i + 2, j + 2).Range.InsertAfter(str);
                }

            object t3 = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            object add_str = columns + 2;

            Word.Selection.MoveDown(t3, add_str, inf);
            Word.Selection.TypeText("Количество элементов матрицы, значения которых больше значения минимального элемента матрицы: " + length + "\nРезультирующий массив");
            table = Word.ActiveDocument.Tables.Add(Word.Selection.Range, 2, length, t1, t2);
            for (int i = 0; i != length; ++i)
            {
                table.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                var str = String.Format("{0:f2}", array[i]);
                table.Cell(2, i + 1).Range.InsertAfter(str);
            }

            Word.Visible = true;
        }

        // Заполнение двумерного массива псевдослучайными числами
        public static void GenerateMatrix(int[,] matrix, int rows, int columns)
        {
            // Инициализация генератора случайных чисел
            Random random = new Random();
            for (int i = 0; i != rows; ++i)
            {
                for (int j = 0; j != columns; ++j)
                {
                    matrix[i, j] = random.Next(-100, 100); ;
                }
            }
        }

        // Вывод массива в компонент DataGridView
        public static void OutputMatrix(DataGridView view, int[,] matrix, int rows, int columns)
        {
            // Очистка компонента от предыдущего содержания
            view.Columns.Clear();
            view.Rows.Clear();

            var headerColumn = new DataGridViewTextBoxColumn();
            headerColumn.HeaderText = "[" + rows + "]" + "[" + columns + "]";
            headerColumn.Width = 50;
            view.Columns.Add(headerColumn);

            // Создание столбцов
            for (int i = 0; i != columns; ++i)
            {
                var newColumn = new DataGridViewTextBoxColumn();
                newColumn.HeaderText = "[" + i + "]";
                newColumn.Width = 40;
                view.Columns.Add(newColumn);
            }

            // Заполнение компонента актуальной информацией
            for (int i = 0; i != rows; ++i)
            {
                var newRow = new DataGridViewRow();
                view.Rows.Add(newRow);

                view.Rows[i].Cells[0].Value = "[" + i + "]";
                for (int j = 0; j != columns; ++j)
                {
                    view.Rows[i].Cells[j + 1].Value = matrix[i, j];
                }
            }
        }

        // Нахождение минимального четного (по значению) элемента в двумерном массиве
        public static int? MinimumEvenElement(int[,] matrix, int rows, int columns)
        {
            int? minElement = null;
            for (int i = 0; i != rows; ++i)
            {
                for (int j = 0; j != columns; ++j)
                {
                    var element = matrix[i, j];
                    // minElement == null — первый четный элемент
                    if (element % 2 == 0 && (element < minElement || minElement == null))
                    {
                        minElement = element;
                    }
                }
            }
            return minElement;
        }

        // Формирование двумерного массива по критерию: из чисел, больших минимального четного
        public static void GetArrayFromMatrix(int[,] matrix, int rows, int columns, int minElement, ref int[] array, ref int length)
        {
            array = new int[rows * columns];
            length = 0;

            for (int i = 0; i != rows; ++i)
            {
                for (int j = 0; j != columns; ++j)
                {
                    var element = matrix[i, j];
                    // Если критерий выполняется — число нам подходит, мы увеличиваем длину массива
                    if (element > minElement)
                    {
                        array[length] = element;
                        length += 1;
                    }
                }
            }
        }
    }
}