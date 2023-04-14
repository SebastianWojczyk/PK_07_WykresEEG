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

            foreach (Object o in flowLayoutPanelConfig.Controls)
            {
                if (o is UserControlWave)
                {
                    UserControlWave wave = o as UserControlWave;
                    wave.WaveChanged += W_WaveChanged;
                    W_WaveChanged(wave);
                }
            }
        }

        private void W_WaveChanged(UserControlWave sender)
        {
            Series s;
            s = chartWaves.Series.SingleOrDefault(x => x.Name == sender.WaveName);

            //pierwszy raz
            if (s == null)
            {
                s = new Series();
                s.Name = sender.WaveName;
                s.Color = sender.WaveColor;
                s.ChartType = SeriesChartType.Line;
                chartWaves.Series.Add(s);
            }
            else
            {
                s.Points.Clear();
            }
            if (sender.WaveVisible)
            {
                for (double x = 0; x < 10; x += 0.02)
                {
                    s.Points.AddXY(x, sender.GetY(x));
                }
            }

            chartWaves.Series.Remove(chartWaves.Series.SingleOrDefault(x => x.Name == "EEG"));

            Series sum = new Series();
            sum.Name = "EEG";
            sum.Color = Color.Black;
            sum.BorderWidth = 5;
            sum.ChartType = SeriesChartType.Line;

            for (double x = 0; x < 10; x += 0.02)
            {
                double ySum = 0;
                //foreach(UserControlWave wave in flowLayoutPanelConfig.Controls)
                foreach (Series tmp in chartWaves.Series)
                {
                    //if (wave.WaveVisible)
                    if (tmp.Points.Count > 0)
                    {
                        ySum += tmp.Points.Single(p => p.XValue == x).YValues[0];
                        //ySum += wave.GetY(x);
                    }
                }
                sum.Points.AddXY(x, ySum);
            }

            chartWaves.Series.Add(sum);
        }
    }
}
