using System;
using System.IO;
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
				for (double x = -10.0; x < 10.0; x += 0.1)
				{
					file.WriteLine(Math.Sin(x));
				}
			}

			REFRESHCHART.Start();
		}

		private void REFRESHCHART_Tick(object sender, EventArgs e)
		{
			double F = double.Parse(FROM.Text);
			double T = double.Parse(TO.Text);
			double S = double.Parse(STEP.Text);
			func1(F, T, S);
		}

		private void func1(double from, double to, double step)
		{
			CHART.Series["F1"].Points.Clear();

			double x;

			if (step < 0.01)
			{
				step = 0.01;
			}
			if (from < -50.0)
			{
				from = -50.0;
			}
			if (to > 50.0)
			{
				to = 50.0;
			}

			for (x = from; x < to; x += step)
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
			CHART.Series["F2"].Points.Clear();

			OPENFILE.InitialDirectory = @"C:\Users\mende\source\repos";
			OPENFILE.DefaultExt = "txt";
			OPENFILE.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

			if (OPENFILE.ShowDialog() == DialogResult.OK)
			{

				string[] file = File.ReadAllLines(OPENFILE.FileName);

				double x = -10.0;
				foreach (string floats in file)
				{
					CHART.Series["F2"].Points.AddXY(x, double.Parse(floats));
					x += 0.1;
				}
			}
		}
	}
}
