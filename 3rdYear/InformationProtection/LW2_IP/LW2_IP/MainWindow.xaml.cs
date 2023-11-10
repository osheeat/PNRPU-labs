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
using System.Numerics;

namespace LW2_IP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RSA rsa = new RSA();
        public MainWindow()
        {           
            InitializeComponent();    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rsa.GetNumbers();
            rsa.CreatePQ();
            p.Text = rsa.p.ToString();
            q.Text = rsa.q.ToString();
            rsa.CreateKeys();
            d.Text = rsa.d.ToString();
            n.Text = rsa.n.ToString();
            ee.Text = rsa.e.ToString();
            m.Text = rsa.m.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string answer = rsa.CreateCipher(input.Text);
            output.Text = answer;
        }
    }
}
