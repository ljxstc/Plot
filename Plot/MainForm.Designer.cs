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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTransparent1 = new HZH_Controls.Controls.TextBoxTransparent();
            this.textBoxTransparent2 = new HZH_Controls.Controls.TextBoxTransparent();
            this.textBoxTransparent3 = new HZH_Controls.Controls.TextBoxTransparent();
            this.textBoxTransparent4 = new HZH_Controls.Controls.TextBoxTransparent();
            this.deltaP = new HZH_Controls.Controls.TextBoxEx();
            this.deltaT = new HZH_Controls.Controls.TextBoxEx();
            this.PD = new HZH_Controls.Controls.TextBoxEx();
            this.Td = new HZH_Controls.Controls.TextBoxEx();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.ucCombox1 = new HZH_Controls.Controls.UCCombox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // textBoxTransparent1
            // 
            this.textBoxTransparent1.BackAlpha = 10;
            this.textBoxTransparent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTransparent1.DecLength = 2;
            this.textBoxTransparent1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransparent1.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxTransparent1.Location = new System.Drawing.Point(556, 107);
            this.textBoxTransparent1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxTransparent1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxTransparent1.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxTransparent1.Name = "textBoxTransparent1";
            this.textBoxTransparent1.OldText = null;
            this.textBoxTransparent1.PromptColor = System.Drawing.Color.Gray;
            this.textBoxTransparent1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTransparent1.PromptText = "";
            this.textBoxTransparent1.RegexPattern = "";
            this.textBoxTransparent1.Size = new System.Drawing.Size(118, 33);
            this.textBoxTransparent1.TabIndex = 6;
            this.textBoxTransparent1.Text = "测井压力ΔP";
            // 
            // textBoxTransparent2
            // 
            this.textBoxTransparent2.BackAlpha = 10;
            this.textBoxTransparent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTransparent2.DecLength = 2;
            this.textBoxTransparent2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransparent2.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxTransparent2.Location = new System.Drawing.Point(556, 180);
            this.textBoxTransparent2.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxTransparent2.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxTransparent2.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxTransparent2.Name = "textBoxTransparent2";
            this.textBoxTransparent2.OldText = null;
            this.textBoxTransparent2.PromptColor = System.Drawing.Color.Gray;
            this.textBoxTransparent2.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTransparent2.PromptText = "";
            this.textBoxTransparent2.RegexPattern = "";
            this.textBoxTransparent2.Size = new System.Drawing.Size(118, 33);
            this.textBoxTransparent2.TabIndex = 7;
            this.textBoxTransparent2.Text = "测井时间Δt";
            // 
            // textBoxTransparent3
            // 
            this.textBoxTransparent3.BackAlpha = 10;
            this.textBoxTransparent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTransparent3.DecLength = 2;
            this.textBoxTransparent3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransparent3.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxTransparent3.Location = new System.Drawing.Point(556, 252);
            this.textBoxTransparent3.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxTransparent3.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxTransparent3.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxTransparent3.Name = "textBoxTransparent3";
            this.textBoxTransparent3.OldText = null;
            this.textBoxTransparent3.PromptColor = System.Drawing.Color.Gray;
            this.textBoxTransparent3.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTransparent3.PromptText = "";
            this.textBoxTransparent3.RegexPattern = "";
            this.textBoxTransparent3.Size = new System.Drawing.Size(118, 33);
            this.textBoxTransparent3.TabIndex = 8;
            this.textBoxTransparent3.Text = "样板压力Pd";
            // 
            // textBoxTransparent4
            // 
            this.textBoxTransparent4.BackAlpha = 10;
            this.textBoxTransparent4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTransparent4.DecLength = 2;
            this.textBoxTransparent4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTransparent4.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxTransparent4.Location = new System.Drawing.Point(556, 320);
            this.textBoxTransparent4.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxTransparent4.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxTransparent4.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxTransparent4.Name = "textBoxTransparent4";
            this.textBoxTransparent4.OldText = null;
            this.textBoxTransparent4.PromptColor = System.Drawing.Color.Gray;
            this.textBoxTransparent4.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTransparent4.PromptText = "";
            this.textBoxTransparent4.RegexPattern = "";
            this.textBoxTransparent4.Size = new System.Drawing.Size(118, 33);
            this.textBoxTransparent4.TabIndex = 9;
            this.textBoxTransparent4.Text = "样板时间td";
            // 
            // deltaP
            // 
            this.deltaP.DecLength = 4;
            this.deltaP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deltaP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deltaP.InputType = HZH_Controls.TextInputType.NotControl;
            this.deltaP.Location = new System.Drawing.Point(710, 107);
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
            this.deltaT.Location = new System.Drawing.Point(710, 180);
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
            this.PD.Location = new System.Drawing.Point(710, 252);
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
            this.Td.Location = new System.Drawing.Point(710, 320);
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
            this.Td.RegexPattern = "";
            this.Td.Size = new System.Drawing.Size(100, 33);
            this.Td.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(96, 64);
            this.openFile.TabIndex = 17;
            this.openFile.Text = "openFile";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openFile_MouseClick);
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
            this.ucCombox1.Location = new System.Drawing.Point(1099, 65);
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
            this.ucCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucCombox1.SelectedChangedEvent += new System.EventHandler(this.ucCombox1_SelectedChangedEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ucCombox1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.Td);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.deltaT);
            this.Controls.Add(this.deltaP);
            this.Controls.Add(this.textBoxTransparent4);
            this.Controls.Add(this.textBoxTransparent3);
            this.Controls.Add(this.textBoxTransparent2);
            this.Controls.Add(this.textBoxTransparent1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private HZH_Controls.Controls.TextBoxTransparent textBoxTransparent1;
        private HZH_Controls.Controls.TextBoxTransparent textBoxTransparent2;
        private HZH_Controls.Controls.TextBoxTransparent textBoxTransparent3;
        private HZH_Controls.Controls.TextBoxTransparent textBoxTransparent4;
        private HZH_Controls.Controls.TextBoxEx deltaP;
        private HZH_Controls.Controls.TextBoxEx deltaT;
        private HZH_Controls.Controls.TextBoxEx PD;
        private HZH_Controls.Controls.TextBoxEx Td;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private HZH_Controls.Controls.UCCombox ucCombox1;
    }
}

