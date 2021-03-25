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
using OxyPlot.Axes;
using System.Windows.Forms;
using OxyPlot.Legends;
using HZH_Controls.Forms;
using HZH_Controls;
using System.Collections;

namespace Plot
{
    public partial class plotViewForm : Form
    {

        

        [Obsolete]
        public plotViewForm(string fileName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            DataSet dt = ExcelProcess.ExcelToDataSet(fileName);
            //string类型动态数组
            ArrayList arrayList = ExcelProcess.DataSetToArrayList(dt);
            PlotModel plotModel = PlotModelExamples.PlotPressAndTime(arrayList);
            this.plotView1.Model = plotModel;
            formLocation.X = PlotPointData.screenPoint.X + 120;
            formLocation.Y = PlotPointData.screenPoint.Y + 183;
        }


        /// <summary>
        /// 鼠标拖拽事件
        /// </summary>
        #region 
        //屏幕初始位置
        private Point formLocation = new Point();
        private Point mPoint = new Point();
        //鼠标拖拽标志
        private bool isDrag = false;
        //鼠标选点标志
        private bool chosePoint1 = false;
        //鼠标是否抬起
        private bool isMouseUp = false;
        
        /// <summary>
        /// 鼠标按下事件，给坐标赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void plotView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (chosePoint1 == true)
            {
                isDrag = false;
                //追踪点击事件，获取坐标值
                this.plotView1.Model.TrackerChanged += (s, e1) =>
                {
                    //不刷新数据
                    this.plotView1.Model.InvalidatePlot(false);
                    //保存原始数据
                    PlotPointData.OriX = e1.HitResult.DataPoint.X;
                    PlotPointData.OriY = e1.HitResult.DataPoint.Y;
                    //获取鼠标坐标
                    PlotPointData.CurX = mPoint.X;
                    PlotPointData.CurY = mPoint.Y;
                    this.Close();
                    
                };

            }
            else
            {
                mPoint.X = e.X;
                mPoint.Y = e.Y;
                isDrag = true;
            }
        }






        /// <summary>
        /// 鼠标移动事件，拖拽图窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plotView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                Point myPosition = MousePosition;
                myPosition.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosition;
                this.Location = myPosition;
            }
        }

        #endregion

        /// <summary>
        /// 释放鼠标按钮，产生提示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void plotView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseUp == false)
            {
                isMouseUp = true;
                return;
            }
            if (isMouseUp == true)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string msg = "是否完成曲线拟合？";
                string cation = "注意";
                var result = MessageBox.Show(msg, cation, buttons);
                if (result == DialogResult.Yes)
                {
                    isDrag = false;
                    this.Location = formLocation;
                    MessageBox.Show("请选择右侧曲线中合适的图版曲线，完成粗拟合", "提示");
                    //MessageBox.Show("请点击曲线上的点进行拟合", "提示");
                    //chosePoint1 = true;
                }
            }
           
        }

    }
    
}
