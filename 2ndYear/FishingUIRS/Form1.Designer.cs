namespace Fishing2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ShipPrice_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SailorSalary_tb = new System.Windows.Forms.TextBox();
            this.ShipCount_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FishCount_tb = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reprKoef_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dobKoef_tb = new System.Windows.Forms.TextBox();
            this.years_label = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.regulator_chb = new System.Windows.Forms.CheckBox();
            this.valRegul = new System.Windows.Forms.GroupBox();
            this.prod_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rash_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.razn_tb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fisherCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoMoveScript = new System.Windows.Forms.RadioButton();
            this.GoodScript = new System.Windows.Forms.RadioButton();
            this.MyScript = new System.Windows.Forms.RadioButton();
            this.GreedScript = new System.Windows.Forms.RadioButton();
            this.ValuesGB = new System.Windows.Forms.GroupBox();
            this.Kap_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutValues = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.valRegul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ValuesGB.SuspendLayout();
            this.OutValues.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(893, 710);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(213, 48);
            this.Start.TabIndex = 0;
            this.Start.Text = "Запустить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стоимость 1 корабля";
            // 
            // ShipPrice_tb
            // 
            this.ShipPrice_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipPrice_tb.Location = new System.Drawing.Point(253, 32);
            this.ShipPrice_tb.Name = "ShipPrice_tb";
            this.ShipPrice_tb.Size = new System.Drawing.Size(128, 24);
            this.ShipPrice_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во кораблей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зарплата моряков";
            // 
            // SailorSalary_tb
            // 
            this.SailorSalary_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SailorSalary_tb.Location = new System.Drawing.Point(253, 62);
            this.SailorSalary_tb.Name = "SailorSalary_tb";
            this.SailorSalary_tb.Size = new System.Drawing.Size(128, 24);
            this.SailorSalary_tb.TabIndex = 7;
            // 
            // ShipCount_tb
            // 
            this.ShipCount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipCount_tb.Location = new System.Drawing.Point(253, 35);
            this.ShipCount_tb.Name = "ShipCount_tb";
            this.ShipCount_tb.Size = new System.Drawing.Size(128, 24);
            this.ShipCount_tb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кол-во рыболовов на корабле";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Кол-во рыбы";
            // 
            // FishCount_tb
            // 
            this.FishCount_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FishCount_tb.Location = new System.Drawing.Point(253, 65);
            this.FishCount_tb.Name = "FishCount_tb";
            this.FishCount_tb.Size = new System.Drawing.Size(128, 24);
            this.FishCount_tb.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(782, 77);
            this.chart1.Name = "chart1";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(435, 161);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(782, 306);
            this.chart2.Name = "chart2";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(435, 161);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(778, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Кол-во рыбы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(778, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Размер капитала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Коэф. репродукции";
            // 
            // reprKoef_tb
            // 
            this.reprKoef_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reprKoef_tb.Location = new System.Drawing.Point(248, 30);
            this.reprKoef_tb.Name = "reprKoef_tb";
            this.reprKoef_tb.Size = new System.Drawing.Size(128, 24);
            this.reprKoef_tb.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Коэф. добычи";
            // 
            // dobKoef_tb
            // 
            this.dobKoef_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobKoef_tb.Location = new System.Drawing.Point(248, 63);
            this.dobKoef_tb.Name = "dobKoef_tb";
            this.dobKoef_tb.Size = new System.Drawing.Size(128, 24);
            this.dobKoef_tb.TabIndex = 21;
            // 
            // years_label
            // 
            this.years_label.AutoSize = true;
            this.years_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years_label.Location = new System.Drawing.Point(472, 77);
            this.years_label.Name = "years_label";
            this.years_label.Size = new System.Drawing.Size(44, 18);
            this.years_label.TabIndex = 24;
            this.years_label.Text = "years";
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month_label.Location = new System.Drawing.Point(472, 49);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(50, 18);
            this.month_label.TabIndex = 25;
            this.month_label.Text = "month";
            // 
            // regulator_chb
            // 
            this.regulator_chb.AutoSize = true;
            this.regulator_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regulator_chb.Location = new System.Drawing.Point(463, 403);
            this.regulator_chb.Name = "regulator_chb";
            this.regulator_chb.Size = new System.Drawing.Size(131, 29);
            this.regulator_chb.TabIndex = 28;
            this.regulator_chb.Text = "Регулятор";
            this.regulator_chb.UseVisualStyleBackColor = true;
            // 
            // valRegul
            // 
            this.valRegul.Controls.Add(this.dobKoef_tb);
            this.valRegul.Controls.Add(this.reprKoef_tb);
            this.valRegul.Controls.Add(this.label9);
            this.valRegul.Controls.Add(this.label10);
            this.valRegul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valRegul.Location = new System.Drawing.Point(34, 370);
            this.valRegul.Name = "valRegul";
            this.valRegul.Size = new System.Drawing.Size(404, 97);
            this.valRegul.TabIndex = 29;
            this.valRegul.TabStop = false;
            this.valRegul.Text = "Переменные, зависящие от регулятора";
            // 
            // prod_tb
            // 
            this.prod_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prod_tb.Location = new System.Drawing.Point(248, 30);
            this.prod_tb.Name = "prod_tb";
            this.prod_tb.Size = new System.Drawing.Size(128, 24);
            this.prod_tb.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Расходы";
            // 
            // rash_tb
            // 
            this.rash_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rash_tb.Location = new System.Drawing.Point(248, 62);
            this.rash_tb.Name = "rash_tb";
            this.rash_tb.Size = new System.Drawing.Size(128, 24);
            this.rash_tb.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Доходы";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(7, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 35;
            this.label14.Text = "Разница";
            // 
            // razn_tb
            // 
            this.razn_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razn_tb.Location = new System.Drawing.Point(248, 94);
            this.razn_tb.Name = "razn_tb";
            this.razn_tb.Size = new System.Drawing.Size(128, 24);
            this.razn_tb.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(778, 482);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 24);
            this.label15.TabIndex = 37;
            this.label15.Text = "Флот";
            this.label15.UseWaitCursor = true;
            // 
            // chart3
            // 
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart3.Legends.Add(legend12);
            this.chart3.Location = new System.Drawing.Point(782, 519);
            this.chart3.Name = "chart3";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(435, 161);
            this.chart3.TabIndex = 36;
            this.chart3.Text = "chart3";
            // 
            // fisherCount
            // 
            this.fisherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fisherCount.Location = new System.Drawing.Point(252, 92);
            this.fisherCount.Name = "fisherCount";
            this.fisherCount.Size = new System.Drawing.Size(128, 24);
            this.fisherCount.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoMoveScript);
            this.groupBox2.Controls.Add(this.GoodScript);
            this.groupBox2.Controls.Add(this.MyScript);
            this.groupBox2.Controls.Add(this.GreedScript);
            this.groupBox2.Location = new System.Drawing.Point(34, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 134);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сценарии";
            // 
            // NoMoveScript
            // 
            this.NoMoveScript.AutoSize = true;
            this.NoMoveScript.Location = new System.Drawing.Point(22, 99);
            this.NoMoveScript.Name = "NoMoveScript";
            this.NoMoveScript.Size = new System.Drawing.Size(147, 20);
            this.NoMoveScript.TabIndex = 3;
            this.NoMoveScript.TabStop = true;
            this.NoMoveScript.Text = "Бизнес \"на месте\"";
            this.NoMoveScript.UseVisualStyleBackColor = true;
            // 
            // GoodScript
            // 
            this.GoodScript.AutoSize = true;
            this.GoodScript.Location = new System.Drawing.Point(22, 75);
            this.GoodScript.Name = "GoodScript";
            this.GoodScript.Size = new System.Drawing.Size(207, 20);
            this.GoodScript.TabIndex = 2;
            this.GoodScript.TabStop = true;
            this.GoodScript.Text = "Производительный бизнес";
            this.GoodScript.UseVisualStyleBackColor = true;
            // 
            // MyScript
            // 
            this.MyScript.AutoSize = true;
            this.MyScript.Location = new System.Drawing.Point(22, 51);
            this.MyScript.Name = "MyScript";
            this.MyScript.Size = new System.Drawing.Size(182, 20);
            this.MyScript.TabIndex = 1;
            this.MyScript.TabStop = true;
            this.MyScript.Text = "Собственный сценарий";
            this.MyScript.UseVisualStyleBackColor = true;
            // 
            // GreedScript
            // 
            this.GreedScript.AutoSize = true;
            this.GreedScript.Location = new System.Drawing.Point(22, 27);
            this.GreedScript.Name = "GreedScript";
            this.GreedScript.Size = new System.Drawing.Size(182, 20);
            this.GreedScript.TabIndex = 0;
            this.GreedScript.TabStop = true;
            this.GreedScript.Text = "Нерациональная ловля";
            this.GreedScript.UseVisualStyleBackColor = true;
            // 
            // ValuesGB
            // 
            this.ValuesGB.Controls.Add(this.fisherCount);
            this.ValuesGB.Controls.Add(this.ShipPrice_tb);
            this.ValuesGB.Controls.Add(this.label2);
            this.ValuesGB.Controls.Add(this.SailorSalary_tb);
            this.ValuesGB.Controls.Add(this.label4);
            this.ValuesGB.Controls.Add(this.label5);
            this.ValuesGB.ForeColor = System.Drawing.Color.Black;
            this.ValuesGB.Location = new System.Drawing.Point(34, 216);
            this.ValuesGB.Name = "ValuesGB";
            this.ValuesGB.Size = new System.Drawing.Size(404, 128);
            this.ValuesGB.TabIndex = 40;
            this.ValuesGB.TabStop = false;
            this.ValuesGB.Text = "Управляемые переменные";
            // 
            // Kap_tb
            // 
            this.Kap_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kap_tb.Location = new System.Drawing.Point(121, 28);
            this.Kap_tb.Name = "Kap_tb";
            this.Kap_tb.Size = new System.Drawing.Size(128, 24);
            this.Kap_tb.TabIndex = 39;
            this.Kap_tb.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Капитал ";
            // 
            // OutValues
            // 
            this.OutValues.Controls.Add(this.label3);
            this.OutValues.Controls.Add(this.label6);
            this.OutValues.Controls.Add(this.ShipCount_tb);
            this.OutValues.Controls.Add(this.FishCount_tb);
            this.OutValues.ForeColor = System.Drawing.Color.Black;
            this.OutValues.Location = new System.Drawing.Point(34, 482);
            this.OutValues.Name = "OutValues";
            this.OutValues.Size = new System.Drawing.Size(404, 106);
            this.OutValues.TabIndex = 41;
            this.OutValues.TabStop = false;
            this.OutValues.Text = "Выходные переменные";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.razn_tb);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.rash_tb);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.prod_tb);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(38, 610);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 132);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прибыль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1261, 787);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.OutValues);
            this.Controls.Add(this.Kap_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valRegul);
            this.Controls.Add(this.ValuesGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.regulator_chb);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.years_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.valRegul.ResumeLayout(false);
            this.valRegul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ValuesGB.ResumeLayout(false);
            this.ValuesGB.PerformLayout();
            this.OutValues.ResumeLayout(false);
            this.OutValues.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShipPrice_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SailorSalary_tb;
        private System.Windows.Forms.TextBox ShipCount_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FishCount_tb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reprKoef_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dobKoef_tb;
        private System.Windows.Forms.Label years_label;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.CheckBox regulator_chb;
        private System.Windows.Forms.GroupBox valRegul;
        private System.Windows.Forms.TextBox prod_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rash_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox razn_tb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox fisherCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoMoveScript;
        private System.Windows.Forms.RadioButton GoodScript;
        private System.Windows.Forms.RadioButton MyScript;
        private System.Windows.Forms.RadioButton GreedScript;
        private System.Windows.Forms.GroupBox ValuesGB;
        private System.Windows.Forms.TextBox Kap_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OutValues;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

