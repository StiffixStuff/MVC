using System.Collections.Generic;
using System.Windows.Controls;

namespace CalculatorMVC
{
    static class Model
    {
        public static List<string> dataList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        static double result;
        public static TextBlock tb;
        public static ComboBox tbCombo;
        public static TextBox tbx1;
        public static TextBox tbx2;

        public static int Combo
        {
            set
            {
                tbCombo.Text = dataList[value].ToString();
            }
        }

        public static double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                tb.Text = result.ToString();
            }
        }
    }
}
