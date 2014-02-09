using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRoG_Creator.GameContent
{
    public class Animation
    {
        public enum Type
        {
            WALK,
        }

        public static List<Animation> Animations;

        const byte FPS = 60;

        ComponentObject componentObject;
        Direction direction;
        float speed;
        int frameIndex;
        int frameNumber;
        Type animationType;

        //Standard animation
        public Animation(ComponentObject ComponentObject, Direction Direction, float Speed)
        {
            componentObject = ComponentObject;
            direction = Direction;
            speed = Speed;
            frameIndex = 0;
            frameNumber = (int)(FPS / speed);
        }

        //Character animation
        public Animation(ComponentObject ComponentObject, Direction Direction, float Speed, Type AnimationType)
        {
            componentObject = ComponentObject;
            direction = Direction;
            speed = Speed;
            frameIndex = 0;
            frameNumber = (int)(FPS / speed);
            animationType = AnimationType;
        }

        public void Next()
        {
            float distance = 1 / frameNumber;

            switch (direction)
            {
                case Direction.BAS:
                    componentObject.Y += distance;
                    break;
                case Direction.DROITE:
                    componentObject.X += distance;
                    break;
                case Direction.GAUCHE:
                    componentObject.X -= distance;
                    break;
                case Direction.HAUT:
                    componentObject.Y -= distance;
                    break;
                default:
                    break;
            }

            if (animationType != null)
            {
                
            }

            frameIndex++;

            if (frameIndex == frameNumber)
            {
                componentObject.X = (float)Math.Round(componentObject.X);
                componentObject.Y = (float)Math.Round(componentObject.Y);
            }
        }

    }
}
