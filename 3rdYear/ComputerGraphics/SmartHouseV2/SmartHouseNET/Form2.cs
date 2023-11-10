using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHouseNET
{
    public partial class Form2 : Form
    {
        public ChartValues<double> room1;
        public ChartValues<double> room2;
        public ChartValues<double> room3;

        public Form2(List<double> a, List<double> b, List<double> c)
        {
            room1 = CreateDataList(a);
            room2 = CreateDataList(b);
            room3 = CreateDataList(c);
            InitializeComponent();
        }

        public ChartValues<double> CreateDataList(List<double> a)
        {
            ChartValues<double> res = new ChartValues<double>();
            foreach (var item in a)
            {
                res.Add(item);
            }
            return res;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            LineSeries line = new LineSeries();
            line.Title = "Комната 1";
            line.Values = room1;

            LineSeries line2 = new LineSeries();
            line2.Title = "Комната 2";
            line2.Values = room2;

            LineSeries line3 = new LineSeries();
            line3.Title = "Комната 3";
            line3.Values = room3;

            series.Add(line);
            series.Add(line2);
            series.Add(line3);
            cartesianChart1.Series = series;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
