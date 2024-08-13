
namespace Formkontrollsystem
{
    abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public Shape()
        {
            
        }

        public abstract int Calculate();

    }
}
