using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Plot
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MyapplicationContext()) ;
            Application.Run(new MainForm());
        }
    }

    class MyapplicationContext : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }
        public MyapplicationContext()
        {
            var forms = new List<Form>(){
            new MainForm()
          
        };
            foreach (var form in forms)
            {
                form.FormClosed += onFormClosed;
            }
            foreach (var form in forms)
            {
                form.Show();
            }
        }
    }
}
