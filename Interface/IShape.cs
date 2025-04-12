using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaV2.Interface
{
    internal interface IShape
    {
       abstract double CalculateArea();

       abstract void Draw(Graphics g);
       abstract bool PointInShape(Point point);
       abstract bool Intersect(Rectangle rectangle);

       //abstract void Move(Point delta);
       void Move(Point position, Point delta);
    }
}
