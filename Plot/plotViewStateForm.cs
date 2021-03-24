﻿using OxyPlot;
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
                    OxyColors.PaleGreen
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
                plotView1.Dispose();
                this.Close();
            }
        }



    }
}
