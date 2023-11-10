using System.Collections;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LW6_IP
{
    public partial class Form1 : Form
    {
        RLE_Coding rle = new RLE_Coding();
        HuffmanTree huffmanTree = new HuffmanTree();
        BitArray encoded = new BitArray(0);
        public Form1()
        {
            InitializeComponent();
        }

        private void RLEButton_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                //��������� ������ - ���������� ������ �� �����
                string str = GetTextFromFile(input.Text);
                //�������� ������� ���� �� ���������� ������
                byte[] byteArray = Encoding.UTF8.GetBytes(str);
                //�������� ������� ��� ������� �������
                rle.RLE_array = rle.RLEEncode(byteArray);
                MessageBox.Show("���� ������� ����!", "");
                result = GetCompressedFile(rle.RLE_array);

                //������ ��������� ������� � ��������� ����
                WriteArray(result);
            }
            catch (Exception)
            {
                MessageBox.Show("������!", "");
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.InitialDirectory = "E:\texts_tmp";
            OPF.Filter = "����� txt|*.txt|����� cs|*.cs";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                input.Text = OPF.FileName;
            }
        }

        private static string GetTextFromFile(string text)
        {
            StreamReader sr = new StreamReader(text);
            return sr.ReadToEnd();
        }

        private static string GetCompressedFile(byte[] arr)
        {
            string res = "";
            foreach (byte b in arr)
            {
                res += b.ToString() + " ";
            }
            return res;
        }

        private static void WriteArray(string result)
        {
            StreamWriter sw = new StreamWriter("E:\\texts_tmp\\CompressedFile.txt");
            sw.WriteLine(result);
            sw.Close();
        }

        private void HaffmanButton_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                //��������� ������ - ���������� ������ �� �����
                string str = GetTextFromFile(input.Text);  
                //���������� ������ �� ������ �����
                huffmanTree.Build(str);
                //����������� ������
                encoded = huffmanTree.Encode(str);
                WriteHuffmanTree(encoded);
                MessageBox.Show("���� ������� ����!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("������!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteHuffmanTree(BitArray array)
        {
            string res = "";
            foreach (bool bit in array)
            {
                res += ((bit ? 1 : 0) + "");
            }

            StreamWriter sw = new StreamWriter("E:\\texts_tmp\\CompressedFileHuffman.txt");
            sw.WriteLine(res);
            sw.Close();
        }

        private void Decode_Huffman_Click(object sender, EventArgs e)
        {
            try
            {
                string decoded = huffmanTree.Decode(encoded);
                StreamWriter sw = new StreamWriter("E:\\texts_tmp\\Decoding.txt");
                sw.WriteLine(decoded);
                sw.Close();
                MessageBox.Show("���� ������� ������������", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("������!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Decode_RLE_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("E:\\texts_tmp\\CompressedFile.txt");
                string decoded = sr.ReadToEnd();
                decoded = GetDecodeRLE(decoded);

                StreamWriter sw = new StreamWriter("E:\\texts_tmp\\Decoding.txt");
                sw.WriteLine(decoded);
                sw.Close();
                MessageBox.Show("���� ������� ������������", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("������!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetDecodeRLE(string arr)
        {
            string[] array = arr.Split(" ");
            string res = "";
            for (int i = 1; i < array.Length; i+=2)
            {
                res += (char)(int.Parse(array[i]));
            }
            return res;
        }
    }
}