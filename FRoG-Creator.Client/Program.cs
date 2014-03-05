using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FRoG_Creator.GUI;

namespace FRoG_Creator.Client
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameWindow gameWindow = new GameWindow();
        }
    }
}
