using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GameProject.Entities;

namespace GameFrameWork
{
    public class CollisionSystem
    {
        public void Check(List<GameObject> objects)
        {
            for (int i = 0; i < objects.Count; i++)
            {
                for (int j = i + 1; j < objects.Count; j++)
                {
                    if (objects[i].Bounds.IntersectsWith(objects[j].Bounds))
                    {
                        // Call OnCollision on both objects
                        objects[i].OnCollision(objects[j]);
                        objects[j].OnCollision(objects[i]);
                    }
                }
            }
        }
    }
}
