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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber;
        string Operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void N1_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "1";
            }
            else
            {
                displayBox.Text = displayBox.Text + "1";
            }
        }

        private void N2_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "2";
            }
            else
            {
                displayBox.Text = displayBox.Text + "2";
            }
        }

        private void N3_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "3";
            }
            else
            {
                displayBox.Text = displayBox.Text + "3";
            }
        }

        private void N4_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "4";
            }
            else
            {
                displayBox.Text = displayBox.Text + "4";
            }
        }

        private void N5_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "5";
            }
            else
            {
                displayBox.Text = displayBox.Text + "5";
            }
        }

        private void N6_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "6";
            }
            else
            {
                displayBox.Text = displayBox.Text + "6";
            }
        }

        private void N7_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "7";
            }
            else
            {
                displayBox.Text = displayBox.Text + "7";
            }
        }

        private void N8_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "8";
            }
            else
            {
                displayBox.Text = displayBox.Text + "8";
            }
        }

        private void N9_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Text == "0" && displayBox.Text != null)
            {
                displayBox.Text = "9";
            }
            else
            {
                displayBox.Text = displayBox.Text + "9";
            }
        }

        private void N0_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Text = displayBox.Text + "0";
        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
            Operation = "+";
        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
            Operation = "-";
        }

        private void Bmultiple_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
            Operation = "*";
        }

        public void Bdivision_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
            Operation = "/";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Text = "0";
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            displayBox.Text = displayBox.Text + ".";
        }

        private void Bequal_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(displayBox.Text);

            if (Operation == "+")
            {
                result = (firstNumber + secondNumber);
                displayBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "-")
            {
                result = (firstNumber - secondNumber);
                displayBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "*")
            {
                result = (firstNumber * secondNumber);
                displayBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operation == "/")
            {
                if ( secondNumber == 0 )
                {
                    displayBox.Text = "Cannot Devide by Zero";
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    displayBox.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }

        }
    }
}
