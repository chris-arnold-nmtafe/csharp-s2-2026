using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Session_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double previousNumber;
        double number = 0;
        int decimals = 0;
        string operation = null;


        public MainWindow()
        {
            InitializeComponent();
            numberDisplay.Content = "$0";
        }

        private void ResetNumber() {
            number = 0;
            decimals = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = sender as Button;
            if (button != null) {
                string numString = button.Content.ToString();
                if (numString=="C") {
                    ResetNumber();
                } else if (numString == ".") {
                    decimals = 1;
                } else if (int.TryParse(numString,out int digit)) {
                    if (decimals > 0) {
                        if (decimals < 3) {
                            number += (double)digit * Math.Pow(10, -decimals);
                            ++decimals;
                        }
                    } else {
                        number = number * 10 + digit;
                    }
                }
                string formatString = "$#,##0.";
                for (int i = 1; i < decimals; i++) {
                    formatString += '0';
                }
                numberDisplay.Content = number.ToString(formatString);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Exercise3 window = new Exercise3();
            window.Show();
        }

        private void Operator_Click(object sender, RoutedEventArgs e) {
            Equals_Click(sender, e);
            Button button = sender as Button;
            if (button != null) {
                operation = button.Content.ToString();
                ResetNumber();
            }
        }
        private void Equals_Click(object sender, RoutedEventArgs e) {
            if (operation == null) {
                previousNumber = number;
            } else if (operation == "*") {
                previousNumber = previousNumber * number;
            } else if (operation == "/") {
                previousNumber = previousNumber / number;
            } else if (operation == "+") {
                previousNumber = previousNumber + number;
            } else if (operation == "-") {
                previousNumber = previousNumber - number;
            }
            operation = null;
            numberDisplay.Content = previousNumber.ToString("$#,##0.##");
            ResetNumber();
        }


        //Watch out for crazy functional solution below!
        //I'll redo this as a simpler implementation next week.
        //If you can follow the code for entering a number, that's
        //all the exercise was asking for.
        static readonly Func<double, double, double> noOp = (x, y) => y;
        Func<double, double, double> op = noOp;
        Dictionary<string, Func<double, double, double>> ops = new() {
            { "*" , (x,y)=>{ return x * y; } },
            { "/" , (x,y)=>{ return x / y; } },
            { "+" , (x,y)=>{ return x + y; } },
            { "-" , (x,y)=>{ return x - y; } }
        };

        private void Op_Click(object sender, RoutedEventArgs e) {
            Go_Click(sender, e);
            Button button = sender as Button;
            if (button != null) {
                op = ops[button.Content.ToString()];
            }
            ResetNumber();
        }

        private void Go_Click(object sender, RoutedEventArgs e) {
            double num1 = previousNumber;
            double num2 = number;
            double result = op(num1, num2);
            previousNumber = result;
            op = noOp;
            numberDisplay.Content = previousNumber.ToString("$#,##0.##");
            ResetNumber();
        }
    }
}
