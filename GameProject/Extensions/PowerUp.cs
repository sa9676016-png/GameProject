using System.Drawing;
using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Extensions
{
    internal class PowerUp : GameObject
    {
        public int HealAmount = 20;

        public override void Update(GameTime gameTime)
        {
            // No movement
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Green, Bounds);
        }

        public override void OnCollision(GameObject other)
        {
            // SIMPLE & SAFE (no Player.Health use)
            if (other.GetType().Name == "Player")
            {
                IsActive = false;
            }
        }
    }
}
