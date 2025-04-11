using KursovaV2.Forms;
using KursovaV2.Interface;
using KursovaV2.Windows;
using System.Drawing.Drawing2D;
using Rectangle = KursovaV2.Forms.Rectangle;
using Trinagle = KursovaV2.Forms.Triangle;

namespace KursovaV2
{
    public partial class Scene : Form
    {

        private string _startingShape;

        public void SetStartingShape(string shape)
        {
            _startingShape = shape.ToLower(); // "rectangle", "triangle", or "circle"
        }

        private List<Shape> _shapes = new List<Shape>();
        private int _width;
        private int _height;

        private Rectangle _frameRectangle;
        private Point _mouseDownLocation;

        private enum ShapeType { Rectangle, Triangle }
        private ShapeType _currentShapeType = ShapeType.Rectangle;

        public Scene(int height, int width)
        {
            InitializeComponent();

            _height = height;
            _width = width;

            //this.MouseClick += Scene_MouseClick;
            //this.MouseDown += Scene_MouseDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (IShape shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (_frameRectangle != null)
            {
                using (Pen pen = new Pen(Color.Blue) { DashStyle = DashStyle.Dash })
                {
                    e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(
                        _frameRectangle.Position.X,
                        _frameRectangle.Position.Y,
                        _frameRectangle.Width,
                        _frameRectangle.Height));
                }
            }
        }

        private void Scene_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location;
            _frameRectangle = new Rectangle();
        }

        private Point GetPosition()
        {
            return _frameRectangle.Position;
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e, Point position)
        {
            if (_frameRectangle == null)
                return;
            position = new Point
            {
                X = Math.Min(_mouseDownLocation.X, e.Location.X),
                Y = Math.Min(_mouseDownLocation.Y, e.Location.Y)
            };

            _frameRectangle.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
            _frameRectangle.Height = Math.Abs(_mouseDownLocation.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                foreach (var shape in _shapes)
                {
                    shape.Selected = shape.Intersect(_frameRectangle);
                }
            }

            Invalidate();
        }

        private void Scene_MouseClick(object sender, MouseEventArgs e)
        {
            Shape shape = null;

            switch (_currentShapeType)
            {
                case ShapeType.Rectangle:
                    shape = new Rectangle
                    {
                        Position = e.Location,
                        Width = _width,
                        Height = _height
                    };
                    break;
                case ShapeType.Triangle:
                    shape = new Trinagle
                    {
                        Position = e.Location,
                        Width = _width,
                        Height = _height
                    };
                    break;
            }

            foreach (var s in _shapes)
            {
                s.Selected = false;
            }

            for (int s = _shapes.Count - 1; s >= 0; s--)
            {
                if (_shapes[s].PointInShape(e.Location))
                {
                    _shapes[s].Selected = true;
                    return;
                }
            }

            _shapes.Add(shape);
            Invalidate();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            using (RectangleParams rp = new RectangleParams())
            {
                if (rp.ShowDialog() == DialogResult.OK)
                {
                    // Set _width and _height from rp
                }
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            using (TriangleParams rp = new TriangleParams())
            {
                if (rp.ShowDialog() == DialogResult.OK)
                {
                    // Set _width and _height from rp
                }
            }
        }

        private void Triangle1_Click(object sender, EventArgs e)
        {
            _currentShapeType = ShapeType.Triangle;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            _currentShapeType = ShapeType.Rectangle;
        }
    }
}

