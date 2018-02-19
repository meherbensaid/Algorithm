namespace Algorithm.Centroid
{
   public class Centroid
    {
        public Point CalculateCentroid(Point[] points,
            int lastPointIndex)
        {
            var area = 0.0f;
            var cx = 0.0f;
            var cy = 0.0f;

            for (int i = 0; i <= lastPointIndex; i++)
            {
                //var k = (i + 1);
                var k = (i + 1) % (lastPointIndex + 1);
                var tmp = points[i].X * points[k].Y -
                            points[k].X * points[i].Y;
                area += tmp;
                cx += (points[i].X + points[k].X) * tmp;
                cy += (points[i].Y + points[k].Y) * tmp;
            }
            area *= 0.5f;
            cx *= 1.0f / (6.0f * area);
            cy *= 1.0f / (6.0f * area);

            return new Point(cx, cy);
        }
    }
}
