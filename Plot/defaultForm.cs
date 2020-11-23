using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plot
{
    public partial class defaultForm : Form
    {
        public defaultForm()
        {
            InitializeComponent();
            q.Text = "174";
            b.Text = "1.06";
            ct.Text = "0.0000042";
            h.Text = "107";
            rw.Text = "0.29";
            u.Text = "2.5";
            phi.Text = "0.25";
            
        }

       private void BtnSubmit_MouseClick(object sender, EventArgs e)
       {
            PlotPointData.q = Convert.ToDouble(q.Text);
            PlotPointData.b = Convert.ToDouble(b.Text);
            PlotPointData.ct = Convert.ToDouble(ct.Text);
            PlotPointData.h = Convert.ToDouble(h.Text);
            PlotPointData.rw = Convert.ToDouble(rw.Text);
            PlotPointData.u = Convert.ToDouble(u.Text);
            PlotPointData.phi = Convert.ToDouble(phi.Text);
            this.Hide();
            Form mfrm = new MainForm(this);
            mfrm.Show();
            mfrm.FormClosed += MFRM_FormClosed;
            mfrm.Show();
        }

        private void MFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
