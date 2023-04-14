namespace PK_07_WykresEEG
{
    partial class UserControlWave
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxWave = new System.Windows.Forms.GroupBox();
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.numericUpDownAmplitude = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxWave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxWave
            // 
            this.groupBoxWave.Controls.Add(this.checkBoxVisible);
            this.groupBoxWave.Controls.Add(this.numericUpDownAmplitude);
            this.groupBoxWave.Controls.Add(this.numericUpDownFrequency);
            this.groupBoxWave.Controls.Add(this.label2);
            this.groupBoxWave.Controls.Add(this.label1);
            this.groupBoxWave.Location = new System.Drawing.Point(4, 4);
            this.groupBoxWave.Name = "groupBoxWave";
            this.groupBoxWave.Size = new System.Drawing.Size(128, 83);
            this.groupBoxWave.TabIndex = 0;
            this.groupBoxWave.TabStop = false;
            this.groupBoxWave.Text = "groupBox1";
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.Checked = true;
            this.checkBoxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisible.Location = new System.Drawing.Point(10, 19);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVisible.TabIndex = 4;
            this.checkBoxVisible.Text = "Visible";
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.waveParameter_Changed);
            // 
            // numericUpDownAmplitude
            // 
            this.numericUpDownAmplitude.Location = new System.Drawing.Point(66, 55);
            this.numericUpDownAmplitude.Name = "numericUpDownAmplitude";
            this.numericUpDownAmplitude.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownAmplitude.TabIndex = 3;
            this.numericUpDownAmplitude.ValueChanged += new System.EventHandler(this.waveParameter_Changed);
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(10, 55);
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownFrequency.TabIndex = 2;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.waveParameter_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency";
            // 
            // UserControlWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxWave);
            this.Name = "UserControlWave";
            this.Size = new System.Drawing.Size(135, 94);
            this.groupBoxWave.ResumeLayout(false);
            this.groupBoxWave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWave;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxVisible;
    }
}
