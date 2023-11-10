namespace SmartHouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Door3 = new Button();
            Win1_1btn = new Button();
            Door2 = new Button();
            Door1 = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            Win2_1btn = new Button();
            Win3_1btn = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            Win4_1btn = new Button();
            Win5_1btn = new Button();
            button7 = new Button();
            groupBox4 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            numericUpDown1 = new NumericUpDown();
            room3_temp = new TrackBar();
            label13 = new Label();
            room2_temp = new TrackBar();
            label12 = new Label();
            room1_temp = new TrackBar();
            label11 = new Label();
            label10 = new Label();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            room1_tb = new TextBox();
            label9 = new Label();
            Calculate_btn = new Button();
            groupBox5 = new GroupBox();
            room3_tb = new TextBox();
            room2_tb = new TextBox();
            label17 = new Label();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room3_temp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room2_temp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room1_temp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Door3);
            groupBox1.Controls.Add(Win1_1btn);
            groupBox1.Controls.Add(Door2);
            groupBox1.Controls.Add(Door1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(952, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Комната 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 78);
            label8.Name = "label8";
            label8.Size = new Size(151, 17);
            label8.TabIndex = 9;
            label8.Text = "Открыть/закрыть дверь";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 49);
            label7.Name = "label7";
            label7.Size = new Size(151, 17);
            label7.TabIndex = 8;
            label7.Text = "Открыть/закрыть дверь";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 20);
            label6.Name = "label6";
            label6.Size = new Size(151, 17);
            label6.TabIndex = 7;
            label6.Text = "Открыть/закрыть дверь";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 131);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 6;
            label5.Text = "Открыть/закрыть окно";
            // 
            // Door3
            // 
            Door3.Location = new Point(6, 75);
            Door3.Name = "Door3";
            Door3.Size = new Size(75, 23);
            Door3.TabIndex = 3;
            Door3.Text = "Дверь";
            Door3.UseVisualStyleBackColor = true;
            Door3.Click += Door3_Click;
            // 
            // Win1_1btn
            // 
            Win1_1btn.FlatAppearance.BorderSize = 0;
            Win1_1btn.Location = new Point(6, 127);
            Win1_1btn.Margin = new Padding(1);
            Win1_1btn.Name = "Win1_1btn";
            Win1_1btn.Size = new Size(75, 23);
            Win1_1btn.TabIndex = 1;
            Win1_1btn.Text = "Окно";
            Win1_1btn.UseVisualStyleBackColor = true;
            Win1_1btn.Click += Win1_1btn_Click;
            // 
            // Door2
            // 
            Door2.Location = new Point(6, 46);
            Door2.Name = "Door2";
            Door2.Size = new Size(75, 23);
            Door2.TabIndex = 2;
            Door2.Text = "Дверь";
            Door2.UseVisualStyleBackColor = true;
            Door2.Click += Door2_Click;
            // 
            // Door1
            // 
            Door1.Location = new Point(6, 17);
            Door1.Name = "Door1";
            Door1.Size = new Size(75, 23);
            Door1.TabIndex = 0;
            Door1.Text = "Дверь";
            Door1.UseVisualStyleBackColor = true;
            Door1.Click += Door1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Win2_1btn);
            groupBox2.Controls.Add(Win3_1btn);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(952, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 89);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Комната 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 26);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 6;
            label2.Text = "Открыть/закрыть окно";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 55);
            label1.Name = "label1";
            label1.Size = new Size(144, 17);
            label1.TabIndex = 5;
            label1.Text = "Открыть/закрыть окно";
            // 
            // Win2_1btn
            // 
            Win2_1btn.FlatAppearance.BorderSize = 0;
            Win2_1btn.Location = new Point(6, 22);
            Win2_1btn.Margin = new Padding(1);
            Win2_1btn.Name = "Win2_1btn";
            Win2_1btn.Size = new Size(75, 23);
            Win2_1btn.TabIndex = 4;
            Win2_1btn.Text = "Окно";
            Win2_1btn.UseVisualStyleBackColor = true;
            Win2_1btn.Click += Win2_1btn_Click;
            // 
            // Win3_1btn
            // 
            Win3_1btn.FlatAppearance.BorderSize = 0;
            Win3_1btn.Location = new Point(6, 51);
            Win3_1btn.Margin = new Padding(1);
            Win3_1btn.Name = "Win3_1btn";
            Win3_1btn.Size = new Size(75, 23);
            Win3_1btn.TabIndex = 3;
            Win3_1btn.Text = "Окно";
            Win3_1btn.UseVisualStyleBackColor = true;
            Win3_1btn.Click += Win3_1btn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(Win4_1btn);
            groupBox3.Controls.Add(Win5_1btn);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(952, 332);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 87);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Комната 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 55);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 8;
            label4.Text = "Открыть/закрыть окно";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 26);
            label3.Name = "label3";
            label3.Size = new Size(144, 17);
            label3.TabIndex = 7;
            label3.Text = "Открыть/закрыть окно";
            // 
            // Win4_1btn
            // 
            Win4_1btn.FlatAppearance.BorderSize = 0;
            Win4_1btn.Location = new Point(6, 22);
            Win4_1btn.Margin = new Padding(1);
            Win4_1btn.Name = "Win4_1btn";
            Win4_1btn.Size = new Size(75, 23);
            Win4_1btn.TabIndex = 6;
            Win4_1btn.Text = "Окно";
            Win4_1btn.UseVisualStyleBackColor = true;
            Win4_1btn.Click += Win4_1btn_Click;
            // 
            // Win5_1btn
            // 
            Win5_1btn.FlatAppearance.BorderSize = 0;
            Win5_1btn.Location = new Point(6, 51);
            Win5_1btn.Margin = new Padding(1);
            Win5_1btn.Name = "Win5_1btn";
            Win5_1btn.Size = new Size(75, 23);
            Win5_1btn.TabIndex = 5;
            Win5_1btn.Text = "Окно";
            Win5_1btn.UseVisualStyleBackColor = true;
            Win5_1btn.Click += Win5_1btn_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(952, 425);
            button7.Name = "button7";
            button7.Size = new Size(281, 42);
            button7.TabIndex = 3;
            button7.Text = "Нарисовать дом";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(room3_temp);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(room2_temp);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(room1_temp);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(trackBar2);
            groupBox4.Controls.Add(trackBar1);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(573, 46);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(373, 335);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Настройки";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(222, 304);
            label15.Name = "label15";
            label15.Size = new Size(58, 17);
            label15.TabIndex = 10;
            label15.Text = "reg_koef";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(222, 257);
            label14.Name = "label14";
            label14.Size = new Size(82, 17);
            label14.TabIndex = 9;
            label14.Text = "temp_room3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(9, 304);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(207, 25);
            numericUpDown1.TabIndex = 9;
            // 
            // room3_temp
            // 
            room3_temp.Location = new Point(9, 257);
            room3_temp.Maximum = 30;
            room3_temp.Minimum = 20;
            room3_temp.Name = "room3_temp";
            room3_temp.Size = new Size(207, 45);
            room3_temp.TabIndex = 8;
            room3_temp.Value = 20;
            room3_temp.ValueChanged += room3_temp_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(222, 206);
            label13.Name = "label13";
            label13.Size = new Size(82, 17);
            label13.TabIndex = 7;
            label13.Text = "temp_room2";
            // 
            // room2_temp
            // 
            room2_temp.Location = new Point(9, 206);
            room2_temp.Maximum = 30;
            room2_temp.Minimum = 20;
            room2_temp.Name = "room2_temp";
            room2_temp.Size = new Size(207, 45);
            room2_temp.TabIndex = 6;
            room2_temp.Value = 20;
            room2_temp.ValueChanged += room2_temp_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(222, 154);
            label12.Name = "label12";
            label12.Size = new Size(82, 17);
            label12.TabIndex = 5;
            label12.Text = "temp_room1";
            // 
            // room1_temp
            // 
            room1_temp.Location = new Point(9, 154);
            room1_temp.Maximum = 30;
            room1_temp.Minimum = 20;
            room1_temp.Name = "room1_temp";
            room1_temp.Size = new Size(207, 45);
            room1_temp.TabIndex = 4;
            room1_temp.Value = 20;
            room1_temp.ValueChanged += room1_temp_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(222, 103);
            label11.Name = "label11";
            label11.Size = new Size(63, 17);
            label11.TabIndex = 3;
            label11.Text = "temp_reg";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 46);
            label10.Name = "label10";
            label10.Size = new Size(62, 17);
            label10.TabIndex = 2;
            label10.Text = "temp_out";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(9, 103);
            trackBar2.Maximum = 25;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(207, 45);
            trackBar2.TabIndex = 1;
            trackBar2.Value = 20;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(9, 43);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = -30;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(207, 45);
            trackBar1.TabIndex = 0;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // room1_tb
            // 
            room1_tb.Location = new Point(6, 24);
            room1_tb.Name = "room1_tb";
            room1_tb.Size = new Size(100, 25);
            room1_tb.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(122, 27);
            label9.Name = "label9";
            label9.Size = new Size(85, 17);
            label9.TabIndex = 6;
            label9.Text = "C° комната 1";
            // 
            // Calculate_btn
            // 
            Calculate_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Calculate_btn.Location = new Point(952, 483);
            Calculate_btn.Name = "Calculate_btn";
            Calculate_btn.Size = new Size(281, 42);
            Calculate_btn.TabIndex = 7;
            Calculate_btn.Text = "Рассчитать температуры";
            Calculate_btn.UseVisualStyleBackColor = true;
            Calculate_btn.Click += Calculate_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(room3_tb);
            groupBox5.Controls.Add(room2_tb);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(room1_tb);
            groupBox5.Controls.Add(label9);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(573, 387);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(373, 138);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Выводы";
            // 
            // room3_tb
            // 
            room3_tb.Location = new Point(6, 96);
            room3_tb.Name = "room3_tb";
            room3_tb.Size = new Size(100, 25);
            room3_tb.TabIndex = 10;
            // 
            // room2_tb
            // 
            room2_tb.Location = new Point(6, 60);
            room2_tb.Name = "room2_tb";
            room2_tb.Size = new Size(100, 25);
            room2_tb.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(122, 99);
            label17.Name = "label17";
            label17.Size = new Size(85, 17);
            label17.TabIndex = 8;
            label17.Text = "C° комната 3";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(122, 63);
            label16.Name = "label16";
            label16.Size = new Size(85, 17);
            label16.TabIndex = 7;
            label16.Text = "C° комната 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1245, 539);
            Controls.Add(groupBox5);
            Controls.Add(Calculate_btn);
            Controls.Add(groupBox4);
            Controls.Add(button7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)room3_temp).EndInit();
            ((System.ComponentModel.ISupportInitialize)room2_temp).EndInit();
            ((System.ComponentModel.ISupportInitialize)room1_temp).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Win1_1btn;
        private Button Door1;
        private GroupBox groupBox2;
        private Button Win3_1btn;
        private GroupBox groupBox3;
        private Button Win5_1btn;
        private Button button7;
        private Button Door3;
        private Button Door2;
        private Button Win2_1btn;
        private Button Win4_1btn;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox4;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TextBox room1_tb;
        private Label label9;
        private Button Calculate_btn;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label10;
        private Label label14;
        private TrackBar room3_temp;
        private Label label13;
        private TrackBar room2_temp;
        private Label label12;
        private TrackBar room1_temp;
        private Label label15;
        private GroupBox groupBox5;
        private TextBox room3_tb;
        private TextBox room2_tb;
        private Label label17;
        private Label label16;
    }
}