namespace Plot
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deltaP = new HZH_Controls.Controls.TextBoxEx();
            this.deltaT = new HZH_Controls.Controls.TextBoxEx();
            this.PD = new HZH_Controls.Controls.TextBoxEx();
            this.Td = new HZH_Controls.Controls.TextBoxEx();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ucCombox1 = new HZH_Controls.Controls.UCCombox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new HZH_Controls.Controls.TextBoxEx();
            this.oriData = new System.Windows.Forms.GroupBox();
            this.ReverseBox = new System.Windows.Forms.GroupBox();
            this.S = new HZH_Controls.Controls.TextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.c = new HZH_Controls.Controls.TextBoxEx();
            this.label7 = new System.Windows.Forms.Label();
            this.kh = new HZH_Controls.Controls.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.openFile = new HZH_Controls.Controls.UCBtnImg();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.oriData.SuspendLayout();
            this.ReverseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deltaP
            // 
            this.deltaP.DecLength = 4;
            this.deltaP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deltaP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deltaP.InputType = HZH_Controls.TextInputType.NotControl;
            this.deltaP.Location = new System.Drawing.Point(181, 37);
            this.deltaP.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.deltaP.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.deltaP.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.deltaP.Name = "deltaP";
            this.deltaP.OldText = null;
            this.deltaP.PromptColor = System.Drawing.Color.Gray;
            this.deltaP.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deltaP.PromptText = "";
            this.deltaP.ReadOnly = true;
            this.deltaP.RegexPattern = "";
            this.deltaP.Size = new System.Drawing.Size(100, 33);
            this.deltaP.TabIndex = 10;
            // 
            // deltaT
            // 
            this.deltaT.DecLength = 4;
            this.deltaT.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deltaT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deltaT.InputType = HZH_Controls.TextInputType.NotControl;
            this.deltaT.Location = new System.Drawing.Point(521, 37);
            this.deltaT.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.deltaT.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.deltaT.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.deltaT.Name = "deltaT";
            this.deltaT.OldText = null;
            this.deltaT.PromptColor = System.Drawing.Color.Gray;
            this.deltaT.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deltaT.PromptText = "";
            this.deltaT.ReadOnly = true;
            this.deltaT.RegexPattern = "";
            this.deltaT.Size = new System.Drawing.Size(100, 33);
            this.deltaT.TabIndex = 11;
            // 
            // PD
            // 
            this.PD.DecLength = 4;
            this.PD.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PD.InputType = HZH_Controls.TextInputType.NotControl;
            this.PD.Location = new System.Drawing.Point(181, 117);
            this.PD.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PD.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.PD.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PD.Name = "PD";
            this.PD.OldText = null;
            this.PD.PromptColor = System.Drawing.Color.Gray;
            this.PD.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PD.PromptText = "";
            this.PD.ReadOnly = true;
            this.PD.RegexPattern = "";
            this.PD.Size = new System.Drawing.Size(100, 33);
            this.PD.TabIndex = 12;
            // 
            // Td
            // 
            this.Td.DecLength = 4;
            this.Td.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Td.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Td.InputType = HZH_Controls.TextInputType.NotControl;
            this.Td.Location = new System.Drawing.Point(521, 116);
            this.Td.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Td.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.Td.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Td.Name = "Td";
            this.Td.OldText = null;
            this.Td.PromptColor = System.Drawing.Color.Gray;
            this.Td.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Td.PromptText = "";
            this.Td.ReadOnly = true;
            this.Td.RegexPattern = "";
            this.Td.Size = new System.Drawing.Size(100, 33);
            this.Td.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucCombox1
            // 
            this.ucCombox1.BackColor = System.Drawing.Color.Transparent;
            this.ucCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ucCombox1.ConerRadius = 5;
            this.ucCombox1.DropPanelHeight = -1;
            this.ucCombox1.FillColor = System.Drawing.Color.White;
            this.ucCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucCombox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucCombox1.IsRadius = true;
            this.ucCombox1.IsShowRect = true;
            this.ucCombox1.ItemWidth = 70;
            this.ucCombox1.Location = new System.Drawing.Point(1239, 21);
            this.ucCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCombox1.Name = "ucCombox1";
            this.ucCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucCombox1.RectWidth = 1;
            this.ucCombox1.SelectedIndex = -1;
            this.ucCombox1.SelectedValue = "";
            this.ucCombox1.Size = new System.Drawing.Size(318, 52);
            this.ucCombox1.Source = null;
            this.ucCombox1.TabIndex = 22;
            this.ucCombox1.TextValue = null;
            this.ucCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(225)))));
            this.ucCombox1.SelectedChangedEvent += new System.EventHandler(this.ucCombox1_SelectedChangedEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1904, 1041);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "原始压力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(405, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "样板曲线压力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(356, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "样板曲线时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(649, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "选取的样板曲线";
            // 
            // name
            // 
            this.name.DecLength = 4;
            this.name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name.InputType = HZH_Controls.TextInputType.NotControl;
            this.name.Location = new System.Drawing.Point(826, 117);
            this.name.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.name.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.name.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.name.Name = "name";
            this.name.OldText = null;
            this.name.PromptColor = System.Drawing.Color.Gray;
            this.name.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.name.PromptText = "";
            this.name.ReadOnly = true;
            this.name.RegexPattern = "";
            this.name.Size = new System.Drawing.Size(100, 33);
            this.name.TabIndex = 29;
            // 
            // oriData
            // 
            this.oriData.Controls.Add(this.name);
            this.oriData.Controls.Add(this.label4);
            this.oriData.Controls.Add(this.label5);
            this.oriData.Controls.Add(this.Td);
            this.oriData.Controls.Add(this.label2);
            this.oriData.Controls.Add(this.label3);
            this.oriData.Controls.Add(this.label1);
            this.oriData.Controls.Add(this.deltaT);
            this.oriData.Controls.Add(this.deltaP);
            this.oriData.Controls.Add(this.PD);
            this.oriData.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oriData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oriData.Location = new System.Drawing.Point(40, 114);
            this.oriData.Name = "oriData";
            this.oriData.Size = new System.Drawing.Size(969, 200);
            this.oriData.TabIndex = 31;
            this.oriData.TabStop = false;
            this.oriData.Text = "匹配原始数据";
            // 
            // ReverseBox
            // 
            this.ReverseBox.Controls.Add(this.S);
            this.ReverseBox.Controls.Add(this.label8);
            this.ReverseBox.Controls.Add(this.c);
            this.ReverseBox.Controls.Add(this.label7);
            this.ReverseBox.Controls.Add(this.kh);
            this.ReverseBox.Controls.Add(this.label6);
            this.ReverseBox.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReverseBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReverseBox.Location = new System.Drawing.Point(40, 339);
            this.ReverseBox.Name = "ReverseBox";
            this.ReverseBox.Size = new System.Drawing.Size(969, 132);
            this.ReverseBox.TabIndex = 32;
            this.ReverseBox.TabStop = false;
            this.ReverseBox.Text = "反演结果";
            // 
            // S
            // 
            this.S.DecLength = 4;
            this.S.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.S.ForeColor = System.Drawing.SystemColors.WindowText;
            this.S.InputType = HZH_Controls.TextInputType.NotControl;
            this.S.Location = new System.Drawing.Point(825, 54);
            this.S.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.S.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.S.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.S.Name = "S";
            this.S.OldText = null;
            this.S.PromptColor = System.Drawing.Color.Gray;
            this.S.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.S.PromptText = "";
            this.S.ReadOnly = true;
            this.S.RegexPattern = "";
            this.S.Size = new System.Drawing.Size(101, 33);
            this.S.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(668, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "表皮系数（S）";
            // 
            // c
            // 
            this.c.DecLength = 4;
            this.c.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c.ForeColor = System.Drawing.SystemColors.WindowText;
            this.c.InputType = HZH_Controls.TextInputType.NotControl;
            this.c.Location = new System.Drawing.Point(539, 54);
            this.c.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.c.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.c.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.c.Name = "c";
            this.c.OldText = null;
            this.c.PromptColor = System.Drawing.Color.Gray;
            this.c.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.c.PromptText = "";
            this.c.ReadOnly = true;
            this.c.RegexPattern = "";
            this.c.Size = new System.Drawing.Size(101, 33);
            this.c.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(381, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "管储系数（C）";
            // 
            // kh
            // 
            this.kh.DecLength = 4;
            this.kh.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kh.InputType = HZH_Controls.TextInputType.NotControl;
            this.kh.Location = new System.Drawing.Point(256, 54);
            this.kh.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.kh.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.kh.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.kh.Name = "kh";
            this.kh.OldText = null;
            this.kh.PromptColor = System.Drawing.Color.Gray;
            this.kh.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kh.PromptText = "";
            this.kh.ReadOnly = true;
            this.kh.RegexPattern = "";
            this.kh.Size = new System.Drawing.Size(101, 33);
            this.kh.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(30, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "渗透率×厚度（K×h）";
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.White;
            this.openFile.BtnBackColor = System.Drawing.Color.White;
            this.openFile.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.openFile.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.openFile.BtnText = "";
            this.openFile.ConerRadius = 10;
            this.openFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFile.EnabledMouseEffect = true;
            this.openFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.openFile.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.openFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
            this.openFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFile.ImageFontIcons = ((object)(resources.GetObject("openFile.ImageFontIcons")));
            this.openFile.IsRadius = true;
            this.openFile.IsShowRect = false;
            this.openFile.IsShowTips = false;
            this.openFile.Location = new System.Drawing.Point(20, 9);
            this.openFile.Margin = new System.Windows.Forms.Padding(0);
            this.openFile.Name = "openFile";
            this.openFile.RectColor = System.Drawing.Color.White;
            this.openFile.RectWidth = 1;
            this.openFile.Size = new System.Drawing.Size(60, 64);
            this.openFile.TabIndex = 34;
            this.openFile.TabStop = false;
            this.openFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFile.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.openFile.TipsText = "打开文件";
            this.openFile.BtnClick += new System.EventHandler(this.openFile_BtnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.ReverseBox);
            this.Controls.Add(this.oriData);
            this.Controls.Add(this.ucCombox1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.oriData.ResumeLayout(false);
            this.oriData.PerformLayout();
            this.ReverseBox.ResumeLayout(false);
            this.ReverseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private HZH_Controls.Controls.TextBoxEx deltaP;
        private HZH_Controls.Controls.TextBoxEx deltaT;
        private HZH_Controls.Controls.TextBoxEx PD;
        private HZH_Controls.Controls.TextBoxEx Td;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private HZH_Controls.Controls.UCCombox ucCombox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.TextBoxEx name;
        private System.Windows.Forms.GroupBox oriData;
        private System.Windows.Forms.GroupBox ReverseBox;
        private HZH_Controls.Controls.TextBoxEx S;
        private System.Windows.Forms.Label label8;
        private HZH_Controls.Controls.TextBoxEx c;
        private System.Windows.Forms.Label label7;
        private HZH_Controls.Controls.TextBoxEx kh;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCBtnImg openFile;
    }
}

