using System.Drawing;
using EZInput;
using GameProject.Core;
using GameProject.Entities;
using GameProject.Interfaces;

namespace GameFrameWork
{
    public class KeyboardMovement : IMovement
    {
        public float Speed { get; set; } = 5f;

        public void Move(GameObject obj, GameTime gameTime)
        {
            if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
                obj.Position = new PointF(obj.Position.X - Speed, obj.Position.Y);

            if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
                obj.Position = new PointF(obj.Position.X + Speed, obj.Position.Y);

            if (EZInput.Keyboard.IsKeyPressed(Key.UpArrow))
                obj.Position = new PointF(obj.Position.X, obj.Position.Y - Speed);

            if (EZInput.Keyboard.IsKeyPressed(Key.DownArrow))
                obj.Position = new PointF(obj.Position.X, obj.Position.Y + Speed);
        }
    }
}
