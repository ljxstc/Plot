using HZH_Controls.Forms;
using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace Plot
{
    
    public partial class MainForm : Form
    {
        [DllImport("user32")]
        private static extern int mouse_event(int mouseevent, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        Form frm1 = new plotViewStateForm();
        Form frm2 = new plotViewForm();
        public MainForm()
        
        {
            InitializeComponent();
            //获取启动时主界面在屏幕上的坐标
            var screenPoint = PointToScreen(this.Location);
            //设置MDI主窗体背景颜色
            #region  
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            #endregion
            //启动固定位置子窗体
            
            frm1.MdiParent = this;
            frm1.Show();

            //启动可活动图像窗体
            
            //设置起始坐标
            Point plotPoint = new Point();
            plotPoint.X = screenPoint.X + 120;
            plotPoint.Y = screenPoint.Y + 183;
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = plotPoint;
            frm2.Show();
            frm2.BringToFront();
            pictureBox1.SendToBack();
           

        }

        Point mPoint = new Point();
        private void MainForm_Activated(object sender, EventArgs e)
        {

            if (PlotPointData.OutValue)
            {
               
                //模拟鼠标左键按下 
                const int MOUSEEVENTF_LEFTDOWN = 0x0002;
                //模拟鼠标左键抬起 
                const int MOUSEEVENTF_LEFTUP = 0x0004;

                ////鼠标按下
                mouse_event(MOUSEEVENTF_LEFTDOWN , 0, 0, 0, 0);
                //Thread.Sleep(50);
                //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //Thread.Sleep(50);
                //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //模拟鼠标左键按下 
            const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            //模拟鼠标左键抬起 
            const int MOUSEEVENTF_LEFTUP = 0x0004;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
    }
}
