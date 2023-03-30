﻿using System;
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
    }
}