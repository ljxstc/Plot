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
        private int index;

        public plotViewStateForm(int selectIndex)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            index = selectIndex;
            backgroundWorker1.RunWorkerAsync();
 
        }


       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<List<LineSeries>> lists = new List<List<LineSeries>>();
            
            if (index == 0)
            {
                string[] dataPath = { "plotdata\\PC=1S=1.csv" ,
                "plotdata\\PC=1S=10.csv",
                "plotdata\\PC=1S=20.csv",
                "plotdata\\PC=10S=1.csv",
                "plotdata\\PC=10S=10.csv",
                "plotdata\\PC=10S=20.csv",
                "plotdata\\PC=100S=1.csv",
                "plotdata\\PC=100S=10.csv",
                "plotdata\\PC=100S=20.csv"};
                OxyColor[] colors = {OxyColors.Red,
                OxyColors.Blue,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic};
                plotModel = PlotModelExamples.multidataLine(dataPath, colors, backgroundWorker1, ref lists);
                ucProcessLine1.Hide();
                label1.Hide();
                PlotModelExamples.plotEvent(lists, plotModel);
                this.plotView1.Model = plotModel;
                
                
            }
            else if (index == 1)
            {
                string[] dataPath = { "D:\\压力反演\\PC=1S=1.csv"
            };
                OxyColor[] colors = {OxyColors.Red,
                OxyColors.Blue,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic};
                //List<LineSeries> list = TrackerExamples.dataLine(dataPath, OxyColors.Red);
                //PlotModel plot1 = TrackerExamples.plotCurveLine(list);
                plotModel = PlotModelExamples.multidataLine(dataPath, colors, backgroundWorker1,ref lists);
                ucProcessLine1.Hide();
                label1.Hide();
                PlotModelExamples.plotEvent(lists, plotModel);
                this.plotView1.Model = plotModel;


            }
            else if (index == 2)
            {
                string[] dataPath = {
                "D:\\压力反演\\PC=1S=10.csv"};
                OxyColor[] colors = {OxyColors.Red,
                OxyColors.Blue,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic,
                OxyColors.Automatic};
                //List<LineSeries> list = TrackerExamples.dataLine(dataPath, OxyColors.Red);
                //PlotModel plot1 = TrackerExamples.plotCurveLine(list);
                plotModel = PlotModelExamples.multidataLine(dataPath, colors, backgroundWorker1, ref lists);
                ucProcessLine1.Hide();
                label1.Hide();
                PlotModelExamples.plotEvent(lists, plotModel);
                this.plotView1.Model = plotModel;
            }

            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ucProcessLine1.Value = e.ProgressPercentage;
        }

        private void plotView1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void plotView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlotPointData.OutValue == true && PlotPointData.StdX != 0.0)
            {
                MessageBox.Show("已获取曲线值");
                backgroundWorker1.CancelAsync();
                backgroundWorker1.Dispose();
                plotView1.Dispose();
                this.Close();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("取消成功");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("线程工作异常：" + e.Error.ToString());
            }
            
        }
    }
}
