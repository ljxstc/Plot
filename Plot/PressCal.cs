using System;
using System.Collections;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Derivative;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    /// <summary>
    /// 原始压力数据计算
    /// </summary>
    class PressCal
    {
        /// <summary>
        /// 动态数组拆分为压力和时间浮点型数组
        /// </summary>
        /// <param name="arrayList">通过DataTable转换的动态数组</param>
        /// <param name="time">浮点型时间数组，引用参数</param>
        /// <param name="press">浮点型压力数组，引用参数</param>
        public static void PressAndTime( ArrayList arrayList ,ref double[] time, ref double[] press)
        {
            int arrayEnd = arrayList.Count / 2;
            
            object[] timeAndPress = arrayList.ToArray();

            for (int i = 0; i < timeAndPress.Length / 2; i++)
            {
                time[i] = Convert.ToDouble(timeAndPress[i]);
            }
            for (int i = timeAndPress.Length / 2; i < timeAndPress.Length; i++)
            {
                press[i - timeAndPress.Length / 2] = Convert.ToDouble(timeAndPress[i]);
            }
        }

        /// <summary>
        /// 压力转换为压力差
        /// </summary>
        /// <param name="press"></param>
        /// <returns></returns>
        public static double[] ToDelta(double[] press)
        {
            double[] deltaPress = new double[press.Length];
            for (int i = 0; i < press.Length; i++)
            {
                deltaPress[i] = press[i] - press[0];
            }

            return deltaPress;
        }
        /// <summary>
        /// 计算压力差的导数
        /// </summary>
        /// <param name="deltaPress">压力差</param>
        /// <param name="t">时间</param>
        /// <returns></returns>
        public static double[,] ToDerP(double[] deltaPress,double[] t)
        {
            MatlabCalLib derivative = new MatlabCalLib();
            MWNumericArray deltaP = deltaPress;
            MWNumericArray t1 = t;
            MWArray derPress = derivative.Derivative(t1,deltaP);
            double[,] derPress1 = new double[deltaPress.Length-1,1];
            derPress1 = (double[,])derPress.ToArray();
            return derPress1;
        }

    }
}
