using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Plot
{
    public partial class MainForm : Form
    {
     
    [DllImport("user32")]
    public static extern int SetParent(int hWndChild, int hWndNewParent);

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
            Form frm1 = new plotViewStateForm();
            frm1.MdiParent = this;
            frm1.Show();

            //启动可活动图像窗体
            Form frm2 = new plotViewForm();
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
        

        private void plotView1_Click(object sender, EventArgs e)
        {
            

        }

    }
}
