using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Milestone1
{
    /// <summary>
    /// 27 March 2021
    /// Danny Beaudoin
    /// Wheel Of Fortune Game - Player must guess the correct 
    ///                         word to earn points
    /// Assignment 2 Milestone 1
    /// </summary>
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
}
