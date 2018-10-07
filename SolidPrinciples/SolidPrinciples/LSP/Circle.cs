namespace SolidPrinciples.LSP
{
    public class Circle : I2DShape
    {
        public Circle(int diameter)
        {
            Width = diameter;
            Height = diameter;
        }

        public int Width { get; }
        public int Height { get; }
    }
}