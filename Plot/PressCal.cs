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
using Plot;

namespace Plot
{
    /// <summary>
    /// 压力数据计算
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

        /// <summary>
        /// 计算反演结果
        /// </summary>
        /// <param name="p">压力</param>
        /// <param name="pd">样板压力</param>
        /// <param name="t">时间</param>
        /// <param name="td">样板时间</param>
        /// <param name="name">曲线名</param>
        /// <param name="q">流量</param>
        /// <param name="b">地层体积系数</param>
        /// <param name="u">粘度</param>
        /// <returns></returns>
        public static double[] KhCal(double p, double pd,double t, double td, int name, double q, double b, double u )
        {
            //pd / deltaP
            double pdP = pd / p;
            //td / deltaT
            double tdT = td / t;
            //cd和S
            double[] cdS = PressCal.cdS(name);
            //渗透率kh
            double kh = 141.2 * q * b * u * pdP;
            //管储系数
            double c = 0.000295 * kh / (u * tdT);
            //表皮系数
            double s = cdS[1];
            double[] result = new double[3];
            result[0] = kh;
            result[1] = c;
            result[2] = s;
            return result;

        }

        /// <summary>
        /// 通过选择的曲线得到Cd和S的值
        /// </summary>
        /// <param name="name">选择曲线名</param>
        /// <returns></returns>
        public static double[] cdS(int name)
        {
            double cd, s;
            double [] cdS = new double[2];
            if (name ==0 )
            {
                cd = 1;
                s = 1;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 2 | name == 3)
            {
                cd = 1;
                s = 10;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 4 | name == 5)
            {
                cd = 1;
                s = 20;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 6 | name == 7)
            {
                cd = 10;
                s = 1;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 8 | name == 9)
            {
                cd = 10;
                s = 10;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 10 | name == 11)
            {
                cd = 10;
                s = 20;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 12 | name == 13)
            {
                cd = 100;
                s = 1;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 14 | name == 15)
            {
                cd = 100;
                s = 10;
                cdS[0] = cd;
                cdS[1] = s;
            }
            else if (name == 16 | name == 17)
            {
                cd = 100;
                s = 20;
                cdS[0] = cd;
                cdS[1] = s;
            }
            return cdS;
            

        }

    }
}
