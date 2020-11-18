using System;
using System.Windows.Forms;

namespace Plot
{
    partial class defaultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.ct = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.TextBox();
            this.rw = new System.Windows.Forms.TextBox();
            this.u = new System.Windows.Forms.TextBox();
            this.phi = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入压力反演初始数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(99, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "流量q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(99, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "地层体积系数B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(99, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "液体总压缩率Ct";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(99, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "地层厚度h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(99, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "井口半径rw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(99, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "原油粘度u";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(99, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "孔隙度Phi";
            // 
            // q
            // 
            this.q.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.q.Location = new System.Drawing.Point(283, 144);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(133, 35);
            this.q.TabIndex = 8;
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b.Location = new System.Drawing.Point(283, 204);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(133, 35);
            this.b.TabIndex = 9;
            // 
            // ct
            // 
            this.ct.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ct.Location = new System.Drawing.Point(283, 259);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(133, 35);
            this.ct.TabIndex = 10;
            // 
            // h
            // 
            this.h.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.h.Location = new System.Drawing.Point(283, 314);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(133, 35);
            this.h.TabIndex = 11;
            // 
            // rw
            // 
            this.rw.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rw.Location = new System.Drawing.Point(283, 374);
            this.rw.Name = "rw";
            this.rw.Size = new System.Drawing.Size(133, 35);
            this.rw.TabIndex = 12;
            // 
            // u
            // 
            this.u.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.u.Location = new System.Drawing.Point(283, 425);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(133, 35);
            this.u.TabIndex = 13;
            // 
            // phi
            // 
            this.phi.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phi.Location = new System.Drawing.Point(283, 488);
            this.phi.Name = "phi";
            this.phi.Size = new System.Drawing.Size(133, 35);
            this.phi.TabIndex = 14;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSubmit.BtnBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSubmit.BtnFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSubmit.BtnForeColor = System.Drawing.Color.White;
            this.BtnSubmit.BtnText = "提交";
            this.BtnSubmit.ConerRadius = 5;
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.EnabledMouseEffect = true;
            this.BtnSubmit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSubmit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnSubmit.IsRadius = true;
            this.BtnSubmit.IsShowRect = true;
            this.BtnSubmit.IsShowTips = false;
            this.BtnSubmit.Location = new System.Drawing.Point(151, 550);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.RectColor = System.Drawing.Color.Transparent;
            this.BtnSubmit.RectWidth = 1;
            this.BtnSubmit.Size = new System.Drawing.Size(184, 60);
            this.BtnSubmit.TabIndex = 15;
            this.BtnSubmit.TabStop = false;
            this.BtnSubmit.TipsColor = System.Drawing.Color.White;
            this.BtnSubmit.TipsText = "";
            this.BtnSubmit.BtnClick += new System.EventHandler(this.BtnSubmit_MouseClick);
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 671);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.phi);
            this.Controls.Add(this.u);
            this.Controls.Add(this.rw);
            this.Controls.Add(this.h);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.b);
            this.Controls.Add(this.q);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "defaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "压力反演解释软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox ct;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox rw;
        private System.Windows.Forms.TextBox u;
        private System.Windows.Forms.TextBox phi;
        private HZH_Controls.Controls.UCBtnExt BtnSubmit;
    }
}