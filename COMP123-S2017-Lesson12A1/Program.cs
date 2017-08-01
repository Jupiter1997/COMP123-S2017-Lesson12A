using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Marvin Jupiter Vargas
 * Date: August 1, 2017
 * Description: This is a Demo application to showcase user interface controls
 * Version 0.1: Project Creation
 */
namespace COMP123_S2017_Lesson12A1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] //annotation  -- leave it alone
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
