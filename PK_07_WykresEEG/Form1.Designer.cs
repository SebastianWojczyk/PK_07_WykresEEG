﻿namespace PK_07_WykresEEG
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartWaves = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanelConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.chartWaves, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelConfig, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartWaves
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWaves.ChartAreas.Add(chartArea1);
            this.chartWaves.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartWaves.Legends.Add(legend1);
            this.chartWaves.Location = new System.Drawing.Point(3, 3);
            this.chartWaves.Name = "chartWaves";
            this.chartWaves.Size = new System.Drawing.Size(974, 629);
            this.chartWaves.TabIndex = 0;
            this.chartWaves.Text = "chart1";
            // 
            // flowLayoutPanelConfig
            // 
            this.flowLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConfig.Location = new System.Drawing.Point(983, 3);
            this.flowLayoutPanelConfig.Name = "flowLayoutPanelConfig";
            this.flowLayoutPanelConfig.Size = new System.Drawing.Size(144, 629);
            this.flowLayoutPanelConfig.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "EEG";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaves;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConfig;
    }
}

