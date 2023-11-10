using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Fishing2
{
    public partial class Form1 : Form
    {
        //time
        public int days = 0;
        public int month = 0;
        private int year = 0;
        
        //переменные для работы
        public long Kapital = 1000;
        public long Rashody;
        public int ShipCount = 1;//кол-во кораблей
        public int SailorsCount;//кол-во моряков на корабле
        public int SailorSalary;//зарплата моряка
        public int ShipPrice;//стоимость корабля
        public int SrokSluzhby = 20;//срок службы корабля
        public double investKoef;//коэф. на инвестиции
        public double Investitions;//инвестиции
        //public double Nalogi;
        public double Zatraty;//Зарплаты + амортизация
        public double DemandPrice;//цена за одну рыбешку
        public double Production;//кол-во моряков на корабле
        public int ShipImpact = 20;//кол-во рыбы, которое ловит один корабль
        public double Fish = 1000;//кол-во рыбы 
        
        public double ReprKoef = 1.10;//коэф репродукции
        public double DobKoef = 1;//коэф добычи
        public double AllPribyl = 0;//вся прибыль
        public int MaxShips = 5000;


        public Form1()
        {
            InitializeComponent();
            OutValues.Enabled = false;
        }

        public double DoubleParse(string str)
        {
            double res;
            bool b = double.TryParse(str, out res);
            if (!b)
            {
                return 1;
            }
            return res;
        }

        private void FirstStep()
        {       
            if (MyScript.Checked)
            {
                ValuesGB.Enabled = true;
                valRegul.Enabled = true;
                DemandPrice = 20;
                ShipPrice = (int)DoubleParse(ShipPrice_tb.Text);
                SailorSalary = (int)DoubleParse(SailorSalary_tb.Text);
                SailorsCount = (int)DoubleParse(fisherCount.Text);

                Zatraty = (ShipCount * SailorsCount * SailorSalary) + (ShipPrice / SrokSluzhby * ShipCount);
                if (ShipCount == 5000)
                    Investitions = 0;
                else
                    Investitions = Kapital * 0.30;
            }
            else
            {
                ValuesGB.Enabled = false;
                SailorsCount = 10;
                SailorSalary = 15;
                ShipPrice = 1000;

                if (GreedScript.Checked)
                {
                    DemandPrice = 20;
                    valRegul.Enabled = false;
                    DobKoef = 1;
                    ReprKoef = 1.1;

                    Zatraty = (ShipCount * SailorsCount * SailorSalary) + (ShipPrice / SrokSluzhby * ShipCount);
                    if (ShipCount == 5000)
                        Investitions = 0;
                    else
                        Investitions = Kapital * 0.30;
                }
                else if (GoodScript.Checked)
                {
                    DemandPrice = 20;
                    valRegul.Enabled = false;
                    double MyFish = ShipCount * ShipImpact;
                    if (MyFish > Fish / 5)
                    {
                        ReprKoef = 2;
                        DobKoef = 0.1;
                    }
                    else
                    {
                        ReprKoef = 1.15;
                        DobKoef = 1;
                    }

                    Zatraty = (ShipCount * SailorsCount * SailorSalary) + (ShipPrice / SrokSluzhby * ShipCount);
                    if (ShipCount == 5000)
                        Investitions = 0;
                    else
                        Investitions = Kapital * 0.30;
                }
                else
                {
                    valRegul.Enabled = false;
                    DemandPrice = 13;
                    Zatraty = (ShipCount * SailorsCount * SailorSalary) + (ShipPrice / SrokSluzhby * ShipCount);
                    Investitions = Kapital*0.05;
                }
            }

            
            
        }

        private void SecondStep()
        {
            if (Investitions != 0)
            {
                if (Investitions < ShipPrice)
                {
                    Kapital += (long)Investitions;
                    Rashody = (long)(Zatraty);
                }
                else
                {
                    Rashody = (long)(Investitions + Zatraty);
                    double dopInv = Investitions;
                    while (dopInv > ShipPrice && ShipCount < MaxShips)
                    {
                        ShipCount += 1;
                        dopInv -= ShipPrice;
                    }
                }
            }

            
            ShipPrice_tb.Text = ShipPrice.ToString();
            ShipCount_tb.Text = ShipCount.ToString();
            SailorSalary_tb.Text = SailorSalary.ToString();
            fisherCount.Text = SailorsCount.ToString(); 
        }


        public void ThirdStep()
        {
            //regulator
            if (ShipCount == MaxShips)
            {
                if (Fish < 3000000)
                {
                    ReprKoef = 1.126;
                    DobKoef = 1;
                }
                else
                {
                    ReprKoef = 1.09;
                    DobKoef = 1;
                }
                
            }
            else
            {
                double MyFish = ShipCount * ShipImpact;
                if (regulator_chb.Checked)
                {
                    valRegul.Enabled = false;
                    if (MyFish > Fish / 5)
                    {
                        ReprKoef = 2;
                        DobKoef = 0.1;
                    }
                    else
                    {
                        ReprKoef = 1.15;
                        DobKoef = 1;
                    }
                }
            }

            
            



            //расчет капитала, расходов и доходов
            Production = ShipCount * ShipImpact * DemandPrice * 0.87 * DobKoef; //0.13 - nalog
            AllPribyl += Production - Rashody;
            Kapital = (long)(Kapital + AllPribyl);


            //вывод на экран
            Kap_tb.Text = Kapital.ToString();
            dobKoef_tb.Text = DobKoef.ToString();   
            reprKoef_tb.Text = ReprKoef.ToString();           
            prod_tb.Text = Production.ToString();
            rash_tb.Text = Rashody.ToString();
            razn_tb.Text = (Production - Rashody).ToString();
        }

        public void FourthStep()
        {
            double MyFish = ShipCount * ShipImpact * DobKoef;
            Fish = (Fish - MyFish) * ReprKoef;
            if (Fish > 0)
            {
                FishCount_tb.Text = Fish.ToString();
                if (Kapital > 0)
                {
                    Kap_tb.Text = Kapital.ToString();
                }
                else
                {
                    MessageBox.Show("Ошибка! Капитал отрицательный");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Кол-во рыбы меньше 0");
                this.Close();
            }
        }

        public void DateTimer()
        {
            month += 1;
            year = month / 12;

            month_label.Text = "Пройдено месяцев = " + month.ToString();
            years_label.Text = "Пройдено лет = " + year.ToString();
        }

        private void Graphs()
        {
            if (Fish != null)
            {
                chart1.Series[0].Points.Add(Fish);
                chart2.Series[0].Points.Add(Kapital);
                chart3.Series[0].Points.Add(ShipCount);
            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //   Kapital = double.Parse(Kap_tb.Text);
            Graphs();
            FirstStep();
            SecondStep();
            ThirdStep();
            FourthStep();
            
            DateTimer();
            
        }

    }
}
