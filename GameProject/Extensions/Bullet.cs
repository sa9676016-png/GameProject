using System.Drawing;
using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Entities
{
    public class Bullet : GameObject
    {
        public Bullet(PointF start)
        {
            Position = start;
            Size = new Size(20, 10);
            Velocity = new PointF(10, 0);
        }

        public override void Update(GameTime gameTime)
        {
            Position = new PointF(Position.X + Velocity.X, Position.Y + Velocity.Y);

            if (Position.X > 1920) // Screen width adjust karlo
                IsActive = false;

            base.Update(gameTime);
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Yellow, Bounds);
        }

        public override void OnCollision(GameObject other)
        {
            if (other is Enemy)
                other.IsActive = false; // Enemy die ho jaaye
            IsActive = false; // Bullet remove
        }
    }
}
