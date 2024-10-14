namespace Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            WriteLine($"Drawing a circle of a radius {radius}");
        }
    }
}