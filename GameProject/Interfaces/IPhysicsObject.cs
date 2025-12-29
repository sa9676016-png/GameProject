using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Interfaces
{
    public interface IPhysicsObject
    {
        bool HasPhysics { get; set; }
        float? CustomGravity { get; set; }
        bool IsRigidBody { get; set; }

    }
}

