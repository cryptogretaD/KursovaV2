using KursovaV2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaV2.Forms
{
    public delegate void ShapeChangedEventHandler(string message);

    public abstract class Shape : IShape
    {
        public event ShapeChangedEventHandler? OnShapeChanged;

        //Properties
        public Point Position { get; init; }
        public int Width { get; set; }
        public int Height { get; set; }
        public double Base { get; set; }
        public bool Selected { get; set; }
        //public Color ShapeColor { get; set; }

        //Metods
        public abstract double CalculateArea();

        public abstract void Draw(Graphics g);
        public abstract bool Intersect(Rectangle rectangle);
        public abstract bool PointInShape(Point point);

        public abstract void Move(Point position);

        protected virtual void NotifyShapeChanged(string message)
        {
            OnShapeChanged?.Invoke(message);
        }

        public bool Intersect(System.Drawing.Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

    }
}
