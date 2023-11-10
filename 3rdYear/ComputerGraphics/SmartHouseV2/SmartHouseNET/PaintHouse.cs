using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHouseNET
{
    public class PaintHouse
    {
        //ОКНА ВО ВСЕМ ДОМЕ
        public Window Win1_1 = new Window(new Point(400, 325), new Point(400, 375));
        public Window Win2_1 = new Window(new Point(150, 450), new Point(200, 450));
        public Window Win3_1 = new Window(new Point(100, 325), new Point(100, 375));
        public Window Win4_1 = new Window(new Point(250, 125), new Point(250, 175));
        public Window Win5_1 = new Window(new Point(300, 50), new Point(350, 50));


        //ДВЕРИ ВО ВСЕМ ДОМЕ
        public Door Door1 = new Door(new Point(300, 450), new Point(350, 450));
        public Door Door2 = new Door(new Point(250, 325), new Point(250, 375));
        public Door Door3 = new Door(new Point(300, 250), new Point(350, 250));

        //ОСНОВНАЯ ОТРИСОВКА ДОМА
        public void DrawHouse(Form form)
        {
            System.Drawing.Graphics formGraphics;
            Pen WallsPen = new Pen(Color.Black, 5);
            formGraphics = form.CreateGraphics();
            formGraphics.DrawRectangle(WallsPen, new Rectangle(250, 50, 150, 200));
            formGraphics.DrawRectangle(WallsPen, new Rectangle(250, 250, 150, 200));
            formGraphics.DrawRectangle(WallsPen, new Rectangle(100, 250, 150, 200));
            WallsPen.Dispose();
            formGraphics.Dispose();
        }
        public void DrawDoors(Form form)
        {
            Pen DoorsPen = new Pen(Color.Brown, 8);
            System.Drawing.Graphics formGraphics;
            formGraphics = form.CreateGraphics();
            formGraphics.DrawLine(DoorsPen, Door1.First, Door1.Second);
            formGraphics.DrawLine(DoorsPen, Door2.First, Door2.Second);
            formGraphics.DrawLine(DoorsPen, Door3.First, Door3.Second);
            DoorsPen.Dispose();
            formGraphics.Dispose();
        }
        public void DrawWindows(Form form)
        {
            Pen WindowPen = new Pen(Color.Blue, 8);
            System.Drawing.Graphics formGraphics;
            formGraphics = form.CreateGraphics();
            formGraphics.DrawLine(WindowPen, Win1_1.First, Win1_1.Second);
            formGraphics.DrawLine(WindowPen, Win2_1.First, Win2_1.Second);
            formGraphics.DrawLine(WindowPen, Win3_1.First, Win3_1.Second);
            formGraphics.DrawLine(WindowPen, Win4_1.First, Win4_1.Second);
            formGraphics.DrawLine(WindowPen, Win5_1.First, Win5_1.Second);
            WindowPen.Dispose();
            formGraphics.Dispose();
        }

        //ПЕРЕРИСОВКА ОТКРЫТИЯ/ЗАКРЫТИЯ ДВЕРЕЙ
        public void RedrawDoors(Form form, Door door)
        {
            Pen DoorsPen = new Pen(Color.Brown, 8);
            System.Drawing.Graphics formGraphics;
            //Проверка номера двери и проверка открыта она или закрыта
            Point pointToRedraw = RedrawDoorPoint(door);
            door.Redraw(pointToRedraw);
            formGraphics = form.CreateGraphics();
            formGraphics.Clear(Color.White);
            this.DrawHouse(form);
            this.DrawDoors(form);
            this.DrawWindows(form);
            DoorsPen.Dispose();
            formGraphics.Dispose();
        }
        public void RedrawWindow(Form form, Window window)
        {
            Pen WindowPen = new Pen(Color.Blue, 8);
            System.Drawing.Graphics formGraphics;
            //Проверка номера окна и проверка открыто оно или закрыто
            Point pointToRedraw = RedrawWindowPoint(window);
            window.Redraw(pointToRedraw);
            formGraphics = form.CreateGraphics();
            formGraphics.Clear(Color.White);
            this.DrawHouse(form);
            this.DrawDoors(form);
            this.DrawWindows(form);
            WindowPen.Dispose();
            formGraphics.Dispose();
        }

        //ПОЛУЧЕНИЕ ТОЧЕК ДЛЯ ПЕРЕРИСОВКИ ДВЕРЕЙ
        public Point RedrawWindowPoint(Window window)
        {
            Point pointToRedraw;
            //Новые координаты для ОКНА 1
            if (window.First.X == Win1_1.First.X && window.First.Y == Win1_1.First.Y)
            {
                if (window.isOpened)
                    pointToRedraw = new Point(400, 375);
                else
                    pointToRedraw = new Point(420, 375);
                return pointToRedraw;
            }
            //Новые координаты для ОКНА 2
            if (window.First.X == Win2_1.First.X && window.First.Y == Win2_1.First.Y)
            {
                if (window.isOpened)
                    pointToRedraw = new Point(200, 450);
                else
                    pointToRedraw = new Point(200, 470);
                return pointToRedraw;
            }
            //Новые координаты для ОКНА 3
            if (window.First.X == Win3_1.First.X && window.First.Y == Win3_1.First.Y)
            {
                if (window.isOpened)
                    pointToRedraw = new Point(100, 375);
                else
                    pointToRedraw = new Point(80, 375);
                return pointToRedraw;
            }
            //Новые координаты для ОКНА 4 
            if (window.First.X == Win4_1.First.X && window.First.Y == Win4_1.First.Y)
            {
                if (window.isOpened)
                    pointToRedraw = new Point(250, 175);
                else
                    pointToRedraw = new Point(230, 175);
                return pointToRedraw;
            }
            //Новые координаты для ОКНА 5
            if (window.First.X == Win5_1.First.X && window.First.Y == Win5_1.First.Y)
            {
                if (window.isOpened)
                    pointToRedraw = new Point(350, 50);
                else
                    pointToRedraw = new Point(350, 30);
                return pointToRedraw;
            }
            return new Point(0, 0);

        }
        public Point RedrawDoorPoint(Door door)
        {
            Point pointToRedraw;
            //Новые координаты для ДВЕРИ 1
            if (door.First.X == Door1.First.X && door.First.Y == Door1.First.Y)
            {
                if (door.isOpened)
                    pointToRedraw = new Point(350, 450);
                else
                    pointToRedraw = new Point(350, 470);
                return pointToRedraw;
            }
            //Новые координаты для ДВЕРИ 2
            if (door.First.X == Door2.First.X && door.First.Y == Door2.First.Y)
            {
                if (door.isOpened)
                    pointToRedraw = new Point(250, 375);
                else
                    pointToRedraw = new Point(230, 375);
                return pointToRedraw;
            }
            //Новые координаты для ДВЕРИ 3
            if (door.First.X == Door3.First.X && door.First.Y == Door3.First.Y)
            {
                if (door.isOpened)
                    pointToRedraw = new Point(350, 250);
                else
                    pointToRedraw = new Point(350, 230);
                return pointToRedraw;
            }
            return new Point(0, 0);
        }
    }
}
