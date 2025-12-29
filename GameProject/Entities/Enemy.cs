using GameProject.Core;
using GameProject.Entities;
using GameProject.Extensions;
using GameProject.Interfaces;
using System.Drawing;

namespace GameProject.Entities
{
    public class Enemy : GameObject, ICollidable
    {
        public int Health = 50;
        public IMovement? Movement { get; set; } // movement attach karne ke liye
        
        public override void Update(GameTime gameTime)
        {
            Movement?.Move(this, gameTime); // move karo agar set hai
            base.Update(gameTime);
        }

        
           // if (other is Bullet)
           // {
           // Health -= 25;

            //if (Health <= 0)
            // IsActive = false;
                   public override void OnCollision(GameObject other)
        {
            if (other is Bullet) // agar enemy ko bullet lagi
            {
                Health -= 10;          // damage kam karo
                other.IsActive = false; // bullet remove ho jaye

                if (Health <= 0)
                {
                    IsActive = false; // enemy mar gaya
                }
            }
        }

    }
}


