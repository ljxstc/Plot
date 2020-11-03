using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Plot
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 鼠标按下为true
        /// </summary>
        private bool mouseDown = false;
        Point _oldPosition = new Point();
  
        public MainForm()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
            panel1.Parent = pictureBox1;
            panel1.BringToFront();
            var myModel = new PlotModel { Title = "Example 1" };
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.plotView1.Model = myModel;
            var myModel2 = new PlotModel { Title = "Example 2", Background = OxyColors.Transparent };
            myModel2.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            
            this.plotView2.Model = myModel2;
       
  


        }
        

        private void plotView1_Click(object sender, EventArgs e)
        {
            

        }
        
        /// <summary>
        /// 鼠标点击plotView2时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plotView2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            _oldPosition  = Cursor.Position;
        }
        /// <summary>
        /// 鼠标在plotView2上移动时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plotView2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                plotView2.Left += Cursor.Position.X - _oldPosition.X;
                plotView2.Top += Cursor.Position.Y - _oldPosition.Y;
                _oldPosition = Cursor.Position;
                
            }
        }
        /// <summary>
        /// 移动后鼠标释放的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plotView2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public static PlotModel BackgroundTransparent()
        {
            var model = new PlotModel { Title = "Background = Transparent", Background = OxyColors.Transparent };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            return model;
        }

    }
}
