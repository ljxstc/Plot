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

        [Obsolete]
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<List<LineSeries>> lists = new List<List<LineSeries>>();
            
            if (index == 0)
            {

                string[] dataPath = { "plotdata\\CdS=0.1.csv" ,
                "plotdata\\CdS=0.3.csv",
                "plotdata\\CdS=1.csv",
                "plotdata\\CdS=3.csv",
                "plotdata\\CdS=11.csv",
                "plotdata\\CdS=2.csv",
                "plotdata\\CdS=3.csv",
                "plotdata\\CdS=4.csv",
                "plotdata\\CdS=6.csv",
                "plotdata\\CdS=8.csv",
                "plotdata\\CdS=12.csv",
                "plotdata\\CdS=15.csv",
                "plotdata\\CdS=20.csv",
                "plotdata\\CdS=30.csv",
                "plotdata\\CdS=40.csv",
                "plotdata\\CdS=50.csv",
                "plotdata\\CdS=60.csv"
                };
                string[] timePath = {
                "plotdata\\t.csv",
                "plotdata\\td.csv"
                };
                OxyColor[] colors = {OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red,
                    OxyColors.Red
                                    };
                plotModel = PlotModelExamples.multidataLine(dataPath, timePath, colors, backgroundWorker1, ref lists);
                ucProcessLine1.Hide();
                label1.Hide();
                PlotModelExamples.plotEvent(lists, plotModel);
                this.plotView1.Model = plotModel;
                
                
            }
            else if (index == 1)
            {
            //    string[] dataPath = { "D:\\压力反演\\PC=1S=1.csv"
            //};
            //    OxyColor[] colors = {OxyColors.Red,
            //    OxyColors.Blue,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic,
            //    OxyColors.Automatic};
            //    //List<LineSeries> list = TrackerExamples.dataLine(dataPath, OxyColors.Red);
            //    //PlotModel plot1 = TrackerExamples.plotCurveLine(list);
            //    plotModel = PlotModelExamples.multidataLine(dataPath, colors, backgroundWorker1,ref lists);
            //    ucProcessLine1.Hide();
            //    label1.Hide();
            //    PlotModelExamples.plotEvent(lists, plotModel);
            //    this.plotView1.Model = plotModel;


            }
            else if (index == 2)
            {
                //string[] dataPath = {
                //"D:\\压力反演\\PC=1S=10.csv"};
                //OxyColor[] colors = {OxyColors.Red,
                //OxyColors.Blue,
                //OxyColors.Automatic,
                //OxyColors.Automatic,
                //OxyColors.Automatic,
                //OxyColors.Automatic,
                //OxyColors.Automatic,
                //OxyColors.Automatic,
                //OxyColors.Automatic};
                ////List<LineSeries> list = TrackerExamples.dataLine(dataPath, OxyColors.Red);
                ////PlotModel plot1 = TrackerExamples.plotCurveLine(list);
                //plotModel = PlotModelExamples.multidataLine(dataPath, colors, backgroundWorker1, ref lists);
                //ucProcessLine1.Hide();
                //label1.Hide();
                //PlotModelExamples.plotEvent(lists, plotModel);
                //this.plotView1.Model = plotModel;
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
                MessageBox.Show($"已获取曲线值:{PlotPointData.StdX},{PlotPointData.StdY}" +
                    $"选取的曲线条：{PlotPointData.name}");
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
