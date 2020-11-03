using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plot
{
    public partial class plotViewStateForm : Form
    {
        public plotViewStateForm()
        {
            InitializeComponent();
            var myModel = new PlotModel { Title = "Example 2" };
            myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            this.plotView1.Model = myModel;
        }
    }
}
