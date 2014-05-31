using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using FRoG_Creator.Gui;
using FRoG_Creator.Gui.Components;
using FRoG_Creator.GameContent;

namespace FRoG_Creator.Editor
{
    class EditorForm
    {
        private RenderWindow renderWindow;
        private List<Component> components;

        internal EditorForm()
        {
            renderWindow = new RenderWindow(new VideoMode(1600, 900), "Beyond Hell");
            components = new List<Component>();

            renderWindow.Closed += new EventHandler(Closed);
            renderWindow.MouseButtonReleased += new EventHandler<MouseButtonEventArgs>(MouseButtonReleased);

            Panel menu = new Panel(new Vector2f(0, 0));
            menu.RelativePosition = new Vector2f(0, 0);
            menu.Size = new Vector2f(400, 900);
            menu.Color = Color.White;

            Panel game = new Panel(new Vector2f(0, 0));
            game.RelativePosition = new Vector2f(400, 0);
            game.Size = new Vector2f(1200, 900);
            game.Color = Color.Cyan;

            components.Add(menu);
            components.Add(game);

            Square.InitTiles();

            Map map = new Map();
            ParseMap(game, map);
            CreateMenu(menu);

            Show();
        }

        private void CreateMenu(Panel menu)
        {
            // Plus tard, les composants seront importés depuis un fichier xml

            Square field = new Square(menu.Position);
            field.RelativePosition = new Vector2f(0, 0);
            field.AddLayer("field_full_0");

            Square forest = new Square(menu.Position);
            forest.RelativePosition = new Vector2f(100, 0);
            forest.AddLayer("field_full_0");
            forest.AddLayer("forest_full_0");

            menu.Components.Add(field);
            menu.Components.Add(forest);
        }

        private void ParseMap(Panel game, Map map)
        {
            for (byte j = 0; j < Map.tilesGridHeight; j++)
            {
                for (byte i = 0; i < Map.tilesGridWidth; i++)
                {
                    Square square = new Square(game.Position);
                    square.RelativePosition = new Vector2f(i * 100, j * 100);
                    foreach (String layer in map.TilesGrid[i, j].Layers)
                    {
                        square.Sprites.Add(new Sprite(new Texture(Square.availableImages[layer])));
                    }

                    game.Components.Add(square);
                }
            }
        }

        private void Show()
        {
            while (renderWindow.IsOpen())
            {
                renderWindow.DispatchEvents();
                components = components.OrderBy(component => component.Index).ToList();
                renderWindow.Clear();

                foreach (Component component in components)
                {
                    foreach (Drawable drawable in component.Render())
                    {
                        renderWindow.Draw(drawable);
                    }
                }

                renderWindow.Display();
            }
        }

        private void Closed(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        private void MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Component selectedComponent = (
                    from component in components
                    where component.Position.X <= e.X && component.Position.X + component.Size.X > e.X && component.Position.Y <= e.Y && component.Position.Y + component.Size.Y > e.Y
                    orderby component.Index descending
                    select component)
                    .ElementAt(0);

                selectedComponent.MouseButtonReleased(e.X - (int)selectedComponent.Position.X, e.Y - (int)selectedComponent.Position.Y, e.Button);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

    }
}
