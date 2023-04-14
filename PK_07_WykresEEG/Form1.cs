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

namespace PK_07_WykresEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Delta", 5, 20, Color.Red));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Teta", 10, 10, Color.Blue));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Alfa", 8, 8, Color.Green));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("SMR", 16, 4, Color.Magenta));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Beta", 18, 3, Color.Orange));
            flowLayoutPanelConfig.Controls.Add(new UserControlWave("Beta 2", 35, 7, Color.Brown));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartWaves.Series.Clear();
            foreach (Object o in flowLayoutPanelConfig.Controls)
            {
                if (o is UserControlWave)
                {
                    UserControlWave wave = o as UserControlWave;

                    Series s = new Series();
                    s.Name = wave.WaveName;
                    s.Color = wave.WaveColor;
                    s.ChartType = SeriesChartType.Line;
                    for (double x = 0; x < 10; x += 0.03)
                    {
                        s.Points.AddXY(x, wave.GetY(x));
                    }
                    chartWaves.Series.Add(s);
                }
            }
        }
    }
}
