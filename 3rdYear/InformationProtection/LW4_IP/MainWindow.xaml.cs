using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LW4_IP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DES_cipher des = new DES_cipher();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxDecodeKeyWord.Text.Length > 0)
            {
                string s = "";

                string key = des.StringToBinaryFormat(textBoxDecodeKeyWord.Text);

                StreamReader sr = new StreamReader("out1.txt");

                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine();
                }

                sr.Close();

                s = des.StringToBinaryFormat(s);

                des.CutBinaryStringIntoBlocks(s);

                for (int j = 0; j < 16; j++)
                {
                    for (int i = 0; i < des.Blocks.Length; i++)
                        des.Blocks[i] = des.DecodeDES_One_Round(des.Blocks[i], key);

                    key = des.KeyToPrevRound(key);
                }

                key = des.KeyToNextRound(key);

                textBoxEncodeKeyWord.Text = des.StringFromBinaryToNormalFormat(key);

                string result = "";

                for (int i = 0; i < des.Blocks.Length; i++)
                    result += des.Blocks[i];

                StreamWriter sw = new StreamWriter("out2.txt");
                sw.WriteLine(des.StringFromBinaryToNormalFormat(result));
                sw.Close();

                Process.Start("out2.txt");
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEncodeKeyWord.Text.Length > 0)
            {
                string s = "";

                string key = textBoxEncodeKeyWord.Text;

                StreamReader sr = new StreamReader("in.txt");

                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine();
                }

                sr.Close();
                s = des.StringToRightLength(s);

                des.CutStringIntoBlocks(s);

                key = des.CorrectKeyWord(key, s.Length / (2 * des.Blocks.Length));
                textBoxEncodeKeyWord.Text = key;
                key = des.StringToBinaryFormat(key);

                for (int j = 0; j < 16; j++)
                {
                    for (int i = 0; i < des.Blocks.Length; i++)
                        des.Blocks[i] = des.EncodeDES_One_Round(des.Blocks[i], key);

                    key = des.KeyToNextRound(key);
                }

                key = des.KeyToPrevRound(key);

                textBoxDecodeKeyWord.Text = des.StringFromBinaryToNormalFormat(key);

                string result = "";

                for (int i = 0; i < des.Blocks.Length; i++)
                    result += des.Blocks[i];

                StreamWriter sw = new StreamWriter("out1.txt");
                sw.WriteLine(des.StringFromBinaryToNormalFormat(result));
                sw.Close();

                Process.Start("out1.txt");
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }
    }
}
