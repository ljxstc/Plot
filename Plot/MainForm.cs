using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Windows.Forms;
namespace Plot
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 鼠标按下为true
        /// </summary>
        private bool mouseDown;

        /// <summary>
        /// 鼠标在事件源的位置
        /// </summary>
        private int CurX = 0;
        private int CurY = 0;
        public MainForm()
        {
            InitializeComponent();
            var myModel = new PlotModel { Title = "Example 1" };
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.plotView1.Model = myModel;

            var myModel2 = new PlotModel { Title = "Example 2" };
            myModel2.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            this.plotView2.Model = myModel2;
        }

        /// <summary>
        /// 鼠标点击plotView2时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plotView1_Click(object sender, EventArgs e)
        {
            

        }
        

        private void plotView2_MouseDown(object sender, MouseEventArgs e)
        {
            CurX = e.X;
            CurY = e.Y;
            mouseDown = true;
           
        }

      
    }
}
