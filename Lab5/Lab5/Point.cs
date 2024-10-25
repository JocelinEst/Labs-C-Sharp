using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Point //Базовый класс Точка
    {
        protected double x { get; set; }
        protected double y { get; set; }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point()
        {  //Базовый конструктор       
            this.X = 0; this.Y = 0;
        }
        public Point(double x, double y)
        { //Конструктор
            this.X = x;
            this.Y = y;
        }
        public virtual void Print()
        { // Метод вывода на экран
            Console.Write($"Координаты точки: ({X}, {Y})\n");
        }
    }
}
