using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartProgram
{
	public partial class FORM : Form
	{
		public FORM()
		{
			InitializeComponent();
		}

		private void FORM_Load(object sender, EventArgs e)
		{
			CHART.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
			CHART.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
			CHART.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
			CHART.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;

			CHART.ChartAreas["ChartArea1"].CursorY.IsUserEnabled = true;
			CHART.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;
			CHART.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
			CHART.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

			using (StreamWriter file = new StreamWriter(@"C:\Users\mende\source\repos\func2.txt"))
			{
				for (double x = -10.0; x < 10.0; x += 0.5f)
				{
					file.WriteLine(Math.Sin(x));
				}
			}

			REFRESHCHART.Start();
		}

		private void REFRESHCHART_Tick(object sender, EventArgs e)
		{
			func1(FROM.Text, TO.Text, STEP.Text);
		}

		private void func1(string from, string to, string step)
		{
			CHART.Series["F1"].Points.Clear();

			double x;
			double S;
			double F;
			double T;

			S = double.Parse(step);
			F = double.Parse(from);
			T = double.Parse(to);

			if (S < 0.5)
			{
				S = 0.5;
			}
			if (F < -50.0)
			{
				F = -50.0;
			}
			if (T > 50.0)
			{
				T = 50.0;
			}

			for (x = F; x < T; x += S)
			{
				if (2.0 < x && x < 3.0)
				{
					CHART.Series["F1"].Points.AddXY(x, (Math.Pow(Math.E, Math.Sqrt(x + 2.0))) * ((1.0 / 7.0) + Math.Log(Math.Sqrt(x))) * (1.0 / (3.5 + x)));
				}
				else if (-2.0 < x && x <= 2.0)
				{
					CHART.Series["F1"].Points.AddXY(x, Math.Pow(x, 2));
				}
				else
				{
					CHART.Series["F1"].Points.AddXY(x, x);
				}
			}
		}

		private void LOAD_Click(object sender, EventArgs e)
		{
			OPENFILE.InitialDirectory = @"C:\Users\mende\source\repos";
			OPENFILE.DefaultExt = "txt";
			OPENFILE.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

			if (OPENFILE.ShowDialog() == DialogResult.OK)
			{
				CHART.Series["F2"].Points.Clear();

				string[] file = File.ReadAllLines(OPENFILE.FileName);

				double x = -10.0;
				foreach (string floats in file)
				{
					CHART.Series["F2"].Points.AddXY(x, double.Parse(floats));
					x += 0.5;
				}
			}
		}
	}
}
