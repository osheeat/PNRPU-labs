using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Window
    {
        public Point First;
        public Point Second;
        public bool isOpened;

        public Window(Point first, Point Second) 
        {
            this.First = first;
            this.Second = Second;
            this.isOpened = false;
        }

        public void Redraw(Point newWind)
        {
            isOpened = !isOpened;
            this.Second.X = newWind.X;
            this.Second.Y = newWind.Y;
        }
    }
}
