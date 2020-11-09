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
        PlotModel myModel = new PlotModel { Title = "Example 2" };
        public plotViewStateForm()
        {
            InitializeComponent();
            
            myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            this.plotView1.Model = myModel;
        }

        private void plotView1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("11");
            //追踪点击事件，获取坐标值
            myModel.TrackerChanged += (s, e1) =>
            {
                myModel.Subtitle = e1.HitResult != null ? "Tracker item index = " + e1.HitResult.DataPoint : "Not tracking";
                //不刷新数据
                myModel.InvalidatePlot(false);
                //保存原始数据
                //PlotPointData.StdX = e1.HitResult.DataPoint.X;
                //PlotPointData.StdY = e1.HitResult.DataPoint.Y;

            };
        }
    }
}
