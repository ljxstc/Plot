using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Plot
{
    static class PlotPointData
    {
        /// <summary>
        /// 原始数据坐标
        /// </summary>
        public static double OriX { get; set; }
        public static double OriY { get; set; }
        /// <summary>
        /// 鼠标指针坐标
        /// </summary>
        public static double CurX { get; set; }
        public static double CurY { get; set; }
        /// <summary>
        /// 样板曲线坐标
        /// </summary>
        public static double StdX { get; set; }
        public static double StdY { get; set; }

        public static bool OutValue  { get; set; }
        /// <summary>
        /// 主界面启动坐标
        /// </summary>
        public static Point screenPoint { get; set; }
        /// <summary>
        /// 载入文件路径
        /// </summary>
        public static string fileName { get; set; }

        public static double q { get; set; }
        public static double b { get; set; }
        public static double ct { get; set; }

        public static double h { get; set; }

        public static double rw { get; set; }

        public static double u { get; set; }

        public static double phi { get; set; }

    }
}
