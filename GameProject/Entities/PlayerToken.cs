using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class PlayerToken : GameObject
    {
        public int BoardPosition { get; set; } = 0; // Tracks which square the player is on

        public void MoveToBoardPosition(int newPos)
        {
            BoardPosition = newPos;
            // Convert board index to Position in pixels
            Position = new PointF((BoardPosition % 10) * 50, (BoardPosition / 10) * 50);
        }
    }

}
