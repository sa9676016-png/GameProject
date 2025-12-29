using System.Drawing;
using EZInput;
using GameProject.Core;
using GameProject.Extensions;
using GameProject.Interfaces;

namespace GameProject.Entities
{
    public class Player : GameObject
    {
        private Game game;
        public IMovement? Movement { get; set; }
        public int Health { get; set; } = 100;
        public int Score { get; set; } = 0;

        public Player(Game game)
        {
            this.game = game;
        }

        public override void Update(GameTime gameTime)
        {
            // Player movement
            Movement?.Move(this, gameTime);

            // Shooting bullets
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Bullet bullet = new Bullet
                {
                    Position = new PointF(Position.X + Size.Width, Position.Y + Size.Height / 2),
                    Size = new Size(40, 10)
                };
                game.AddObject(bullet);
            }

            base.Update(gameTime);
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
        }

        public bool IsAlive = true;

        public override void OnCollision(GameObject other)
        {
            if (other is Enemy)
            {
                Health -= 10;

                if (Health <= 0)
                {
                    IsAlive = false;
                }
            }
        }

    }
}
