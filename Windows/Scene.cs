using KursovaV2.Forms;
using KursovaV2.Interface;
using KursovaV2.Windows;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Rectangle = KursovaV2.Forms.Rectangle;
using Trinagle = KursovaV2.Forms.Triangle;

namespace KursovaV2
{
    public partial class Scene : Form
    {
        public void SetStartingShape(ShapeType shapetype)
        {
            _currentShapeType = shapetype;
        }

        private List<Shape> _shapes = new List<Shape>();
        private int _width;
        private int _height;
        private Rectangle _frameRectangle;
        private Point _mouseDownLocation;

        public enum ShapeType { Rectangle, Triangle, Circle }
        private ShapeType _currentShapeType = ShapeType.Rectangle;
        private Color shapeColor;
        private int diameter;

        private bool _isDragging = false;
        private Shape? _draggedShape = null;
        private Point _lastMousePosition;

        public Scene(int height, int width)
        {
            InitializeComponent();

            _height = height;
            _width = width;
            this.MouseClick += Scene_MouseClick;
            this.MouseDown += Scene_MouseDown;
            this.MouseUp += Scene_MouseUp;
            this.MouseMove += Scene_MouseMove;
            this.MouseDoubleClick += Scene_MouseDoubleClick;
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
                using (Pen pen = new Pen(Color.Pink) { DashStyle = DashStyle.Dash })
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

            foreach (var shape in _shapes.AsEnumerable().Reverse())
            {
                if (shape.PointInShape(e.Location))
                {
                    _draggedShape = shape;
                    _lastMousePosition = e.Location;
                    _isDragging = true;
                    break;
                }
            }
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {
            if (_frameRectangle == null)
                return;

            _frameRectangle.Position = new Point
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

            if (_isDragging && _draggedShape != null)
            {
                int dx = e.X - _lastMousePosition.X;
                int dy = e.Y - _lastMousePosition.Y;

                _draggedShape.Move(new Point(dx, dy), _draggedShape.GetPosition());
                _lastMousePosition = e.Location;
                Invalidate();
            }

            Invalidate();
        }

        private void Scene_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            _draggedShape = null;
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
                        Height = _height,
                        Color = Color.Red
                    };
                    break;
                case ShapeType.Triangle:
                    shape = new Trinagle(e.Location, _width, _height)
                    {
                        Color = Color.Red
                    };
                    break;
                case ShapeType.Circle:
                    shape = new Circle(e.Location, _width)
                    {
                        Height = _height,
                        Color = Color.Red
                    };
                    break;
            }

            _shapes.ForEach(s => s.Selected = false);

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

        private void Scene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                if (_shapes[i].PointInShape(e.Location))
                {
                    _shapes.RemoveAt(i);
                    Invalidate();
                    break;
                }
            }
        }

        public void UpdateShapeColors(Type shapeType, Color newColor)
        {
            foreach (var shape in _shapes)
            {
                if (shape.GetType() == shapeType)
                {
                    shape.Color = newColor;
                }
            }

            Invalidate();
        }

        private void cangeColorButton_Click(object sender, EventArgs e)
        {
            var changeForm = new ChangeColor(this);
            changeForm.ShowDialog();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            using (RectangleParams rp = new RectangleParams())
            {
                if (rp.ShowDialog(this) == DialogResult.OK)
                {
                    _currentShapeType = ShapeType.Rectangle;
                }
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            using (TriangleParams rp = new TriangleParams())
            {
                if (rp.ShowDialog(this) == DialogResult.OK)
                {
                    _currentShapeType = ShapeType.Triangle;
                }
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            using (CircleParams rp = new CircleParams())
            {
                if (rp.ShowDialog(this) == DialogResult.OK)
                {
                    _currentShapeType = ShapeType.Circle;
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

        private void Circle1_Click(object sender, EventArgs e)
        {
            _currentShapeType = ShapeType.Circle;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
