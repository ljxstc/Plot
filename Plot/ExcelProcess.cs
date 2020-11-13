
using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    /// <summary>
    /// EXCEL处理类
    /// </summary>
    class ExcelProcess
    {
        /// <summary>
        /// 读取Excel文件，转换为DataSet格式
        /// </summary>
        /// <param name="excelPath">文件路径</param>
        /// <returns></returns>
        public static DataSet ExcelToDataSet(string excelPath)
        {
            FileStream stream = new FileStream(excelPath, FileMode.Open, FileAccess.Read);//定义文件流
            var reader = ExcelReaderFactory.CreateReader(stream);
            do
            {
                while (reader.Read())
                {
                    // reader.GetDouble(0);
                }
            } while (reader.NextResult());

            //1、DataSet----the result of each spreadsheet will be created in the result Table
            DataSet result = reader.AsDataSet();
            stream.Close();
            return result;

        }

        /// <summary>
        /// DataSet转换为动态数组
        /// </summary>
        /// <param name="dt">数据集</param>
        /// <returns></returns>
        public static ArrayList DataSetToArrayList(DataSet dt)
        {

            int rowsCount = dt.Tables[0].Rows.Count;
            int columnsCount = dt.Tables[0].Columns.Count;
            string[,] str = new string[rowsCount, columnsCount];
            ArrayList arrayList = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        str[i, j] = dt.Tables[0].Rows[i][j].ToString();
                    }
                }

                for (int j = 0; j < columnsCount; j++)
                {
                    for (int i = 0; i < rowsCount; i++)
                    {
                        if (str[i, j].Equals("") || str[i, j] == null)
                        {
                            continue;
                        }
                        else
                        {
                            arrayList.Add(str[i, j]);
                        }
                    }
                }


            }
            return arrayList;
        }
    }
}

