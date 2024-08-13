using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Triangle : Shape
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public Triangle(string name, string color, int width, int height) : base(name, color)
        {
            Width = width;
            Height = height;
        }

        public override int Calculate()
        {
            return (Width * Height) / 2;
        }
    }
}
