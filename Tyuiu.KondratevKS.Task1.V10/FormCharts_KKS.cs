using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KondratevKS.Task1.V10
{
    public partial class FormCharts_KKS : Form
    {
        public FormCharts_KKS()
        {
            InitializeComponent();
        }
        public void SetData(List<int> data)
        {
            chart1.Series.Clear();
            Series series = new Series("OrderCost");
            series.ChartType = SeriesChartType.Column;
            series.Points.DataBindY(data);
            chart1.Series.Add(series);
            chart1.Update();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
