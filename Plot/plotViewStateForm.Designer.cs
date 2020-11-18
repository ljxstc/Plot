namespace Plot
{
    partial class plotViewStateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucProcessLine1 = new HZH_Controls.Controls.UCProcessLine();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(800, 600);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plotView1_MouseDown);
          
            // 
            // ucProcessLine1
            // 
            this.ucProcessLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProcessLine1.ForeColor = System.Drawing.Color.White;
            this.ucProcessLine1.Location = new System.Drawing.Point(163, 222);
            this.ucProcessLine1.MaxValue = 100;
            this.ucProcessLine1.Name = "ucProcessLine1";
            this.ucProcessLine1.Size = new System.Drawing.Size(437, 79);
            this.ucProcessLine1.TabIndex = 1;
            this.ucProcessLine1.Text = "ucProcessLine1";
            this.ucProcessLine1.Value = 0;
            this.ucProcessLine1.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessLine1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessLine1.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            
            // 
            // plotViewStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.ucProcessLine1);
            this.Controls.Add(this.plotView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(941, 183);
            this.Name = "plotViewStateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "plotViewStateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HZH_Controls.Controls.UCProcessLine ucProcessLine1;
    }
}