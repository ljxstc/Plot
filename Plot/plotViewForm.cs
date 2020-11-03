using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Plot
{
    public partial class plotViewForm : Form
    {
        public plotViewForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            
            var myModel = new PlotModel { Title = "Example 1",Background = OxyColors.Transparent };
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.plotView1.Model = myModel;
           
        }

        private Point mPoint = new Point();
        private void plotViewForm_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void plotViewForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosition = MousePosition;
                myPosition.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosition;
            }
        }
    }
}
