using System;
using System.Windows.Forms;

namespace Laboratory4Library
{
    public class Laboratory4
    {
        public static double GetDouble(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void OutputDouble(TextBox t, double value)
        {
            t.Text = Convert.ToString(value);
        }
        public static void OutputViewRow(DataGridView view, int n, double y)
        {
            view.Rows.Add(n, y);
        }
        public static double Calculate(double previous)
        {
            return (previous + 1) / (previous + 2);
        }
        public static double TabulateFunction(DataGridView view, double start, double e)
        {
            double previous = start;
            double current = Laboratory4.Calculate(previous);

            Laboratory4.OutputViewRow(view, 0, previous);
            Laboratory4.OutputViewRow(view, 1, current);

            int i = 2;
            while (current - previous >= e)
            {
                previous = current;
                current = Laboratory4.Calculate(previous);
                Laboratory4.OutputViewRow(view, i, current);
                i += 1;
            }

            return current;
        }
    }
}
