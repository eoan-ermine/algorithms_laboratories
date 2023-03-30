using System;
using System.Windows.Forms;

namespace Laboratory3Library
{
    public class Laboratory3
    {
        public static double GetDouble(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void OutputDouble(TextBox t, double value)
        {
            t.Text = Convert.ToString(value);
        }
        public static void OutputViewRow(DataGridView view, double x, double y)
        {
            view.Rows.Add(x, y);
        }
        public static double CalculateExpression(double x)
        {
            return Math.Pow(Math.Log(x), 2) / x;
        }
        public static double TabulateFunction(double a, double b, double h, DataGridView view)
        {
            double min = Double.MaxValue;
            double x = a;
            int n = Convert.ToInt32(Math.Round((b - a) / h + 1));

            for (int i = 1; i <= n; ++i)
            {
                double y = Laboratory3.CalculateExpression(x);
                if (y < min) min = y;
                Laboratory3.OutputViewRow(view, x, y);
                x += h;
            }

            return min;
        }
    }
}
