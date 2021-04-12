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

        [Obsolete]
        public plotViewStateForm(int selectIndex)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            index = selectIndex;
            



            List<List<LineSeries>> lists = new List<List<LineSeries>>();

            if (index == 0)
            {
                PlotPointData.formName = 0;
                string[] CdS_str = { "0.1", "0.3", "1", "2.3", "3", "11", "2", "3", "4",
                    "6", "8", "9", "12", "15", "20", "26", "30", "40", "50", "60"};
                string[] dataPath = new string[20];
                for (int i = 0; i < dataPath.Length; i++)
                {
                    dataPath[i] = $"plotdata\\CdS={CdS_str[i]}.csv";
                }               
                string[] timePath = {
                "plotdata\\t.csv",
                "plotdata\\td.csv"
                };
                OxyColor[] colors = {OxyColors.Red,
                    OxyColors.Black,
                    OxyColors.Blue,
                    OxyColors.Pink,
                    OxyColors.BlueViolet,
                    OxyColors.Brown,
                    OxyColors.Aqua,
                    OxyColors.AliceBlue,
                    OxyColors.RosyBrown,
                    OxyColors.IndianRed,
                    OxyColors.Gold,
                    OxyColors.Green,
                    OxyColors.Gray,
                    OxyColors.Yellow,
                    OxyColors.Orange,
                    OxyColors.DeepSkyBlue,
                    OxyColors.PaleGreen,
                    OxyColors.BlanchedAlmond,
                    OxyColors.Olive,
                    OxyColors.YellowGreen
                                    };
                plotModel = PlotModelExamples.multidataLine(dataPath, timePath, colors, ref lists);
                PlotModelExamples.plotEvent(lists, plotModel);
                //plotModel = PlotModelExamples.AbsoluteMaximum();
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
                PlotPointData.formName = 0;
                string[] CdS_str = { "0.1", "0.3", "1", "2.3", "3", "11", "2", "3", "4",
                    "6", "8", "9", "12", "15", "20", "26", "30", "40", "50", "60"};
                string[] dataPathCdS = new string[20];
                for (int i = 0; i < dataPathCdS.Length; i++)
                {
                    dataPathCdS[i] = $"plotdata\\CdS={CdS_str[i]}.csv";
                }
                string[] timePathCds = {
                "plotdata\\t.csv",
                "plotdata\\td.csv"
                };

                OxyColor[] colors = {OxyColors.Red,
                    OxyColors.Black,
                    OxyColors.Blue,
                    OxyColors.Pink,
                    OxyColors.BlueViolet,
                    OxyColors.Brown,
                    OxyColors.Aqua,
                    OxyColors.AliceBlue,
                    OxyColors.RosyBrown,
                    OxyColors.IndianRed,
                    OxyColors.Gold,
                    OxyColors.Green,
                    OxyColors.Gray,
                    OxyColors.Yellow,
                    OxyColors.Orange,
                    OxyColors.DeepSkyBlue,
                    OxyColors.PaleGreen,
                    OxyColors.BlanchedAlmond,
                    OxyColors.Olive,
                    OxyColors.YellowGreen
                                    };
                plotModel = PlotModelExamples.multidataLine(dataPathCdS, timePath, colors, ref lists);
                PlotModelExamples.plotEvent(lists, plotModel);
                //plotModel = PlotModelExamples.AbsoluteMaximum();
                this.plotView1.Model = plotModel;
            }


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

                this.Close();
            }
        }



    }
}
