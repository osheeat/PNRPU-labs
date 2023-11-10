using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace LW3_IP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Diffy_Helman dh = new Diffy_Helman();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dh.GetNumbers();
            dh.GetSimple();
            dh.CreateXY();
            dh.CreatePQ();
            dh.CreateABK();

            p.Text = dh.p.ToString();
            g.Text = dh.g.ToString();
            x.Text = dh.x.ToString();
            y.Text = dh.y.ToString();
            A.Text = dh.A.ToString();
            B.Text = dh.B.ToString();
            Kx.Text = dh.Kx.ToString();
            Ky.Text = dh.Ky.ToString();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            List<BigInteger> numbers = dh.CreateCipher(input.Text);
            for (int i = 0; i < numbers.Count; i++)
            {
                output.Text += numbers[i].ToString() + ";\n";
            }
        }
    }
}
