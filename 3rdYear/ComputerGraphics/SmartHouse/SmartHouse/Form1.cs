namespace SmartHouse
{
    public partial class Form1 : Form
    {
        public PaintHouse paintHouse;
        public Calculate calculator;
        public int NumberOfWindow;
        public double step = 0.1;
        public Form1()
        {
            InitializeComponent();
            paintHouse = new PaintHouse();
            calculator = new Calculate();
            GetInitialColors();
        }

        //Œ“–»—Œ¬ ¿ ƒŒÃ¿
        private void button7_Click(object sender, EventArgs e)
        {

            paintHouse.DrawHouse(this);
            paintHouse.DrawWindows(this);
            paintHouse.DrawDoors(this);
        }

        //–¿— –¿ÿ»¬¿Õ»≈  ÕŒœ » (—»Õﬂﬂ - Œ“ –€“Œ,  –¿—Õ¿ﬂ - «¿ –€“Œ)
        private Color GetWindowColor(Window window)
        {
            return window.isOpened ? (Color.FromArgb(3, 244, 252)) : (Color.FromArgb(232, 125, 195));
        }
        private Color GetDoorColor(Door door)
        {
            return door.isOpened ? (Color.FromArgb(3, 244, 252)) : (Color.FromArgb(232, 125, 195));
        }
        private void GetInitialColors()
        {
            Door1.BackColor = GetDoorColor(paintHouse.Door1);
            Door2.BackColor = GetDoorColor(paintHouse.Door2);
            Door3.BackColor = GetDoorColor(paintHouse.Door3);

            Win1_1btn.BackColor = GetWindowColor(paintHouse.Win1_1);
            Win2_1btn.BackColor = GetWindowColor(paintHouse.Win2_1);
            Win3_1btn.BackColor = GetWindowColor(paintHouse.Win3_1);
            Win4_1btn.BackColor = GetWindowColor(paintHouse.Win4_1);
            Win5_1btn.BackColor = GetWindowColor(paintHouse.Win5_1);
        }

        //Œ“ –€¬¿Õ»≈ Œ ŒÕ
        private void Win1_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win1_1);
            Win1_1btn.BackColor = GetWindowColor(paintHouse.Win1_1);
        }
        private void Win2_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win2_1);
            Win2_1btn.BackColor = GetWindowColor(paintHouse.Win2_1);
        }
        private void Win3_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win3_1);
            Win3_1btn.BackColor = GetWindowColor(paintHouse.Win3_1);
        }
        private void Win4_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win4_1);
            Win4_1btn.BackColor = GetWindowColor(paintHouse.Win4_1);
        }
        private void Win5_1btn_Click(object sender, EventArgs e)
        {
            paintHouse.RedrawWindow(this, paintHouse.Win5_1);
            Win5_1btn.BackColor = GetWindowColor(paintHouse.Win5_1);
        }

        //Œ“ –€¬¿Õ»≈ ƒ¬≈–≈…
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

        //–¿—◊≈“ œ–Œ√–¿ÃÃ€
        private void Calculate_Click(object sender, EventArgs e)
        {
            calculator.room1_t = room1_temp.Value;
            calculator.room2_t = room2_temp.Value;
            calculator.room3_t = room3_temp.Value;

            calculator.reg_t = trackBar2.Value;
            calculator.out_t = trackBar1.Value;

            calculator.k1 = Get_k1();
            calculator.k2 = Get_k2();
            calculator.k3 = Get_k3();
            calculator.k4 = Get_k4();
            calculator.k5 = Get_k5();
            calculator.k6 = Get_k6();

            calculator.f();

            for (int i = 0; i < 15; i++)
            {
                calculator.f();
            }
            room1_tb.Text = calculator.room1_t.ToString();
            room2_tb.Text = calculator.room2_t.ToString();
            room3_tb.Text = calculator.room1_t.ToString();
        }

        //œŒƒœ»—» ƒÀﬂ œŒÀ«”Õ Œ¬
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = "C∞ ÒÌ‡ÛÊË = " + trackBar1.Value.ToString();
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = "C∞ ÚÂ·ÛÂÏ‡ˇ = " + trackBar2.Value.ToString();
        }
        private void room1_temp_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = "C∞ ÍÓÏÌ‡Ú˚ 1 = " + room1_temp.Value.ToString();
        }
        private void room2_temp_ValueChanged(object sender, EventArgs e)
        {
            label13.Text = "C∞ ÍÓÏÌ‡Ú˚ 2 = " + room2_temp.Value.ToString();
        }
        private void room3_temp_ValueChanged(object sender, EventArgs e)
        {
            label14.Text = "C∞ ÍÓÏÌ‡Ú˚ 3 = " + room3_temp.Value.ToString();
        }


        //–¿—◊≈“  Œ›‘‘»÷»≈Õ“Œ¬ Œ“ÕŒ—»“≈À‹ÕŒ ƒ¬≈–≈…, Œ ŒÕ » ¡¿“¿–≈…
        private double Get_k1()
        {
            return paintHouse.Door2.isOpened ? (1) : (0.15);
        }
        private double Get_k2()
        {
            double temp = 0;
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
            double temp = 0;
            if (paintHouse.Win1_1.isOpened) temp += 0.4;
            if (paintHouse.Door1.isOpened) temp += 0.5;
            return temp;
        }
        private double Get_k6()
        {
            double temp = 0;
            if (paintHouse.Win4_1.isOpened) temp += 0.4;
            if (paintHouse.Win5_1.isOpened) temp += 0.4;
            return temp;
        }
    }
}