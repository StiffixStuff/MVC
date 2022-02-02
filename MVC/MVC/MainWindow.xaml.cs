using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorMVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double result;
        double x1, x2;
        string s;
        public MainWindow()
        {
            InitializeComponent();
            Model.tb = Result;
            Model.tbCombo = ComboChange;
            Model.tbx1 = ChangeX1;
            Model.tbx2 = ChangeX2;
            ComboChange.ItemsSource = Model.dataList;

        }

        private void controller_Click(object sender, RoutedEventArgs e)
        {
            if (s == "Сложение")
            {
                result = x1 + x2;
            }
            if (s == "Вычитание")
            {
                result = x1 - x2;
            }
            if (s == "Умножение")
            {
                result = x1 * x2;
            }
            if (s == "Деление")
            {
                result = x1 / x2;
            }

            Model.tb.Text = result.ToString();
        }

        private void ChangeX1_TextChanged(object sender, TextChangedEventArgs e)
        {
            x1 = Convert.ToDouble(Model.tbx1.Text);
        }

        private void ChangeX2_TextChanged(object sender, TextChangedEventArgs e)
        {
            x2 = Convert.ToDouble(Model.tbx2.Text);
        }

        private void ComboChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            s = Model.dataList[ComboChange.SelectedIndex];
            Model.Combo = ComboChange.SelectedIndex;
        }
    }
}
