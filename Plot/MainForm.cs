using HZH_Controls.Forms;
using MathNet.Numerics.LinearAlgebra;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        private static Form frm1;
        
        public MainForm()

        {
            InitializeComponent();
            //获取启动时主界面在屏幕上的坐标
            var screenPoint = PointToScreen(this.Location);
            //存入实体类
            PlotPointData.screenPoint = screenPoint;


            #region  设置MDI主窗体背景颜色
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
            pictureBox1.SendToBack();



            #region 设置显示结果控件隐藏
            textBoxTransparent1.Hide();
            textBoxTransparent2.Hide();
            textBoxTransparent3.Hide();
            textBoxTransparent4.Hide();
            deltaP.Hide();
            deltaT.Hide();
            PD.Hide();
            Td.Hide();
            #endregion

            //设置图标
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();                      
            lstCom.Add(new KeyValuePair<string, string>("1", "均质地层球形流样板曲线"));
            lstCom.Add(new KeyValuePair<string, string>("2", "均质地层球形流-径向流样板曲线"));
            lstCom.Add(new KeyValuePair<string, string>("3", "复合地层球形流-径向流样板曲线"));
            this.ucCombox1.Source = lstCom;
            this.ucCombox1.SelectedIndex = 0;
            frm1 = new plotViewStateForm(this.ucCombox1.SelectedIndex);
            //启动固定位置子窗体
            frm1.MdiParent = this;
            frm1.FormClosed += FRM1_FormClosed;
            frm1.Show();



        }

        private void FRM1_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region 主窗体控件显示
            textBoxTransparent1.Show();
            textBoxTransparent2.Show();
            textBoxTransparent3.Show();
            textBoxTransparent4.Show();
            deltaP.Show();
            deltaT.Show();
            PD.Show();
            Td.Show();
            #endregion
            deltaP.Text = PlotPointData.OriX.ToString("0.00");
            deltaT.Text = PlotPointData.OriY.ToString("0.00");
            PD.Text = PlotPointData.StdX.ToString("0.00");
            Td.Text = PlotPointData.StdY.ToString("0.00");
        }

        Point mPoint = new Point();


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ////模拟鼠标左键按下 
            //const int MOUSEEVENTF_LEFTDOWN = 0x0002;
            ////模拟鼠标左键抬起 
            //const int MOUSEEVENTF_LEFTUP = 0x0004;
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);


        }

        [Obsolete]
        private void openFile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\压力反演";
            ofd.Filter = "表格文件|*.xlsx|表格文件|*.xls";
            //控制对话框在关闭之前是否恢复当前目录
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                #region 启动可活动图像窗体
                Form frm2 = new plotViewForm(ofd.FileName);
                //设置起始坐标
                Point plotPoint = new Point();
                plotPoint.X = PlotPointData.screenPoint.X + 120;
                plotPoint.Y = PlotPointData.screenPoint.Y + 183;
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = plotPoint;
                frm2.Show();
                frm2.BringToFront();
                
                #endregion

            }
        }

       

        private void ucCombox1_SelectedChangedEvent(object sender, EventArgs e)
        {
            if (frm1 != null)
            {
                frm1.Dispose();
                frm1 = new plotViewStateForm(this.ucCombox1.SelectedIndex);
                frm1.MdiParent = this;
                frm1.FormClosed += FRM1_FormClosed;
                frm1.Show();
            }
            else
            {
                frm1 = new plotViewStateForm(this.ucCombox1.SelectedIndex);
                frm1.MdiParent = this;
                frm1.FormClosed += FRM1_FormClosed;
                frm1.Show();
            }
                       
            
        }

       
    }
}
