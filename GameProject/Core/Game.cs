using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;
using System.Drawing;

namespace GameProject.Core
{
    public class Game
    {
        private List<GameObject> objects = new List<GameObject>();
        private List<GameObject> objectsToAdd = new List<GameObject>();

        public List<GameObject> Objects => objects;

        // Add object safely
        public void AddObject(GameObject obj)
        {
            objectsToAdd.Add(obj); // Add to temporary list
        }

        public void Update(GameTime gameTime)
        {
            // Update all active objects
            foreach (var obj in objects.Where(o => o.IsActive).ToList()) // use ToList() to avoid modification error
            {
                obj.Update(gameTime);
            }

            // Merge new objects safely after update
            if (objectsToAdd.Count > 0)
            {
                objects.AddRange(objectsToAdd);
                objectsToAdd.Clear();
            }

            // Cleanup inactive objects
            Cleanup();
        }

        public void Draw(Graphics g)
        {
            foreach (var obj in objects.Where(o => o.IsActive))
            {
                obj.Draw(g);
            }
        }

        public void Cleanup()
        {
            objects.RemoveAll(o => !o.IsActive);
        }
    }
}
