using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
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

            updateApp();
        }

        async static Task updateApp() {
            using (var mgr = new UpdateManager(@"d:\Downloads\Dev\Haxe\MyApp.Squirrel_git\Releases\"))
            {
                await mgr.UpdateApp();
            }
        }

    }
}
