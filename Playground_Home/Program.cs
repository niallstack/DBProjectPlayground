using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_Home
{    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Playground_frm());

            Application.Run(new viewProfileFrm());

            StudentDAOImpl instance = new StudentDAOImpl();
            //instance.read(1);
           // instance.delete(123);
           // MessageBox.Show(instance.read(1).toString());
        }
    }
}
