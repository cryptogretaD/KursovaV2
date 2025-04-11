using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KursovaV2.Forms
{
    public class Triangle :Shape
    {
        public Triangle() {}


        public override double CalculateArea()
        {
            return 0.5 * Width * Height;
        }

        public override void Draw(Graphics g)
        {
            var colorBorder = Selected ? Color.Red : Color.Blue;
            var colorFill = Color.FromArgb(100, Color.Red); 

            Point[] points = new Point[]
            {
                new Point(Position.X, Position.Y),                         // Top point
                new Point(Position.X - Width / 2, Position.Y + Height),   // Bottom-left
                new Point(Position.X + Width / 2, Position.Y + Height)    // Bottom-right
            };

            using (var brush = new SolidBrush(colorFill))
                g.FillPolygon(brush, points);

            using (var pen = new Pen(colorBorder))
                g.DrawPolygon(pen, points);
        }

        public override bool Intersect(Rectangle rectangle)
        {
            Point[] points = new Point[]
            {
                new Point(Position.X, Position.Y),
                new Point(Position.X - Width / 2, Position.Y + Height),
                new Point(Position.X + Width / 2, Position.Y + Height)
            };

            foreach (var point in points)
            {
                if (point.X >= rectangle.Position.X &&
            point.X <= rectangle.Position.X + rectangle.Width &&
            point.Y >= rectangle.Position.Y &&
            point.Y <= rectangle.Position.Y + rectangle.Height)
                {
                    return true;
                }
            }

            return false;
        }

        public override bool PointInShape(Point point)
        {
            Point p0 = new Point(Position.X, Position.Y);
            Point p1 = new Point(Position.X - Width / 2, Position.Y + Height);
            Point p2 = new Point(Position.X + Width / 2, Position.Y + Height);

            float denominator = ((p1.Y - p2.Y) * (p0.X - p2.X) + (p2.X - p1.X) * (p0.Y - p2.Y));
            float a = ((p1.Y - p2.Y) * (point.X - p2.X) + (p2.X - p1.X) * (point.Y - p2.Y)) / denominator;
            float b = ((p2.Y - p0.Y) * (point.X - p2.X) + (p0.X - p2.X) * (point.Y - p2.Y)) / denominator;
            float c = 1 - a - b;

            return a >= 0 && b >= 0 && c >= 0;
        }

        public override void Move(Point position)
        {
            position = position;
        }

        public override string ToString()
        {
            return $"Triangle at {Position} with base {Width} and height {Height}";
        }
    }
}
