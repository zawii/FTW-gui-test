using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTW_GUI_test
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
            Application.Run(new Form1());



           

        }






    }

    [Serializable]
    public class TM
    {
        public static string LastUsedTM;

        public string TMName { get; set; }
        public string Server { get; set; } // TODO zmienic na enum?

        public override string ToString()
        {
            return TMName + ":" + Server;
        }

    }

    public static class Worker
    {

        public static async void DoWork(IProgress<int> progress)
        {
            // This method is executed in the context of
            // another thread (different than the main UI thread),
            // so use only thread-safe code


            for (int j = 0; j < 100; j++)
            {


                // Use progress to notify UI thread that progress has
                // changed
                if (progress != null)
                {
                    await Task.Delay(10);
                    progress.Report((j + 1) * 100 / 100);

                }


            }


        }
    }



}
