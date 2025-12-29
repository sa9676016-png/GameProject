using System;
using System.Drawing;
using GameFrameWork;
using GameProject.Core;
using GameProject.Entities;
using GameProject.Interfaces;

namespace GameFrameWork
{
    public class PatrolMovement : IMovement
    {
        private float leftBound;
        private float rightBound;
        private float speed;

        public PatrolMovement(float left, float right, float speed = 2f)
        {
            leftBound = left;
            rightBound = right;
            this.speed = speed; // speed ko adjustable rakha
        }

        public void Move(GameObject obj, GameTime gameTime)
        {
            // Horizontal movement
            obj.Position = new PointF(obj.Position.X + speed, obj.Position.Y);

            // Boundary check
            if (obj.Position.X < leftBound)
            {
                obj.Position = new PointF(leftBound, obj.Position.Y);
                speed = Math.Abs(speed); // right direction
            }
            else if (obj.Position.X + obj.Size.Width > rightBound)
            {
                obj.Position = new PointF(rightBound - obj.Size.Width, obj.Position.Y);
                speed = -Math.Abs(speed); // left direction
            }
        }
    }
}
