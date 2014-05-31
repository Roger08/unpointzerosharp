using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace FRoG_Creator.Gui
{
    public abstract class Component
    {
        protected static int counter = 0;

        protected int index;
        protected Vector2f size;
        protected Vector2f relativePosition;

        protected Vector2f pPosition;

        public Component(Vector2f parentPosition)
        {
            index = counter;
            counter++;
            size = new Vector2f(100, 100);
            relativePosition = new Vector2f(0, 0);
            pPosition = parentPosition;
        }

        public int Index
        {
            get { return index; }
        }

        public Vector2f Position
        {
            get { return pPosition + relativePosition; }
        }

        public Vector2f Size
        {
            get { return size; }
            set { size = value; }
        }

        public Vector2f RelativePosition
        {
            get { return relativePosition; }
            set { relativePosition = value; }
        }

        public void Focus()
        {
            index = counter++;
        }

        public abstract List<Drawable> Render();

        public abstract void MouseButtonReleased(int x, int y, Mouse.Button button);
    }
}
