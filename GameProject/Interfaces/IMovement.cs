using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Interfaces
{
    public interface IMovement
    {
        void Move(GameObject obj, GameTime gameTime);
    }
}
