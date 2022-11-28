using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПР6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косичкин Илья ИСП-34\nПрактическая №6\nИспользовать класс Pair (пара четных чисел). Разработать операцию инкремента - (а, b) = (а+b). Разработать операцию для вычисления произведения 2 пар чисел – (а, b) * (с, d) = (а * c, b * d).");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        Pair pair1 = new Pair(default, default);
        Pair pair2 = new Pair(default, default);

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!int.TryParse(Input_FirstPair_1.Text, out int Fp1))
                {
                    MessageBox.Show("Введите целое число");
                    Input_FirstPair_1.Clear();
                }
                if (!int.TryParse(Input_FirstPair_2.Text, out int Fp2))
                {
                    MessageBox.Show("Введите целое число");
                    Input_FirstPair_2.Clear();
                }
                if (!int.TryParse(Input_SecondPair_1.Text, out int Sp1))
                {
                    MessageBox.Show("Введите целое число");
                    Input_SecondPair_1.Clear();
                }
                if (!int.TryParse(Input_SecondPair_2.Text, out int Sp2))
                {
                    MessageBox.Show("Введите целое число");
                    Input_SecondPair_2.Clear();
                }
                pair1 = new Pair(Fp1, Fp2);
                pair2 = new Pair(Sp1, Sp2);
                Pair pair = pair1.Multiplication(pair2);
                Res_Multiplication.Text = $"{pair.OneValue} {pair.TwoValue}";
            }
            catch (Exception)
            {
                MessageBox.Show("Свойство должно быть чётным");
            }
        }

        private void Sum_pair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!int.TryParse(Input_FirstPair_1.Text, out int Fp1))
                {
                    MessageBox.Show("Введите целое число");
                    Input_FirstPair_1.Clear();
                }
                if (!int.TryParse(Input_FirstPair_2.Text, out int Fp2))
                {
                    MessageBox.Show("Введите целое число");
                    Input_FirstPair_2.Clear();
                }
                if (!int.TryParse(Input_SecondPair_1.Text, out int Sp1))
                {
                    MessageBox.Show("Введите целое число");
                    Input_SecondPair_1.Clear();
                }
                if (!int.TryParse(Input_SecondPair_2.Text, out int Sp2))
                {
                    MessageBox.Show("Введите целое число");
                    Input_SecondPair_2.Clear();
                }
                pair1 = new Pair(Fp1, Fp2);
                pair2 = new Pair(Sp1, Sp2);
                pair1++;
                pair2++;
                FirstPair_Sum.Text = $"{pair1.OneValue}";
                SecondPair_Sum.Text = $"{pair2.OneValue}";
            }
            catch (Exception)
            {
                MessageBox.Show("Свойство должно быть чётным");
            }
        }
    }
}
