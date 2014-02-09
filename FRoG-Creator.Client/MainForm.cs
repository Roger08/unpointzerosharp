using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;

namespace FRoG_Creator.Client
{
    internal static class MainForm
    {
        private static RenderWindow renderWindow;

        internal static void Create(VideoMode videoMode, string title)
        {
            renderWindow = new RenderWindow(videoMode, title);
        }

        internal static void Show()
        {
            //Code permettant de générer la vue

            renderWindow.Display();
        }

    }
}
