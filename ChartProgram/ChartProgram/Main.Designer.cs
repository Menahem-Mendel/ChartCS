namespace ChartProgram
{
	partial class FORM
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.CHART = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.FROM = new System.Windows.Forms.TextBox();
			this.TO = new System.Windows.Forms.TextBox();
			this.STEP = new System.Windows.Forms.TextBox();
			this.LOAD = new System.Windows.Forms.Button();
			this.REFRESHCHART = new System.Windows.Forms.Timer(this.components);
			this.OPENFILE = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.CHART)).BeginInit();
			this.SuspendLayout();
			// 
			// CHART
			// 
			this.CHART.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AxisX.InterlacedColor = System.Drawing.Color.LightCyan;
			chartArea1.AxisX.LineColor = System.Drawing.Color.Brown;
			chartArea1.AxisX.LineWidth = 2;
			chartArea1.AxisX2.LineColor = System.Drawing.Color.Red;
			chartArea1.AxisX2.LineWidth = 2;
			chartArea1.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			chartArea1.AxisY.LineColor = System.Drawing.Color.Olive;
			chartArea1.AxisY.LineWidth = 2;
			chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
			chartArea1.BackColor = System.Drawing.Color.White;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.Name = "ChartArea1";
			this.CHART.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.BackSecondaryColor = System.Drawing.Color.White;
			legend1.Name = "Legend1";
			this.CHART.Legends.Add(legend1);
			this.CHART.Location = new System.Drawing.Point(118, 12);
			this.CHART.Name = "CHART";
			this.CHART.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "F1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "F2";
			this.CHART.Series.Add(series1);
			this.CHART.Series.Add(series2);
			this.CHART.Size = new System.Drawing.Size(1280, 749);
			this.CHART.TabIndex = 0;
			this.CHART.Text = "CHART";
			// 
			// FROM
			// 
			this.FROM.Location = new System.Drawing.Point(12, 12);
			this.FROM.Name = "FROM";
			this.FROM.Size = new System.Drawing.Size(100, 20);
			this.FROM.TabIndex = 1;
			this.FROM.Text = "-10.0";
			// 
			// TO
			// 
			this.TO.Location = new System.Drawing.Point(12, 38);
			this.TO.Name = "TO";
			this.TO.Size = new System.Drawing.Size(100, 20);
			this.TO.TabIndex = 2;
			this.TO.Text = "10.0";
			// 
			// STEP
			// 
			this.STEP.Location = new System.Drawing.Point(12, 64);
			this.STEP.Name = "STEP";
			this.STEP.Size = new System.Drawing.Size(100, 20);
			this.STEP.TabIndex = 3;
			this.STEP.Text = "0.5";
			// 
			// LOAD
			// 
			this.LOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LOAD.BackColor = System.Drawing.Color.Transparent;
			this.LOAD.Location = new System.Drawing.Point(12, 738);
			this.LOAD.Name = "LOAD";
			this.LOAD.Size = new System.Drawing.Size(100, 23);
			this.LOAD.TabIndex = 4;
			this.LOAD.Text = "Load";
			this.LOAD.UseVisualStyleBackColor = false;
			this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
			// 
			// REFRESHCHART
			// 
			this.REFRESHCHART.Tick += new System.EventHandler(this.REFRESHCHART_Tick);
			// 
			// OPENFILE
			// 
			this.OPENFILE.FileName = "OPENFILE";
			// 
			// FORM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1410, 773);
			this.Controls.Add(this.LOAD);
			this.Controls.Add(this.STEP);
			this.Controls.Add(this.TO);
			this.Controls.Add(this.FROM);
			this.Controls.Add(this.CHART);
			this.Name = "FORM";
			this.Text = "main";
			this.Load += new System.EventHandler(this.FORM_Load);
			((System.ComponentModel.ISupportInitialize)(this.CHART)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart CHART;
		private System.Windows.Forms.TextBox FROM;
		private System.Windows.Forms.TextBox TO;
		private System.Windows.Forms.TextBox STEP;
		private System.Windows.Forms.Button LOAD;
		private System.Windows.Forms.Timer REFRESHCHART;
		private System.Windows.Forms.OpenFileDialog OPENFILE;
	}
}

