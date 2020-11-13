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
        
        
        
        public plotViewStateForm(int selectIndex)
        {
            InitializeComponent();
            PlotModel model = new PlotModel();
            if (selectIndex == 0)
            {
                model.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = model;
            }
            else if (selectIndex == 1)
            {
                model.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = model;
            }
            else if (selectIndex == 2)
            {
                model.Series.Add(new FunctionSeries(Math.Tan, 0, 10, 0.1, "tan(x)"));
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
                model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
                this.plotView1.Model = model;
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
