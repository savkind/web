using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProblem
{
    public class Rectangle
    {
        private float a;
        private float b;

        static List<Rectangle> rectangles = new List<Rectangle>();

        public Rectangle(float a, float b) {
            this.a = a;
            this.b = b;
            rectangles.Add(this);
        }

        public static float Area(Rectangle rec)
        {
            return rec.a * rec.b;
        }


        public static void AreaOfAllRectangles() {

            foreach(var rec in rectangles)
            {
                Console.WriteLine(Area(rec));
            }
        
        }
    }

    public class Square : Rectangle
    {
        public Square(float a) : base(a, a){ }

    }

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Rectangle.Area(new Rectangle(2, 10)));
            Console.WriteLine(Square.Area(new Square(4)));
            Console.WriteLine(Square.Area(new Square(2)));
            Console.WriteLine(Rectangle.Area(new Rectangle(1, 3)));
            Console.WriteLine("===============");
            Rectangle.AreaOfAllRectangles();
            Console.ReadKey();
        }


        
    }
}
