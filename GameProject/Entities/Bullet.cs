using System.Drawing;
using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Extensions
{
    public class Bullet : GameObject
    {
        public Bullet()
        {
            Velocity = new PointF(10, 0); // Move right
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Position.X > 2000) // remove if offscreen
                IsActive = false;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Yellow, Bounds);
        }

        public override void OnCollision(GameObject other)
        {
            if (other is Enemy)
            {
                IsActive = false; // bullet disappears
            }
        }
    }
}
