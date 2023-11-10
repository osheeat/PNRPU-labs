namespace SmartHouseNET
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Door1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Win1btn = new System.Windows.Forms.Button();
            this.Door3 = new System.Windows.Forms.Button();
            this.Door2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Win3btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Win2btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.PIDbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.room2_temp = new System.Windows.Forms.TrackBar();
            this.room3_temp = new System.Windows.Forms.TrackBar();
            this.room1_temp = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Win5btn = new System.Windows.Forms.Button();
            this.Win4btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.room3_tb = new System.Windows.Forms.TextBox();
            this.room2_tb = new System.Windows.Forms.TextBox();
            this.room1_tb = new System.Windows.Forms.TextBox();
            this.Paint_btn = new System.Windows.Forms.Button();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.OpenGraphs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Door1
            // 
            this.Door1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Door1.Location = new System.Drawing.Point(12, 19);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(75, 23);
            this.Door1.TabIndex = 0;
            this.Door1.Text = "Дверь";
            this.Door1.UseVisualStyleBackColor = true;
            this.Door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Win1btn);
            this.panel1.Controls.Add(this.Door3);
            this.panel1.Controls.Add(this.Door2);
            this.panel1.Controls.Add(this.Door1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(910, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 154);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Комната 1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(122, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Открыть/закрыть дверь";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "Открыть/закрыть дверь";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Открыть/закрыть дверь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Открыть/закрыть окно";
            // 
            // Win1btn
            // 
            this.Win1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win1btn.Location = new System.Drawing.Point(12, 126);
            this.Win1btn.Name = "Win1btn";
            this.Win1btn.Size = new System.Drawing.Size(75, 23);
            this.Win1btn.TabIndex = 3;
            this.Win1btn.Text = "Окно";
            this.Win1btn.UseVisualStyleBackColor = true;
            this.Win1btn.Click += new System.EventHandler(this.Win1_1btn_Click);
            // 
            // Door3
            // 
            this.Door3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Door3.Location = new System.Drawing.Point(12, 77);
            this.Door3.Name = "Door3";
            this.Door3.Size = new System.Drawing.Size(75, 23);
            this.Door3.TabIndex = 2;
            this.Door3.Text = "Дверь";
            this.Door3.UseVisualStyleBackColor = true;
            this.Door3.Click += new System.EventHandler(this.Door3_Click);
            // 
            // Door2
            // 
            this.Door2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Door2.Location = new System.Drawing.Point(12, 48);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(75, 23);
            this.Door2.TabIndex = 1;
            this.Door2.Text = "Дверь";
            this.Door2.UseVisualStyleBackColor = true;
            this.Door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Win3btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Win2btn);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(910, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 82);
            this.panel2.TabIndex = 4;
            this.panel2.Tag = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Комната 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Открыть/закрыть окно";
            // 
            // Win3btn
            // 
            this.Win3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win3btn.Location = new System.Drawing.Point(12, 48);
            this.Win3btn.Name = "Win3btn";
            this.Win3btn.Size = new System.Drawing.Size(75, 23);
            this.Win3btn.TabIndex = 4;
            this.Win3btn.Text = "Окно";
            this.Win3btn.UseVisualStyleBackColor = true;
            this.Win3btn.Click += new System.EventHandler(this.Win3_1btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Открыть/закрыть окно";
            // 
            // Win2btn
            // 
            this.Win2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win2btn.Location = new System.Drawing.Point(12, 19);
            this.Win2btn.Name = "Win2btn";
            this.Win2btn.Size = new System.Drawing.Size(75, 23);
            this.Win2btn.TabIndex = 3;
            this.Win2btn.Text = "Окно";
            this.Win2btn.UseVisualStyleBackColor = true;
            this.Win2btn.Click += new System.EventHandler(this.Win2_1btn_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.PIDbtn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.room2_temp);
            this.panel4.Controls.Add(this.room3_temp);
            this.panel4.Controls.Add(this.room1_temp);
            this.panel4.Controls.Add(this.trackBar2);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(497, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 377);
            this.panel4.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(195, 16);
            this.label22.TabIndex = 14;
            this.label22.Text = "Управление температурами";
            // 
            // PIDbtn
            // 
            this.PIDbtn.Location = new System.Drawing.Point(212, 331);
            this.PIDbtn.Name = "PIDbtn";
            this.PIDbtn.Size = new System.Drawing.Size(175, 31);
            this.PIDbtn.TabIndex = 12;
            this.PIDbtn.Text = "Запустить регулятор";
            this.PIDbtn.UseVisualStyleBackColor = true;
            this.PIDbtn.Click += new System.EventHandler(this.PIDbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "reg_koef";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "temp_room3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "temp_room2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "temp_room1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "temp_bat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "temp_out";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(14, 340);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // room2_temp
            // 
            this.room2_temp.Location = new System.Drawing.Point(14, 233);
            this.room2_temp.Maximum = 30;
            this.room2_temp.Minimum = 5;
            this.room2_temp.Name = "room2_temp";
            this.room2_temp.Size = new System.Drawing.Size(247, 45);
            this.room2_temp.TabIndex = 4;
            this.room2_temp.Value = 20;
            this.room2_temp.ValueChanged += new System.EventHandler(this.room2_temp_ValueChanged);
            // 
            // room3_temp
            // 
            this.room3_temp.Location = new System.Drawing.Point(14, 284);
            this.room3_temp.Maximum = 30;
            this.room3_temp.Minimum = 5;
            this.room3_temp.Name = "room3_temp";
            this.room3_temp.Size = new System.Drawing.Size(247, 45);
            this.room3_temp.TabIndex = 3;
            this.room3_temp.Value = 20;
            this.room3_temp.ValueChanged += new System.EventHandler(this.room3_temp_ValueChanged);
            // 
            // room1_temp
            // 
            this.room1_temp.Location = new System.Drawing.Point(14, 184);
            this.room1_temp.Maximum = 30;
            this.room1_temp.Minimum = 5;
            this.room1_temp.Name = "room1_temp";
            this.room1_temp.Size = new System.Drawing.Size(247, 45);
            this.room1_temp.TabIndex = 2;
            this.room1_temp.Value = 20;
            this.room1_temp.ValueChanged += new System.EventHandler(this.room1_temp_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(14, 92);
            this.trackBar2.Maximum = 25;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(247, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 34);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = -30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.Win5btn);
            this.panel5.Controls.Add(this.Win4btn);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(910, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 87);
            this.panel5.TabIndex = 6;
            this.panel5.Tag = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 13;
            this.label20.Text = "Комната 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Открыть/закрыть окно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Открыть/закрыть окно";
            // 
            // Win5btn
            // 
            this.Win5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win5btn.Location = new System.Drawing.Point(12, 49);
            this.Win5btn.Name = "Win5btn";
            this.Win5btn.Size = new System.Drawing.Size(75, 23);
            this.Win5btn.TabIndex = 4;
            this.Win5btn.Text = "Окно";
            this.Win5btn.UseVisualStyleBackColor = true;
            this.Win5btn.Click += new System.EventHandler(this.Win5_1btn_Click);
            // 
            // Win4btn
            // 
            this.Win4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win4btn.Location = new System.Drawing.Point(12, 20);
            this.Win4btn.Name = "Win4btn";
            this.Win4btn.Size = new System.Drawing.Size(75, 23);
            this.Win4btn.TabIndex = 3;
            this.Win4btn.Text = "Окно";
            this.Win4btn.UseVisualStyleBackColor = true;
            this.Win4btn.Click += new System.EventHandler(this.Win4_1btn_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.room3_tb);
            this.panel6.Controls.Add(this.room2_tb);
            this.panel6.Controls.Add(this.room1_tb);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(497, 398);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 133);
            this.panel6.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Выводы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "C° комната 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "C° комната 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "C° комната 1";
            // 
            // room3_tb
            // 
            this.room3_tb.Location = new System.Drawing.Point(14, 101);
            this.room3_tb.Name = "room3_tb";
            this.room3_tb.Size = new System.Drawing.Size(100, 22);
            this.room3_tb.TabIndex = 2;
            // 
            // room2_tb
            // 
            this.room2_tb.Location = new System.Drawing.Point(14, 64);
            this.room2_tb.Name = "room2_tb";
            this.room2_tb.Size = new System.Drawing.Size(100, 22);
            this.room2_tb.TabIndex = 1;
            // 
            // room1_tb
            // 
            this.room1_tb.Location = new System.Drawing.Point(14, 27);
            this.room1_tb.Name = "room1_tb";
            this.room1_tb.Size = new System.Drawing.Size(100, 22);
            this.room1_tb.TabIndex = 0;
            // 
            // Paint_btn
            // 
            this.Paint_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paint_btn.Location = new System.Drawing.Point(910, 355);
            this.Paint_btn.Name = "Paint_btn";
            this.Paint_btn.Size = new System.Drawing.Size(295, 34);
            this.Paint_btn.TabIndex = 8;
            this.Paint_btn.Text = "Нарисовать дом";
            this.Paint_btn.UseVisualStyleBackColor = true;
            this.Paint_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate_btn.Location = new System.Drawing.Point(910, 398);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(295, 31);
            this.Calculate_btn.TabIndex = 9;
            this.Calculate_btn.Text = "Рассчитать температуры";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // OpenGraphs
            // 
            this.OpenGraphs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenGraphs.Location = new System.Drawing.Point(910, 441);
            this.OpenGraphs.Name = "OpenGraphs";
            this.OpenGraphs.Size = new System.Drawing.Size(295, 31);
            this.OpenGraphs.TabIndex = 10;
            this.OpenGraphs.Text = "Открыть окно графиков";
            this.OpenGraphs.UseVisualStyleBackColor = true;
            this.OpenGraphs.Click += new System.EventHandler(this.OpenGraphs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 544);
            this.Controls.Add(this.OpenGraphs);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Paint_btn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room2_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room3_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room1_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Door1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Win1btn;
        private System.Windows.Forms.Button Door3;
        private System.Windows.Forms.Button Door2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Win3btn;
        private System.Windows.Forms.Button Win2btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar room2_temp;
        private System.Windows.Forms.TrackBar room3_temp;
        private System.Windows.Forms.TrackBar room1_temp;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Win5btn;
        private System.Windows.Forms.Button Win4btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox room3_tb;
        private System.Windows.Forms.TextBox room2_tb;
        private System.Windows.Forms.TextBox room1_tb;
        private System.Windows.Forms.Button Paint_btn;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.Button OpenGraphs;
        private System.Windows.Forms.Button PIDbtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

