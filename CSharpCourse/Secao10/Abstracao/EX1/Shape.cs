using CSharpCourse.Secao10.Abstracao.EX1.Enums;

namespace CSharpCourse.Secao10.Abstracao.EX1 {
    internal abstract class Shape {
        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
