using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KursovaV2.Forms
{
    public class Triangle : Shape
    {
        public Triangle(Point position, int width, int height)
        {
            Position = position;
            Width = width; ;
            Height = height;
        } 


        public override double CalculateArea()
        {
            return 0.5 * Width * Height;
        }

        public override void Draw(Graphics g)
        {
            var colorBorder = Selected ? Color.Red : Color.Blue;
            var colorFill = Color.FromArgb(100, this.Color);

            Point[] points = new Point[]
            {
            new Point(Position.X + Width / 2, Position.Y), // Top
            new Point(Position.X, Position.Y + Height),     // Bottom left
            new Point(Position.X + Width, Position.Y + Height) // Bottom right
            };

            using (var brush = new SolidBrush(colorFill))
                g.FillPolygon(brush, points);

            using (var pen = new Pen(colorBorder))
                g.DrawPolygon(pen, points);
        }


        public override bool Intersect(Rectangle selectionRect)
        {
            var bounds = new System.Drawing.Rectangle(Position.X, Position.Y, Width, Height);
            return bounds.IntersectsWith(new System.Drawing.Rectangle(selectionRect.Position.X, selectionRect.Position.Y, selectionRect.Width, selectionRect.Height));
        }

        public override bool PointInShape(Point point)
        {
            Point[] triangle = new Point[]
            {
            new Point(Position.X + Width / 2, Position.Y),
            new Point(Position.X, Position.Y + Height),
            new Point(Position.X + Width, Position.Y + Height)
            };
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(triangle);
                return path.IsVisible(point);
            }
        }

        internal override Point GetPosition()
        {
            return Position;
        }

        public override void Move(Point position, Point delta)
        {
            position = new Point(Position.X + delta.X, Position.Y + delta.Y);
        }

        public override string ToString()
        {
            return $"Triangle at {Position} with base {Width} and height {Height}";
        }
    }
}
