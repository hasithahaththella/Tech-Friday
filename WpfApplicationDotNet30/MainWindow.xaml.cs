using System;
using System.Collections.Generic;
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

namespace WpfApplicationDotNet30
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

        private void btSum_Click(object sender, RoutedEventArgs e)
        {
            short number1, number2 = 0;
            Int16.TryParse(textBox1.Text, out number1);
            Int16.TryParse(textBox2.Text, out number2);
            MessageBox.Show((number1 + number2).ToString());
        }
    }
}
