using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plot
{
    class PlotModelExamples
    {
        public static PlotModel AmdahlsLaw()
        {
            var model = new PlotModel { Title = "Amdahl's law" };

            Legend l = new Legend
            {
                LegendTitle = "Parallel portion"
            };
            model.Legends.Add(l);

            // http://en.wikipedia.org/wiki/Amdahl's_law
            Func<double, int, double> maxSpeedup = (p, n) => 1.0 / ((1.0 - p) + (double)p / n);
            Func<double, LineSeries> createSpeedupCurve = p =>
            {
                // todo: tracker does not work when smoothing = true (too few points interpolated on the left end of the curve)
                var ls = new LineSeries { Title = p.ToString("P0") };
                for (int n = 1; n <= 65536; n *= 2) ls.Points.Add(new DataPoint(n, maxSpeedup(p, n)));
                return ls;
            };
            model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom, Title = "Number of processors", Base = 2, MajorGridlineStyle = LineStyle.Solid, TickStyle = OxyPlot.Axes.TickStyle.None });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 20, MinorStep = 2, MajorStep = 2, Title = "Speedup", StringFormat = "F2", MajorGridlineStyle = LineStyle.Solid, TickStyle = OxyPlot.Axes.TickStyle.None });
            model.Series.Add(createSpeedupCurve(0.5));
            model.Series.Add(createSpeedupCurve(0.75));
            model.Series.Add(createSpeedupCurve(0.9));
            model.Series.Add(createSpeedupCurve(0.95));

            return model;
        }

        public static PlotModel DefaultValues()
        {
            var m = new PlotModel();
            m.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
            m.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });
            return m;
        }
        public static PlotModel NoInterpolation()
        {
            var model = new PlotModel { Title = "No tracker interpolation", Subtitle = "Used for discrete values or scatter plots." };
            var l = new Legend
            {
                LegendSymbolLength = 100
            };

            model.Legends.Add(l);

            var s1 = new LineSeries
            {
                Title = "Series 1",
                CanTrackerInterpolatePoints = false,
                Color = OxyColors.SkyBlue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 6,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.SkyBlue,
                MarkerStrokeThickness = 1.5
            };
            for (int i = 0; i < 63; i++)
            {
                s1.Points.Add(new DataPoint((int)(Math.Sqrt(i) * Math.Cos(i * 0.1)), (int)(Math.Sqrt(i) * Math.Sin(i * 0.1))));
            }

            model.Series.Add(s1);

            return model;
        }

        [Obsolete]
        public static PlotModel TrackerChangedEvent()
        {
            var model = new PlotModel { Title = "Handling the TrackerChanged event", Subtitle = "Press the left mouse button to test the tracker." };
            model.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 100));
            model.TrackerChanged += (s, e) =>
            {
                model.Subtitle = e.HitResult != null ? "Tracker item index = " + e.HitResult.DataPoint : "Not tracking";
                model.InvalidatePlot(false);
            };
            return model;
        }

        [Obsolete]
        public static PlotModel PlotPressAndTime(ArrayList arrayList)
        {
            var model = new PlotModel { Title = "原始数据", Background = OxyColors.Transparent };
            int arrayEnd = arrayList.Count / 2;

            //声明数组
            double[] time = new double[arrayEnd];
            double[] press = new double[arrayEnd];
            double[] deltaPress = new double[arrayEnd];
            double[,] derPress = new double[arrayEnd - 1, 1];
            double[] derTime = new double[arrayEnd - 1];

            //计算几个数据
            PressCal.PressAndTime(arrayList, ref time, ref press);
            deltaPress = PressCal.ToDelta(press);
            derPress = PressCal.ToDerP(deltaPress, time);
            for (int i = 1; i < time.Length; i++)
            {
                derTime[i - 1] = time[i];
            }

            #region 绘制压力-时间曲线
            var s1 = new LineSeries
            {
                Title = "压力差-时间曲线",
                CanTrackerInterpolatePoints = false,
                Color = OxyColors.SkyBlue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.SkyBlue,
                MarkerStrokeThickness = 1.5
            };

            for (int i = 0; i < time.Length; i++)
            {
                s1.Points.Add(new DataPoint(time[i], deltaPress[i]));
            }
            #endregion

            model.Series.Add(s1);

            #region 绘制压力导数-时间曲线
            var s2 = new LineSeries
            {
                Title = "压力差导数-时间曲线",
                CanTrackerInterpolatePoints = false,
                Color = OxyColors.Red,
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Red,
                MarkerStrokeThickness = 1.5
            };

            for (int i = 0; i < derTime.Length; i++)
            {
                s2.Points.Add(new DataPoint(derTime[i], derPress[i, 0]));
            }
            model.Series.Add(s2);
            #endregion

            //更改为对数坐标图
            model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left });

            //model.TrackerChanged += (s, e) =>
            //{
            //    model.Subtitle = e.HitResult != null ? "Tracker item index = " + e.HitResult.DataPoint : "Not tracking";
            //    model.InvalidatePlot(false);
            //};
            return model;
        }
    }
}
