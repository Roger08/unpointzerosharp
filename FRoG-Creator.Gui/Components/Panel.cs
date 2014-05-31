using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace FRoG_Creator.Gui.Components
{
    public class Panel : Component
    {
        protected Color color;
        protected List<Component> components;

        public Panel(Vector2f parentPosition)
            : base(parentPosition)
        {
            color = Color.White;
            components = new List<Component>();
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public List<Component> Components
        {
            get { return components; }
        }

        public override List<Drawable> Render()
        {
            List<Drawable> render = new List<Drawable>();
            RectangleShape rectangle = new RectangleShape();
            rectangle.Position = this.Position;
            rectangle.Size = size;
            rectangle.FillColor = color;
            render.Add(rectangle);

            foreach (Component component in components)
            {
                render.AddRange(component.Render());
            }

            return render;
        }

        public override void MouseButtonReleased(int x, int y, Mouse.Button button)
        {
            try
            {
                Component selectedComponent = (
                    from component in components
                    where component.Position.X <= x && component.Position.X + component.Size.X > x && component.Position.Y <= y && component.Position.Y + component.Size.Y > y
                    orderby component.Index descending
                    select component)
                    .ElementAt(0);

                selectedComponent.MouseButtonReleased(x - (int)selectedComponent.Position.X, y - (int)selectedComponent.Position.Y, button);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

    }
}
