# 软件开发文档
## 1 基本架构
根据软件需求，软件应设计为（C/S）架构，
其中，使用C/S结构拟采用Visio Studio，基于C#进行客户端软件设计；
## 2 设计思路
思路： 1.使用winform设计桌面应用程序界面；  
	2.后台编写数据读取类、计算类、实体类实现读取和计算操作。
## 3 程序执行流程
	1.载入原始数据
		1.1前端设置打开文件按钮，打开文件夹选择压力恢复数据文件（.xls/.xlsx）
			压力恢复数据应设置为标准格式，数据分两列，第一列为时间，第二列为该时刻压力，即P-T数据 	
		1.2调用ExcelDataReader包，读取Excel文件保存至DataSet  
			调用方法 ExcelProcess.ExcelToDataSet(string excelPath)  
		1.3将DataSet中数据存入动态数组ArrayList，数据类型为字符串string  	
			调用方法 ExcelProcess.DataSetToArrayList(DataSet dt)
		1.4将动态数组拆分成两组数组，分别为压力press和时间time
			调用方法 PressCal.PressAndTime( ArrayList arrayList ,ref double[] time, ref double[] press)
				使用引用参数ref传值
		1.5计算原始压力的压力差
			调用方法 PressCal.ToDelta(double[] press)
		1.6计算压力差的导数
			调用方法 ToDerP(double[] deltaPress,double[] t)
				由于C#没有计算导数的函数，因此采用matlab执行混合编译
				matlab编写函数Derivative(t1,deltaP)，生成dll动态链接库
				C#导入MWArray包用于矩阵计算			
	2.绘制原始数据的压力差-时间曲线（调用oxyPlot（Nuget包），绘制曲线）
		2.1开启窗口plotViewForm，窗口中仅有plotView一个控件，设置透明度为50%
		2.2设置鼠标拖拽操作，可拖拽窗口自由移动
		2.3消息提示，拖拽结束后提示是否完成，点击完成固定图窗，将点击的数据保存至PlotPointData，同时关闭窗口
	3.选择样板曲线，并绘制
		3.1进入MainForm后，下拉列表框默认赋值0，同时启动固定位置的图窗plotViewStateForm
		3.2新图窗进行样板数据加载，因数据量较大，设置为多线程加载（backgroundwork）
			加载过程显示进度条
		3.3加载完成后调用oxyplot绘制图像
			加载文件夹plotdata中的数据，数据设置为复制到debug目录下
			加载过程中标记每一列数据，用于识别
			设置点击事件保存数据
	4.原始曲线与样板曲线拟合
		4.1 考虑到用户误操作，拟合不成功等因素，设置完成拟合按钮，按下后才能进行下一步骤
		4.2 若该样板没有适合的曲线，可选择下拉列表更换样板，重复进行该工作
		4.3 点击匹配完成按钮，提示选择任意匹配点，进行下一步骤。
	5.记录两坐标轴区域的四个坐标值
		5.1此时程序状态是原始曲线覆盖在样板曲线上，原始曲线外观透明隐藏
		5.2点击原始曲线，记录该点坐标（曲线上的数值坐标）
		5.3点击样板曲线，记录该点坐标
		5.3调用PressCal相关方法进行计算 
	6.计算完成切换新窗口
		6.1 释放内存，清除所有图版数据（卡死）；
		6.2 给出所选坐标信息，初始数据信息，计算结果信息
		6.3 返回或退出

## 4 下载后的注意事项
    1.需要载入样板曲线.xlsx文件
	2.需要同时下载并引用Derivative.dll
