using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_3
{   class Shape
    {
        private float length;
        private float width;

        public float Length
        {
            set
            { if (value > 0)
                {
                    length = value;
                }
            }
        }
        public float Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }
        public void check_rect_square(float Width, float Length)
        { if (Width == Length)
            {
                Console.WriteLine("This shape is a square");
            }
            else Console.WriteLine("This shape is a rectangle");
        }
        public void add_2_shapes(float x1, float y1, float x2, float y2)
        {
            float w3 = x1 + x2;
            float l3 = y1 + y2;
           
        }
       public Shape(float length, float width)
        {
            Length = length;
            Width = width;
        }
        public Shape()
        {
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1= new Shape(4,5);
            Shape shape2 = new Shape(10,10);
            Shape shape3 = new Shape();

            shape3.add_2_shapes(4,5,10,10);
            shape3.check_rect_square(14, 15);
        }
    }
}
