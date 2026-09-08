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

namespace Session_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number = 0;
        //string temporary = "";
        int decimals = 0;
        public MainWindow()
        {
            InitializeComponent();
            numberDisplay.Content = "$0";
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button button = sender as Button;
            if (button != null) {
                string numString = button.Content.ToString();
                if (numString=="C") {
                    number = 0;
                    decimals = 0;
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
    }
}
