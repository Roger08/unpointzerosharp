using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;
using SFML.Graphics;

namespace FRoG_Creator.GUI
{
    public class GameWindow
    {
        const string TITLE = "Frog Creator 1.0";

        RenderWindow renderWindow;

        public GameWindow()
        {
            renderWindow = new RenderWindow(new VideoMode(), TITLE);

            InitWindow(renderWindow);
        }

        private void InitWindow(RenderWindow renderWindow)
        {
            while (renderWindow.IsOpen())
            {
                renderWindow.Clear();
                renderWindow.Display();
            }
        }

        public RenderWindow RenderWindow
        {
            get { return renderWindow; }
            set { renderWindow = value; }
        }
    }

}
