using GameProject.Core;
using GameProject.Entities;

namespace GameProject.Interfaces
{
    public interface ICollidable
    {
        void OnCollision(GameObject other);
    }
}
