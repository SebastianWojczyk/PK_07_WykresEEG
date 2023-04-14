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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmplitude = new System.Windows.Forms.NumericUpDown();
            this.groupBoxWave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBoxWave.Controls.Add(this.numericUpDownAmplitude);
            this.groupBoxWave.Controls.Add(this.numericUpDownFrequency);
            this.groupBoxWave.Controls.Add(this.label2);
            this.groupBoxWave.Controls.Add(this.label1);
            this.groupBoxWave.Location = new System.Drawing.Point(4, 4);
            this.groupBoxWave.Name = "groupBox1";
            this.groupBoxWave.Size = new System.Drawing.Size(114, 78);
            this.groupBoxWave.TabIndex = 0;
            this.groupBoxWave.TabStop = false;
            this.groupBoxWave.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(7, 20);
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownFrequency.TabIndex = 2;
            // 
            // numericUpDownAmplitude
            // 
            this.numericUpDownAmplitude.Location = new System.Drawing.Point(7, 46);
            this.numericUpDownAmplitude.Name = "numericUpDownAmplitude";
            this.numericUpDownAmplitude.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownAmplitude.TabIndex = 3;
            // 
            // UserControlWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxWave);
            this.Name = "UserControlWave";
            this.Size = new System.Drawing.Size(129, 90);
            this.groupBoxWave.ResumeLayout(false);
            this.groupBoxWave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWave;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
