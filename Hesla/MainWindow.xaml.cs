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

namespace Hesla
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text.Length > 5 && textbox1.Text.Length > 3)
            {
                label3.Content = "";
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

                if (textbox2.Text.IndexOfAny(numbers) == -1)
                {
                    label3.Content = "*Your password has 0 numbers!";
                }
                else
                {
                    button2.Visibility = Visibility.Visible;
                    label4.Content = "You are logged in!";
                    textbox1.Clear();
                    textbox2.Clear();
                }
            }
            else
            {
                label3.Content = "*Your username/password is too short!";  
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
