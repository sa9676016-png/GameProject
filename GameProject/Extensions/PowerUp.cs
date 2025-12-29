using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Extensions
{
    internal class PowerUp : GameObject
    {
        public override void Update(GameTime gameTime) { }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Green, Bounds);
        }
        public override void OnCollision(GameObject other)
        {
            if (other is Player player)
            {
                player.Health += 20;
                IsActive = false;
            }
        }
    }
}

