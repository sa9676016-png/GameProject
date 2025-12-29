using GameProject.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GameProject.Core
{
    public class Game
    {
        public List<GameObject> Objects { get; private set; } = new List<GameObject>();

        public void AddObject(GameObject obj)
        {
            Objects.Add(obj);
        }

        public void Update(GameTime gameTime)
        {
            foreach (var obj in Objects.Where(o => o.IsActive).ToList())
                obj.Update(gameTime);
        }

        public void Draw(Graphics g)
        {
            foreach (var obj in Objects.Where(o => o.IsActive))
                obj.Draw(g);
        }

        public void Cleanup()
        {
            Objects.RemoveAll(o => !o.IsActive);
        }
    }
}
