using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseNET
{
    public class Door
    {
        public Point First;
        public Point Second;
        public bool isOpened;

        public Door(Point first, Point Second)
        {
            this.First = first;
            this.Second = Second;
            this.isOpened = false;
        }

        public void Redraw(Point newDoor)
        {
            isOpened = !isOpened;
            this.Second.X = newDoor.X;
            this.Second.Y = newDoor.Y;
        }
    }
}
