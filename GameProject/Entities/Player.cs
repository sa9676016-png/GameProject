using EZInput;
using GameProject.Core;
using GameProject.Entities;
using GameProject.Extensions;
using GameProject.Interfaces;
using System.Drawing;

namespace GameProject.Entities
{
    public class Player : GameObject
    {
        private Game game;
        public IMovement? Movement { get; set; }
        public int Health { get; set; } = 100;

        public Player(Game game)
        {
            this.game = game;
        }

        public override void Update(GameTime gameTime)
        {
            Movement?.Move(this, gameTime);

            // Space bar se bullet fire
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Bullet bullet = new Bullet(this.Position); // Position pass kare
                game.AddObject(bullet);
            }

            base.Update(gameTime);
        }

        public override void OnCollision(GameObject other)
        {
            if (other is Enemy)
                Health -= 10;
        }
    }
}
