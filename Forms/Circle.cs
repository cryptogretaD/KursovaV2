using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaV2.Forms
{
    internal class Circle : Shape
    {
        public Circle(Point position, int diameter, Color color)
        {
            Position = position;
            Width = diameter;
            Height = diameter;  
        }

        public override double CalculateArea()
        {
            double radius = Width / 2.0;
            return Math.PI * radius * radius;
        }

        public override void Draw(Graphics g)
        {
            var colorBorder = Selected ?
                Color.Red :
                Color.Blue;

            var colorFill = Color.FromArgb(100, Color.Red);

            using (var brush = new SolidBrush(colorFill))
                g.FillEllipse(brush, Position.X, Position.Y, Width, Height);

            using (var pen = new Pen(colorBorder))
                g.DrawEllipse(pen, Position.X, Position.Y, Width, Height);
        }

        public override bool Intersect(Rectangle rectangle)
        {
            /*float cx = Position.X + Width / 2f;
            float cy = Position.Y + Height / 2f;
            float radius = Width / 2f;

            float closestX = Math.Clamp(cx, rectangle.Left, rectangle.Right);
            float closestY = Math.Clamp(cy, rectangle.Top, rectangle.Bottom);

            float dx = cx - closestX;
            float dy = cy - closestY;

            return (dx * dx + dy * dy) <= (radius * radius);*/
            throw new NotImplementedException();
        }

        public override bool PointInShape(Point point)
        {
            float centerX = Position.X + Width / 2f;
            float centerY = Position.Y + Height / 2f;
            float radius = Width / 2f;

            float dx = point.X - centerX;
            float dy = point.Y - centerY;

            return dx * dx + dy * dy <= radius * radius;
        }

        public override void Move(Point position)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Circle at {Position} with diameter {Width}";
        }
    }
}
