using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
	public class CSV
	{
		/// <summary>
		/// 文件的编码。
		/// </summary>
		public Encoding CsvEncoding { get; set; } = Encoding.UTF8;

		/// <summary>
		/// 表示是否要进行列的裁剪操作。
		/// </summary>
		public bool TrimColumns { get; set; } = false;

		/// <summary>
		/// CSV的分隔符，默认为半角逗号（即,）。
		/// </summary>
		public char CsvSeparator { get; set; } = ',';

		/// <summary>
		/// 所有的数据都保存在些数组中。
		/// </summary>
		public List<List<string>> Data { get; set; } = new List<List<string>>();

		/// <summary>
		/// CSV是一种通用的使用逗号隔开的二维表的结构文件。
		/// </summary>
		public CSV() { }

		/// <summary>
		/// 通过指定的CSV文件进行加载。返回一个二维矩阵。
		/// </summary>
		/// <param name="filepath"></param>
		public CSV(string filepath) : this(filepath, Encoding.Default) { }

		/// <summary>
		/// 通过指定的CSV文件进行加载。
		/// </summary>
		/// <param name="filepath">指定的CSV文件路径。</param>
		/// <param name="encoding">CSV文本的编码。</param>
		public CSV(string filepath, Encoding encoding)
		{
			CsvEncoding = encoding;
			Read(filepath);
		}

		/// <summary>
		/// 返回CSV二维数列的总行数。
		/// </summary>
		/// <returns></returns>
		public int RowCount { get { return Data.Count; } }

		/// <summary>
		/// 返回CSV二维数列的总列数。
		/// </summary>
		public int ColumnCount { get { return Data != null && Data.Count > 0 ? Data[0].Count : 0; } }

		/// <summary>
		/// 返回指定行列的值，如果超出数据返回值为 null。
		/// </summary>
		/// <param name="row">指定行。</param>
		/// <param name="column">指定列。</param>
		/// <returns></returns>
		public string GetData(int row, int column)
		{
			return IsInRange(row, column) ? Data[row][column] : null;
		}

		/// <summary>
		/// 读写CSV指定单元格，下标从0开始。如果不在范围内，则会操作失败，处理方式如下：
		/// 读=返回null；写=返回false。
		/// </summary>
		/// <param name="row">指定的行。</param>
		/// <param name="column">指定的列。</param>
		/// <returns></returns>
		public string this[int row, int column]
		{
			get { return GetData(row, column); }
			set { SetData(row, column, value); }
		}

		/// <summary>
		/// 在指定行添加一行数据内容为""的字符数列。
		/// 输入数据的行数必需与 RowCount 相同，超出部分被裁掉，不足部分用""补充。
		/// 要插入的行的位置小于0的按0处理，大于等于RowCount的按RowCount处理。
		/// </summary>
		/// <param name="columnData">输入数据。</param>
		/// <param name="columnID">需要添加的行的序号。</param>
		public void AddColumn(string[] columnData = null, int columnID = int.MaxValue)
		{
			// 输入数据的长度必需与 ColumnCount相同，超出部分被裁掉，不足部分用""补充。
			columnData = columnData ?? new string[RowCount];
			List<string> list = new List<string>();
			for (int i = 0; i < ColumnCount; i++)
				list.Add(i < columnData.Length ? columnData[i] : "");

			// 要插入的行的位置小于0的按0处理，大于等于ColumnCount的按ColumnCount处理。
			columnID = columnID < 0 ? 0 : columnID;
			columnID = columnID >= ColumnCount ? ColumnCount : columnID;

			// 将数据插入指定位置。
			for (int i = 0; i < RowCount; i++)
				Data[i].Insert(columnID, columnData[i]);

		}

		/// <summary>
		/// 删除指定的某个列。
		/// </summary>
		/// <param name="columnId">待删除列的ID，范围为[0, ColumnCount)。</param>
		public void RemoveColumn(int columnId)
		{
			if (0 <= columnId && columnId < ColumnCount)
			{
				for (int row = 0; row < RowCount; row++)
				{
					Data[row].RemoveAt(columnId);
				}
			}
		}

		/// <summary>
		/// 删除指定的多个列。
		/// </summary>
		/// <param name="columnIds">待删除列的列的编号，可以是多个列。如果不在范围内，不会处理；如果有重复，只会处理1次。</param>
		public void RemoveColumns(params int[] columnIds)
		{
			columnIds.Distinct().OrderByDescending(c => c).ToList().ForEach(c => RemoveColumn(c));
		}


		/// <summary>
		/// 在指定行添加一行数据内容为""的字符数列。
		/// 输入数据的长度必需与 ColumnCount相同，超出部分被裁掉，不足部分用""补充。
		/// 要插入的行的位置小于0的按0处理，大于等于RowCount的按RowCount处理。
		/// </summary>
		/// <param name="strs">输入数据。</param>
		/// <param name="rowID">需要添加的行的序号。</param>
		public void AddRow(string[] strs = null, int rowID = int.MaxValue)
		{
			// 输入数据的长度必需与 ColumnCount相同，超出部分被裁掉，不足部分用""补充。
			strs = strs ?? new string[ColumnCount];
			List<string> list = new List<string>();
			for (int i = 0; i < ColumnCount; i++)
				list.Add(i < strs.Length ? strs[i] : "");

			// 要插入的行的位置小于0的按0处理，大于等于RowCount的按RowCount处理。
			rowID = rowID < 0 ? 0 : rowID;
			rowID = rowID >= RowCount ? RowCount : rowID;
			Data.Insert(rowID, list);
		}

		/// <summary>
		/// 在指定行添加一行数据内容为""的字符数列。
		/// </summary>
		/// <param name="rowNo">待插入的行号。</param>
		/// <param name="rowdata">待插入的数据。</param>
		public void AddRow(int rowNo, params string[] rowdata)
		{
			AddRow(rowdata, rowNo);
		}

		/// <summary>
		/// 判断指定行列的单元格是否在范围内。
		/// </summary>
		/// <param name="row">指定的行编号。</param>
		/// <param name="column">指定的列编号。</param>
		/// <returns></returns>
		public bool IsInRange(int row, int column) { return row >= 0 && row < RowCount && column >= 0 && column < ColumnCount; }

		/// <summary>
		/// 为指定编号的行列的单元格赋值。
		/// </summary>
		/// <param name="row">所要设置的行。</param>
		/// <param name="column">所要设置的列。</param>
		/// <param name="value">所要设置的值。</param>
		/// <returns></returns>
		public bool SetData(int row, int column, string value)
		{
			bool valid = IsInRange(row, column);
			if (valid)
				Data[row][column] = value;
			return valid;
		}

		/// <summary>
		/// 读取CSV数据文件, 目前的版本不支持带有分隔符的内容。
		/// </summary>
		/// <param name="csvfile">待加载的CSV文件。</param>
		public void Read(string csvfile)
		{
			Data = GetListCsvData(csvfile);
		}

		/// <summary>
		/// 将数据转换为二维列表。
		/// </summary>
		/// <returns></returns>
		public List<List<string>> GetListCsvData(string file)
		{
			StreamReader reader = new StreamReader(file, Encoding.UTF8);
			List<List<string>> tempListCsvData = new List<List<string>>();
			bool isNotEndLine = false;
			string tempCsvRowString = reader.ReadLine();

			// 对每行进行读写
			while (tempCsvRowString != null)
			{
				List<string> tempCsvRowList;
				if (isNotEndLine)
				{
					tempCsvRowList = ParseContinueLine(tempCsvRowString);
					isNotEndLine = (tempCsvRowList.Count > 0 && tempCsvRowList[tempCsvRowList.Count - 1].EndsWith("\r\n"));
					List<string> myNowContinueList = tempListCsvData[tempListCsvData.Count - 1];
					myNowContinueList[myNowContinueList.Count - 1] += tempCsvRowList[0];
					tempCsvRowList.RemoveAt(0);
					myNowContinueList.AddRange(tempCsvRowList);
				}
				else
				{
					tempCsvRowList = ParseLine(tempCsvRowString);
					isNotEndLine = (tempCsvRowList.Count > 0 && tempCsvRowList[tempCsvRowList.Count - 1].EndsWith("\r\n"));
					tempListCsvData.Add(tempCsvRowList);
				}
				tempCsvRowString = reader.ReadLine();
			}
			reader.Close();

			// 读取完成以后，可能不同的行有不同的数据个数，为了保证所有行的内容一样，添加以下内容：
			// 找到最大列数。
			int maxColumn = 0;
			for (int i = 0; i < tempListCsvData.Count; i++)
				maxColumn = tempListCsvData[i].Count > maxColumn ? tempListCsvData[i].Count : maxColumn;

			// 使所有行的列数都是 maxColumn
			foreach (List<string> item in tempListCsvData)
				while (item.Count < maxColumn)
					item.Add("");

			return tempListCsvData;
		}


		/// <summary>
		/// 处理未完成的Csv单行
		/// </summary>
		/// <param name="line">数据源</param>
		/// <returns>元素列表</returns>
		private List<string> ParseContinueLine(string line)
		{
			StringBuilder _columnBuilder = new StringBuilder();
			List<string> Fields = new List<string>();
			_columnBuilder.Remove(0, _columnBuilder.Length);
			if (line == "")
			{
				Fields.Add("\r\n");
				return Fields;
			}

			for (int i = 0; i < line.Length; i++)
			{
				char character = line[i];

				if ((i + 1) == line.Length)//这个字符已经结束了整行
				{
					if (character == '"') //正常转义结束，且该行已经结束
					{
						Fields.Add(TrimColumns ? _columnBuilder.ToString().TrimEnd() : _columnBuilder.ToString());
						return Fields;
					}
					else //异常结束，转义未收尾
					{
						_columnBuilder.Append("\r\n");
						Fields.Add(_columnBuilder.ToString());
						return Fields;
					}
				}
				else if (character == '"' && line[i + 1] == CsvSeparator) //结束转义，且后面有可能还有数据
				{
					Fields.Add(TrimColumns ? _columnBuilder.ToString().TrimEnd() : _columnBuilder.ToString());
					i++; //跳过下一个字符
					Fields.AddRange(ParseLine(line.Remove(0, i + 1)));
					break;
				}
				else if (character == '"' && line[i + 1] == '"') //双引号转义
				{
					i++; //跳过下一个字符
				}
				else if (character == '"') //双引号单独出现（这种情况实际上已经是格式错误，为了兼容暂时不处理）
				{
					throw new Exception("格式错误，错误的双引号转义");
				}
				_columnBuilder.Append(character);
			}
			return Fields;
		}

		/// <summary>
		/// 解析一行CSV数据。
		/// </summary>
		/// <param name="line">待分析的行。</param>
		/// <returns></returns>
		private List<string> ParseLine(string line)
		{
			StringBuilder sb = new StringBuilder();
			List<string> Fields = new List<string>();
			bool inColumn = false;  //是否是在一个列元素里
			bool inQuotes = false;  //是否需要转义
			bool isNotEnd = false;  //读取完毕未结束转义
			sb.Remove(0, sb.Length);

			//空行也是一个空元素,一个逗号是2个空元素
			if (line == "")
				Fields.Add("");

			// 遍历一个行中的所有元素。
			for (int i = 0; i < line.Length; i++)
			{
				char c = line[i];
				if (!inColumn)
				{
					inColumn = true;
					if (c == '"')
					{
						inQuotes = true;
						continue;
					}
				}

				// 如果有引用 
				if (inQuotes)
				{
					//这个字符已经结束了整行
					if ((i + 1) == line.Length)
					{
						//正常转义结束，且该行已经结束
						if (c == '"')
						{
							inQuotes = false;
							continue;
						}
						isNotEnd = true;
					}
					//结束转义，且后面有可能还有数据
					else if (c == '"' && line[i + 1] == CsvSeparator)
					{
						inQuotes = false;
						inColumn = false;
						i++;
					}
					//双引号转义
					else if (c == '"' && line[i + 1] == '"')
					{
						i++;
					}
					//双引号单独出现（这种情况实际上已经是格式错误，为了兼容可暂时不处理）
					else if (c == '"')
					{
						throw new Exception("格式错误，错误的双引号转义");
					}
				}
				else if (c == CsvSeparator)
				{
					inColumn = false;
				}

				//结束该元素时inColumn置为false，并且不处理当前字符，直接进行Add
				if (!inColumn)
				{
					Fields.Add(TrimColumns ? sb.ToString().Trim() : sb.ToString());
					sb.Remove(0, sb.Length);
				}
				else
				{
					sb.Append(c);
				}
			}

			// 标准格式一行结尾不需要逗号结尾，而上面for是遇到逗号才添加的，为了兼容最后还要添加一次
			if (inColumn)
			{
				if (isNotEnd)
					sb.Append("\r\n");

				Fields.Add(TrimColumns ? sb.ToString().Trim() : sb.ToString());
			}
			//如果inColumn为false，说明已经添加，因为最后一个字符为分隔符，所以后面要加上一个空元素
			else
			{
				Fields.Add("");
			}

			return Fields;
		}

		/// <summary>
		/// 将数据进行保存，默认使用编号进行保存。 
		/// </summary>
		/// <param name="outcsvfile">需要保存的路径。</param>
		public bool Save(string outcsvfile)
		{
			if (!File.Exists(outcsvfile))
				throw new Exception("find error in your FilePath");

			if (Data == null)
				throw new Exception("your DataSouse is null");

			// 将Data中的数据以非追加的方式写至指定的文件中。
			using (StreamWriter sw = new StreamWriter(outcsvfile, false, CsvEncoding))
			{
				foreach (List<string> fields in Data)
				{
					StringBuilder sb = new StringBuilder();
					for (int i = 0; i < fields.Count; i++)
					{
						sb.Append(fields[i].Contains("\"") ?
							string.Format("\"{0}\"", fields[i].Replace("\"", "\"\"")) :
							string.Format("\"{0}\"", fields[i]));

						if (i < fields.Count - 1)
							sb.Append(CsvSeparator);
					}
					sw.WriteLine(sb.ToString());
				}
			}

			return true;
		}

		/// <summary>
		/// 以二维表的形式返回氖Data的内容，同一行的相邻数据使用\t\t分隔。
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < Data.Count; i++)
			{
				sb.AppendLine(string.Join("\t\t", Data[i]));
			}
			return sb.ToString();
		}
	}
}
