using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Main
    {
        public List <Shape> Shapes {  get; set; }
        public Rectangle rectangle { get; set; }

        public int Total {  get; set; }

        public Main()
        {
            Shapes = new List<Shape>()
            {
                new Circle ("Sirkel 1", "Blå", 20),
                new Circle ("Sirkel 2", "Grønn", 40),
                new Rectangle ("Rektangel 1", "Rosa", 20, 10),
                new Rectangle ("Rektangel 2", "Gul", 5, 34),
                new Triangle ("Trekant 1", "Lilla", 24, 56),
                new Triangle ("Trekant 2", "Brun", 41, 59)
            };


            ShowShapes();
            SortByNumber();
            SortByColor();
        }

        public void ShowShapes()
        {
            foreach (Shape shape in Shapes) 
            {
                Console.WriteLine($"Navn: {shape.Name}");
                Console.WriteLine($"Farge: {shape.Color}");
                Console.WriteLine($"Areal: {shape.Calculate()}\n");
            }

            CalculateTotal ();
            Console.WriteLine($"Total areal: {Total}\n");
        }

        public int CalculateTotal()
        {
            
            foreach (Shape shape in Shapes)
            {
                Total += shape.Calculate();
            }

            return Total;
        }

        public void SortByNumber()
        {
            var sorting = Shapes.OrderBy(num => num.Calculate());

            foreach (Shape shape in sorting)
            {
                Console.WriteLine($"Navn: {shape.Name}");
                Console.WriteLine($"Farge: {shape.Color}");
                Console.WriteLine($"Areal: {shape.Calculate()}\n");
            }
        }

        public void SortByColor()
        {
            Console.WriteLine("Skriv navnet på en farge og se om noen av formene har denne fargen.");

            var input = Console.ReadLine();

            var colorSort = Shapes.Where(sort => sort.Color.ToLower() == input);

            foreach (Shape shape in colorSort)
            {
                Console.WriteLine($"Navn: {shape.Name}");
                Console.WriteLine($"Farge: {shape.Color}");
            }
        }
    }
}
