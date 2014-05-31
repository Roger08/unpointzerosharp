using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace FRoG_Creator.Gui.Components
{
    public class Square : Component
    {
        public static Dictionary<string, Image> availableImages = new Dictionary<string, Image>();
        protected List<Sprite> sprites;

        public Square(Vector2f parentPosition)
            : base(parentPosition)
        {
            sprites = new List<Sprite>();
        }

        public static void InitTiles()
        {
            availableImages.Add("field_full_0", new Image("Resources/Images/field_full_0.png"));
            availableImages.Add("forest_full_0", new Image("Resources/Images/forest_full_0.png"));
        }

        public List<Sprite> Sprites
        {
            get { return sprites; }
        }

        public void AddLayer(string name)
        {
            sprites.Add(new Sprite(new Texture(new Image(availableImages[name]))));
        }

        public override List<Drawable> Render()
        {
            List<Drawable> render = new List<Drawable>();

            foreach (Sprite sprite in sprites)
            {
                sprite.Position = this.Position;
            }

            render.AddRange(sprites);

            return render;
        }

        public override void MouseButtonReleased(int x, int y, Mouse.Button button)
        {

        }

    }
}
