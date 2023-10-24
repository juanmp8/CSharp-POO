using CSharpCourse.Secao10.Abstracao.EX1.Enums;
using System.Globalization;

namespace CSharpCourse.Secao10.Abstracao.EX1 {
    internal class EXShapes {
        public static void Executar() {

            List<Shape> list = new List<Shape>();

            Console.Write("Entar the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if ( ch == 'r' ) {
                    Console.Write("Width: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));
                } else if (ch == 'c'){
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                } else {
                    Console.WriteLine("Invalid Object");
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list) { 
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
