using System.Drawing;
using GameProject.Core;
using GameProject.Interfaces;

namespace GameProject.Entities
{
    public class Enemy : GameObject
    {
        private float speed = 2f;
        private float left, right;

        public Enemy(PointF pos, Size size, float leftBound, float rightBound)
        {
            Position = pos;
            Size = size;
            left = leftBound;
            right = rightBound;
        }

        public override void Update(GameTime gameTime)
        {
            Position = new PointF(Position.X + speed, Position.Y);

            if (Position.X < left || Position.X + Size.Width > right)
                speed = -speed;

            base.Update(gameTime);
        }
    }
}
