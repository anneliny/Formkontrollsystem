using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Circle : Shape
    {

        public int Radius { get; set; }

        public Circle(string name, string color, int radius) : base (name, color)
        {
            Radius = radius;
        }

        public override int Calculate()
        {
            return Convert.ToInt32(Math.PI * Radius * Radius);
        }
    }
}
