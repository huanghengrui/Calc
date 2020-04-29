using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Calc.Views;

namespace Calc
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MainWindow window = new MainWindow();
            Application app = new Application();
            app.Run(window);          
        }
    }
}
