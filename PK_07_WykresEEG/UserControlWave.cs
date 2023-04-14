using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_07_WykresEEG
{
    public partial class UserControlWave : UserControl
    {
        public delegate void WaveAction(UserControlWave sender);
        public event WaveAction WaveChanged;

        public bool WaveVisible
        {
            get => checkBoxVisible.Checked;
        }
        public string WaveName
        {
            get => groupBoxWave.Text;
        }
        public Color WaveColor
        {
            get => groupBoxWave.ForeColor;
        }
        public UserControlWave()
        {
            InitializeComponent();
        }

        public UserControlWave(string name, double freq, double amp, Color color)
        {
            InitializeComponent();

            groupBoxWave.Text = name;
            numericUpDownFrequency.Value = Convert.ToDecimal(freq);
            numericUpDownAmplitude.Value = Convert.ToDecimal(amp);
            groupBoxWave.ForeColor = color;

        }

        public double GetY(double x)
        {
            return Convert.ToDouble(numericUpDownAmplitude.Value) *
                   Math.Sin(Convert.ToDouble(numericUpDownFrequency.Value) * x);
        }

        private void waveParameter_Changed(object sender, EventArgs e)
        {
            /*if (WaveChanged != null)
            {
                WaveChanged(this);
            }*/
            WaveChanged?.Invoke(this);
        }
    }
}
