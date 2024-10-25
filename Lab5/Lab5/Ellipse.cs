using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Ellipse : Circle
    { //Порожденный класс Эллипс 
        protected double secondRadius;
        public double SecondRadius
        {
            get { return secondRadius; }
            set { secondRadius = value; }
        }
        public Ellipse()
        {
            this.secondRadius = 0;
        }
        public Ellipse(double x, double y, double radius, double secondRadius) : base(x, y, radius)
        {
            this.secondRadius = secondRadius;
        }
        public override void Print()
        {
            Console.Write($"Эллипс:\n"); Console.Write($"Координаты центра: ({X}, {Y})\n");
            Console.Write($"Первая полуось: {Radius}\n"); Console.Write($"Вторая полуось: {SecondRadius}\n");
        }
        public override double Square()
        {
            double square = 3.14 * radius * secondRadius; return square;
        }
    }
}
