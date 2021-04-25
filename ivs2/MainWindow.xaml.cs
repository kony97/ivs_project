using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
using Math;

namespace ivs2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double n1 = Double.NaN;
        private int op = 0;
        private Math.Library.Math math = new Math.Library.Math();
        private bool done = false;


        public MainWindow()
        {
            InitializeComponent();
            DisableBinary();
        }


        private void DisableBinary()
        {
            btn_divide.IsEnabled = false;
            btn_minus.IsEnabled = false;
            btn_plus.IsEnabled = false;
            btn_multiply.IsEnabled = false;
            btn_pow.IsEnabled = false;
            btn_sqrt.IsEnabled = false;

            btn_pm.IsEnabled = true;
        }

        private void EnableBinary()
        {
            if (Double.IsNaN(n1))
            {
                btn_divide.IsEnabled = true;
                btn_minus.IsEnabled = true;
                btn_plus.IsEnabled = true;
                btn_multiply.IsEnabled = true;
                btn_pow.IsEnabled = true;
                btn_sqrt.IsEnabled = true;
            }
        }

        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 0;
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 1;
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 2;
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 3;
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 4;
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 5;
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 6;
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 7;
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 8;
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += 9;
        }

        private void btn_pow_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "^";
            op = 5;
        }

        private void btn_abs_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Double.Parse(input_line.Text);
            input_line.Text = math.Abs(n1).ToString();
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "*";
            op = 3;
        }

        private void btn_point_Click(object sender, RoutedEventArgs e)
        {
            EnableBinary();

            if (input_line.Text == "" || input_line.Text == "-")
            {
                input_line.Text += "0,";
                return;
            }

            input_line.Text += ",";
            DisableBinary();
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "-";
            op = 2;
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "/";
            op = 4;
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "+";
            op = 1;
        }

        private void btn_fact_Click(object sender, RoutedEventArgs e)
        {
            int n1 = Int32.Parse(input_line.Text);
            input_line.Text = math.Fact(n1).ToString();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text = "";
            n1 = Double.NaN;
        }

        private void btn_ac_Click(object sender, RoutedEventArgs e)
        {
            if (input_line.Text != "")
            {
                input_line.Text = input_line.Text.Remove(input_line.Text.Length - 1);
                if (input_line.Text == "")
                {
                    n1 = Double.NaN;
                }

            }
        }

        private void input_line_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (input_line.Text == "")
            {
                btn_pm.IsEnabled = true;
                btn_abs.IsEnabled = false;
                btn_fact.IsEnabled = false;
            }
            else
            {
                if (double.IsNaN(n1) && input_line.Text != "-")
                {
                    btn_abs.IsEnabled = true;
                    btn_fact.IsEnabled = true;
                    EnableBinary();
                }
                else
                {
                    DisableBinary();
                    btn_abs.IsEnabled = false;
                    btn_fact.IsEnabled = false;
                }

                btn_pm.IsEnabled = false;
            }
        }

        private void btn_pm_Click(object sender, RoutedEventArgs e)
        {
            input_line.Text += "-";
        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            n1 = Double.Parse(input_line.Text);

            input_line.Text += "√";
            op = 6;
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            double n2 = 0;

            if (!double.IsNaN(n1))
            {
                n2 = Double.Parse(input_line.Text.Substring(n1.ToString().Length + 1));
            }

            double o = 0;

            switch (op)
            {
                case 1:
                    o = math.Add(n1, n2);
                    break;
                case 2:
                    o = math.Sub(n1, n2);
                    break;
                case 3:
                    o = math.Mul(n1, n2);
                    break;
                case 4:
                    o = math.Div(n1, n2);
                    break;
                case 5:
                    o = math.Pow(n1, n2);
                    break;
                case 6:
                    o = math.Sqrt(n2, n1);
                    break;
                default:
                    input_line.Text = "WTF";
                    break;

            }

            n1 = Double.NaN;
            input_line.Text = o.ToString();
            EnableBinary();
        }

        private void My_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad0 && btn_zero.IsEnabled)
            {
                btn_zero_Click(null,null);
            }
            else if (e.Key == Key.NumPad1 && btn_1.IsEnabled)
            {
                btn_1_Click(null,null);
            }
            else if (e.Key == Key.NumPad2 && btn_2.IsEnabled)
            {
                btn_2_Click(null, null);
            }
            else if (e.Key == Key.NumPad3 && btn_3.IsEnabled)
            {
                btn_3_Click(null, null);
            }
            else if (e.Key == Key.NumPad4 && btn_4.IsEnabled)
            {
                btn_4_Click(null, null);
            }
            else if (e.Key == Key.NumPad5 && btn_5.IsEnabled)
            {
                btn_5_Click(null, null);
            }
            else if (e.Key == Key.NumPad6 && btn_6.IsEnabled)
            {
                btn_6_Click(null, null);
            }
            else if (e.Key == Key.NumPad7 && btn_7.IsEnabled)
            {
                btn_7_Click(null, null);
            }
            else if (e.Key == Key.NumPad8 && btn_8.IsEnabled)
            {
                btn_8_Click(null, null);
            }
            else if (e.Key == Key.NumPad9 && btn_9.IsEnabled)
            {
                btn_9_Click(null, null);
            }
            else if (e.Key == Key.Add && btn_plus.IsEnabled)
            {
                btn_plus_Click(null, null);
            }
            else if (e.Key == Key.Subtract && btn_pm.IsEnabled)
            {
                btn_pm_Click(null, null);
            }
            else if (e.Key == Key.Subtract && btn_minus.IsEnabled)
            {
                btn_minus_Click(null, null);
            }
            else if (e.Key == Key.Multiply && btn_multiply.IsEnabled)
            {
                btn_multiply_Click(null, null);
            }
            else if (e.Key == Key.Divide && btn_divide.IsEnabled)
            {
                btn_divide_Click(null, null);
            }
            else if (e.Key == Key.Decimal && btn_point.IsEnabled)
            {
                btn_point_Click(null, null);
            }
            else if (e.Key == Key.Enter && btn_eq.IsEnabled)
            {
                btn_eq_Click(null, null);
            }
            else if (e.Key == Key.Back && btn_ac.IsEnabled)
            {
                btn_ac_Click(null, null);
            }
            else if (e.Key == Key.Escape && btn_delete.IsEnabled)
            {
                btn_delete_Click(null, null);
            }


        }
    }
}
