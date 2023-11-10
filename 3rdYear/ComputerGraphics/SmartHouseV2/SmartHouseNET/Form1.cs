using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartHouseNET
{
    public partial class Form1 : Form
    {
        public PaintHouse paintHouse;
        public Calculate calculator;
        public double step = 0.1;
        public List<double> room1_temps = new List<double>();
        public List<double> room2_temps = new List<double>();
        public List<double> room3_temps = new List<double>();
        public Form1()
        {
            InitializeComponent();
            paintHouse = new PaintHouse();
            calculator = new Calculate();
            GetInitialColors();
        }

        //ОТРИСОВКА ДОМА
        private void button7_Click(object sender, EventArgs e)
        {
            paintHouse.DrawHouse(this);
            paintHouse.DrawWindows(this);
            paintHouse.DrawDoors(this);
        }

        //РАСКРАШИВАНИЕ КНОПКИ (СИНЯЯ - ОТКРЫТО, КРАСНАЯ - ЗАКРЫТО)
        private Color GetWindowColor(Window window) => window.isOpened ? (Color.FromArgb(3, 244, 252)) : (Color.FromArgb(232, 125, 195));
        private Color GetDoorColor(Door door) => door.isOpened ? (Color.FromArgb(3, 244, 252)) : (Color.FromArgb(232, 125, 195));
        private void GetInitialColors()
        {
            Door1.BackColor = GetDoorColor(paintHouse.Door1);
            Door2.BackColor = GetDoorColor(paintHouse.Door2);
            Door3.BackColor = GetDoorColor(paintHouse.Door3);

            Win1btn.BackColor = GetWindowColor(paintHouse.Win1_1);
            Win2btn.BackColor = GetWindowColor(paintHouse.Win2_1);
            Win3btn.BackColor = GetWindowColor(paintHouse.Win3_1);
            Win4btn.BackColor = GetWindowColor(paintHouse.Win4_1);
            Win5btn.BackColor = GetWindowColor(paintHouse.Win5_1);
        }

        //ОТКРЫВАНИЕ ОКОН
        private void Win1_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win1_1);
            Win1btn.BackColor = GetWindowColor(paintHouse.Win1_1);
        }
        private void Win2_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win2_1);
            Win2btn.BackColor = GetWindowColor(paintHouse.Win2_1);
        }
        private void Win3_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win3_1);
            Win3btn.BackColor = GetWindowColor(paintHouse.Win3_1);
        }
        private void Win4_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win4_1);
            Win4btn.BackColor = GetWindowColor(paintHouse.Win4_1);
        }
        private void Win5_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win5_1);
            Win5btn.BackColor = GetWindowColor(paintHouse.Win5_1);
        }

        //ОТКРЫВАНИЕ ДВЕРЕЙ
        private void Door1_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawDoors(this, paintHouse.Door1);
            Door1.BackColor = GetDoorColor(paintHouse.Door1);
        }
        private void Door2_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawDoors(this, paintHouse.Door2);
            Door2.BackColor = GetDoorColor(paintHouse.Door2);
        }
        private void Door3_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawDoors(this, paintHouse.Door3);
            Door3.BackColor = GetDoorColor(paintHouse.Door3);
        }

        //ВСПОMОГАТЕЛЬНЫЕ МЕТОДЫ ДЛЯ РАСЧЕТА
        private void InitData()
        {
            calculator.room1_t = room1_temp.Value;
            calculator.room2_t = room2_temp.Value;
            calculator.room3_t = room3_temp.Value;

            calculator.bat_t = trackBar2.Value;
            calculator.out_t = trackBar1.Value;

            calculator.k1 = Get_k1();
            calculator.k2 = Get_k2();
            calculator.k3 = Get_k3();
            calculator.k4 = Get_k4();
            calculator.k5 = Get_k5();
            calculator.k6 = Get_k6();
        }
        private void FillArrays()
        {
            room1_temps.Add(calculator.room1_t);
            room2_temps.Add(calculator.room2_t);
            room3_temps.Add(calculator.room3_t);
        }
        private List<double> CutArray(List<double> a)
        {
            List<double> res = new List<double>();
            foreach (double d in a)
            {
                res.Add(Math.Round(d, 2));
            }
            return res;
        }

        //РАСЧЕТ ПРОГРАММЫ
        private void Calculate_Click(object sender, EventArgs e)
        {
            //ИНИЦИАЛИЗАЦИЯ
            InitData();
            calculator.k7 = 0;
            room1_temps.Clear();
            room2_temps.Clear();
            room3_temps.Clear();

            FillArrays();
            //РАСЧЕТ
            calculator.f();
            for (int i = 0; i < 100; i++)
            {
                calculator.f();
                FillArrays();
            }

            room1_temps = CutArray(room1_temps);
            room2_temps = CutArray(room2_temps);
            room3_temps = CutArray(room3_temps);


            //ЗАПИСЬ КОНЕЧНЫХ РЕЛУЬТАТОВ
            room1_tb.Text = room1_temps[room1_temps.Count - 1].ToString();
            room2_tb.Text = room2_temps[room2_temps.Count - 1].ToString();
            room3_tb.Text = room3_temps[room3_temps.Count - 1].ToString();

            Form2 newForm = new Form2(room1_temps, room2_temps, room3_temps);
            newForm.Show();
        }

        //ПОДПИСИ ДЛЯ ПОЛЗУНКОВ
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = "C° снаружи = " + trackBar1.Value.ToString();
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = "C° батарей = " + trackBar2.Value.ToString();
        }
        private void room1_temp_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = "C° комнаты 1 = " + room1_temp.Value.ToString();
        }
        private void room2_temp_ValueChanged(object sender, EventArgs e)
        {
            label13.Text = "C° комнаты 2 = " + room2_temp.Value.ToString();
        }
        private void room3_temp_ValueChanged(object sender, EventArgs e)
        {
            label14.Text = "C° комнаты 3 = " + room3_temp.Value.ToString();
        }

        //РАСЧЕТ КОЭФФИЦИЕНТОВ ОТНОСИТЕЛЬНО ДВЕРЕЙ, ОКОН И БАТАРЕЙ
        private double Get_k1()
        {
            return paintHouse.Door2.isOpened ? (1) : (0.15);
        }
        private double Get_k2()
        {
            double temp = 0.1;
            if (paintHouse.Win2_1.isOpened) temp += 0.4;
            if (paintHouse.Win3_1.isOpened) temp += 0.4;
            return temp;
        }
        private double Get_k3()
        {
            return (double)numericUpDown1.Value;
        }
        private double Get_k4()
        {
            return paintHouse.Door3.isOpened ? (1) : (0.15);
        }
        private double Get_k5()
        {
            double temp = 0.1;
            if (paintHouse.Win1_1.isOpened) temp += 0.4;
            if (paintHouse.Door1.isOpened) temp += 0.5;
            return temp;
        }
        private double Get_k6()
        {
            double temp = 0.1;
            if (paintHouse.Win4_1.isOpened) temp += 0.4;
            if (paintHouse.Win5_1.isOpened) temp += 0.4;
            return temp;
        }

        private void OpenGraphs_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(room1_temps, room2_temps, room3_temps);
            newForm.Show();
        }


        //ПИД-РЕГУЛЯТОР
        private void PIDbtn_Click(object sender, EventArgs e)
        {
            double Needtemp = trackBar2.Value;
            double r1_temp = room1_temp.Value;
            double r2_temp = room2_temp.Value;
            double r3_temp = room3_temp.Value;
            double accuracy = 0.1;

            PIDController pid = new PIDController(Needtemp, 0.39, 0.0002, 0.001);

            room1_temps.Clear();
            room2_temps.Clear();
            room3_temps.Clear();

            room1_temps.Add(r1_temp);
            room2_temps.Add(r2_temp);
            room3_temps.Add(r3_temp);

            room1_tb.Text = PIDCalculate(pid, r1_temp, Needtemp, accuracy, room1_temps).ToString();
            room2_tb.Text = PIDCalculate(pid, r2_temp, Needtemp, accuracy, room2_temps).ToString();
            room3_tb.Text = PIDCalculate(pid, r3_temp, Needtemp, accuracy, room3_temps).ToString();

            /*InitData();
            calculator.k7 = 1;
            calculator.k8 = 2;
            calculator.reg_t = trackBar3.Value;
            room1_temps.Clear();
            room2_temps.Clear();
            room3_temps.Clear();

            FillArrays();
            //РАСЧЕТ
            calculator.CalculatingRegulator();
            for (int i = 0; i < 15; i++)
            {
                calculator.CalculatingRegulator();
                FillArrays();
            }

            room1_temps = CutArray(room1_temps);
            room2_temps = CutArray(room2_temps);
            room3_temps = CutArray(room3_temps);


            //ЗАПИСЬ КОНЕЧНЫХ РЕЛУЬТАТОВ
            room1_tb.Text = room1_temps[room1_temps.Count - 1].ToString();
            room2_tb.Text = room2_temps[room2_temps.Count - 1].ToString();
            room3_tb.Text = room3_temps[room3_temps.Count - 1].ToString();*/

            Form2 newForm = new Form2(room1_temps, room2_temps, room3_temps);
            newForm.Show();
        }
        public double PIDCalculate(PIDController pid, double temp, double need, double accur, List<double> list)
        {
            int i = 1;
            while ((double)(Math.Abs(temp - need)) > accur)
            {
                temp += pid.Compute(temp, i);
                list.Add(temp);
                i++;
            }
            return temp;
        }
    }
}