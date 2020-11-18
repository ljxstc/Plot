using OxyPlot;
using OxyPlot.Axes;
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

        public PlotModel plotModel = new PlotModel();
        public int percent { get; set; }

        public plotViewStateForm(int selectIndex)
        {
            InitializeComponent();
            
            
            if (selectIndex == 0)
            {
                plotModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = plotModel;
            }
            else if (selectIndex == 1)
            {
                plotModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = plotModel;
            }
            else if (selectIndex == 2)
            {
                plotModel.Series.Add(new FunctionSeries(Math.Tan, 0, 10, 0.1, "tan(x)"));
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                plotModel.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = plotModel;
            }
            
        }


        [Obsolete]
        private void plotView1_MouseDown(object sender, MouseEventArgs e)
        {

            //追踪点击事件，获取坐标值
            this.plotView1.Model.TrackerChanged += (s, e1) =>
            {
                this.plotView1.Model.Subtitle = e1.HitResult != null ? "Tracker item index = " + e1.HitResult.DataPoint : "Not tracking";
                //不刷新数据
                this.plotView1.Model.InvalidatePlot(false);
                //保存原始数据
                PlotPointData.StdX = e1.HitResult.DataPoint.X;
                PlotPointData.StdY = e1.HitResult.DataPoint.Y;

               this.Close();
               
            };

           
        }

      

       
    }
}
