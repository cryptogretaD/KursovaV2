using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace KursovaV2.Forms
{
    public class Rectangle : Shape
    {
        public byte Left { get; internal set; }
        public byte Right { get; internal set; }
        public byte Bottom { get; internal set; }
        public byte Top { get; internal set; }

        public Rectangle(Point position,Point delta, Color color) 
        {
            Position = position;
        }

        public Rectangle()
        {
        }

        public override double CalculateArea()
        {
            return(Width * Height);
        }

        public override void Draw(Graphics g)
        {
            var colorBorder = Selected ?
                Color.Red :
                Color.Blue;

            var colorFill = Color.FromArgb(100, this.Color);

            using (var brush = new SolidBrush(colorFill))
                g.FillRectangle(brush, Position.X, Position.Y, Width, Height);

            using (var pen = new Pen(colorBorder))
                g.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
        }

        public override bool PointInShape(Point point)
        {
            return
                Position.X <= point.X && point.X <= Position.X + Width &&
                Position.Y <= point.Y && point.Y <= Position.Y + Height;
 
        }

        public override bool Intersect(Rectangle rectangle)
        {
            return
                this.Position.X <= rectangle.Position.X + rectangle.Width &&
                rectangle.Position.X <= this.Position.X + this.Width &&
                this.Position.Y <= rectangle.Position.Y + rectangle.Height &&
                rectangle.Position.Y <= this.Position.Y + this.Height;
        }

        internal override Point GetPosition()
        {
            return Position;
        }

        public override void Move(Point delta, Point position)
        {
            position = new Point(Position.X + delta.X, Position.Y + delta.Y);
        }

        public override string ToString()
        {
            return $"Rectangle at {Position} with width {Width} and heigth {Height}";
        }
    }
}
