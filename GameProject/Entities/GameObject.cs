using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFrameWork;
using GameProject.Core;
using GameProject.Interfaces;

namespace GameProject.Entities
{
    public class GameObject : IPhysicsObject
    {
        public PointF Position { get; set; }


        public SizeF Size { get; set; }


        public PointF Velocity { get; set; } = PointF.Empty;

        public bool IsActive { get; set; } = true;

        public bool HasPhysics { get; set; } = false;

        public float? CustomGravity { get; set; } = null;


        public bool IsRigidBody { get; set; } = false;

        public Image? Sprite { get; set; } = null;


        public RectangleF Bounds => new RectangleF(Position, Size);



        public virtual void Update(GameTime gameTime)
        {
            Position = new PointF(Position.X + Velocity.X, Position.Y + Velocity.Y);
        }


        public virtual void Draw(Graphics graphics)
        {
            if (Sprite != null)
            {
                graphics.DrawImage(Sprite, Bounds);
            }
            else
            {
                using (Brush brush = new SolidBrush(Color.Gray)) // Default color
                {
                    graphics.FillRectangle(brush, Bounds);
                }
            }
        }
        public virtual void OnCollision(GameObject other)
        {
        }
    }
}

