using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevconTools;

namespace LiveCharts {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //plotPoints();
        }

        /*private void plotPoints() {
            chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Series1"].Color = Color.Red;

            for (int i = 0; i <= numericUpDown1.Value; i++) {
                chart1.Series["Series1"].Points.AddXY(i, 1);
            }        
        }*/
    }
}
