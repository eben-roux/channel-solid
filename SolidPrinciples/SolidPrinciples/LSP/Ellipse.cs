namespace SolidPrinciples.LSP
{
    public class Ellipse : I2DShape
    {
        public Ellipse(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }
    }
}