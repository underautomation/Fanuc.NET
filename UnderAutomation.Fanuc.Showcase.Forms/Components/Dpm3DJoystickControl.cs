using System.Drawing.Drawing2D;

public class Dpm3DJoystickControl : Control
{
    private float _xValue = 0.5f, _yValue = 0.5f, _zValue = 0.5f;
    private PointF _xyCursor = new PointF(0.5f, 0.5f);
    private PointF _xzCursor = new PointF(0.5f, 0.5f);
    private PointF _yzCursor = new PointF(0.5f, 0.5f);
    private string _activeAxis = null;
    private string _activeSquare = null;

   public bool GetXYZ(out float x, out float y, out float z)
    {
        // thread safe
        var xValue = _xValue;
        var yValue = _yValue;
        var zValue = _zValue;
        var xyCursor = _xyCursor;
        var xzCursor = _xzCursor;
        var yzCursor = _yzCursor;
        var activeAxis = _activeAxis;
        var activeSquare = _activeSquare;

        if(activeAxis != null)
        {
            x = (xValue - 0.5f) * 2;
            y = (yValue - 0.5f) * 2;
            z = (zValue - 0.5f) * 2;
        }
        else if(activeSquare != null)
        {
            if (activeSquare == "XY")
            {
                x = (xyCursor.X - 0.5f) * 2;
                y = (xyCursor.Y - 0.5f) * 2;
                z = 0;
            }
            else if (activeSquare == "XZ")
            {
                x = (xzCursor.X - 0.5f) * 2;
                y = 0;
                z = (xzCursor.Y - 0.5f) * 2;
            }
            else
            {
                x = 0;
                y = (yzCursor.X - 0.5f) * 2;
                z = (yzCursor.Y - 0.5f) * 2;
            }
        }
        else
        {
            x = 0; y = 0; z = 0;
            return false;
        }
        return true;
    }

    public Dpm3DJoystickControl()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
        this.MouseDown += OnMouseDown;
        this.MouseMove += OnMouseMove;
        this.MouseUp += OnMouseUp;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        g.Clear(Color.Black);

        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;

        PointF xAxis = TransformVector(-1, 1, 0, unitScale);
        PointF yAxis = TransformVector(1, 0, 0, unitScale);
        PointF zAxis = TransformVector(0, 0, 1, unitScale);

        Pen axisPen = new Pen(Color.White, 2);
        Pen dashedPen = new Pen(Color.White, 1);
        dashedPen.DashStyle = DashStyle.Dot;

        DrawAxis(g, origin, xAxis, "X", _xValue, axisPen, unitScale);
        DrawAxis(g, origin, yAxis, "Y", _yValue, axisPen, unitScale);
        DrawAxis(g, origin, zAxis, "Z", _zValue, axisPen, unitScale);

        DrawDottedSquareWithCursor(g, origin, xAxis, yAxis, dashedPen, _xyCursor);
        DrawDottedSquareWithCursor(g, origin, xAxis, zAxis, dashedPen, _xzCursor);
        DrawDottedSquareWithCursor(g, origin, yAxis, zAxis, dashedPen, _yzCursor);
    }

    private void DrawAxis(Graphics g, PointF origin, PointF axis, string label, float value, Pen pen, float scale)
    {
        PointF end = Add(origin, Scale(axis, 1.2f));
        g.DrawLine(pen, origin, end);
        g.DrawString(label, Font, Brushes.White, end);

        PointF cursor = Add(origin, Scale(axis, value));
        g.FillEllipse(Brushes.Red, cursor.X - 4, cursor.Y - 4, 8, 8);
    }

    private void DrawDottedSquareWithCursor(Graphics g, PointF origin, PointF v1, PointF v2, Pen pen, PointF cursorValue)
    {
        PointF p0 = origin;
        PointF p1 = Add(origin, v1);
        PointF p2 = Add(Add(origin, v1), v2);
        PointF p3 = Add(origin, v2);

        g.DrawLine(pen, p0, p1);
        g.DrawLine(pen, p1, p2);
        g.DrawLine(pen, p2, p3);
        g.DrawLine(pen, p3, p0);

        PointF cursor = Add(origin, Add(Scale(v1, cursorValue.X), Scale(v2, cursorValue.Y)));
        g.FillRectangle(Brushes.Red, cursor.X - 4, cursor.Y - 4, 8, 8);
    }

    private PointF TransformVector(float x, float y, float z, float scale)
    {
        float px = -(x - y) * 0.5f;
        float py = (x + y) * 0.3f - z * 0.8f;
        return new PointF(px * scale, py * scale);
    }

    private PointF Add(PointF a, PointF b)
    {
        return new PointF(a.X + b.X, a.Y + b.Y);
    }

    private PointF Scale(PointF v, float s)
    {
        return new PointF(v.X * s, v.Y * s);
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        string hit = HitTest(e.Location);
        if (hit == null)
        {
            hit = HitTestAxis(e.Location);
            if (hit != null)
            {
                UpdateAxisValue(hit, e.Location);
            }
            else
            {
                _activeSquare = HitTestSquare(e.Location);
            }
        }

        if (hit != null)
        {
            _activeAxis = hit;
            SetCursorForAxis(_activeAxis);
            Invalidate();
        }
        else if (_activeSquare != null)
        {
            Cursor = Cursors.SizeAll;
            Invalidate();
        }
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (_activeAxis != null && e.Button == MouseButtons.Left)
        {
            UpdateAxisValue(_activeAxis, e.Location);
            SetCursorForAxis(_activeAxis);
            Invalidate();
        }
        else if (_activeSquare != null && e.Button == MouseButtons.Left)
        {
            UpdateSquareValue(_activeSquare, e.Location);
            Cursor = Cursors.SizeAll;
            Invalidate();
        }
        else
        {
            string hovered = HitTest(e.Location);
            if (hovered != null)
            {
                SetCursorForAxis(hovered);
            }
            else if (HitTestSquare(e.Location) != null)
            {
                Cursor = Cursors.SizeAll;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }
    }

    private void OnMouseUp(object sender, MouseEventArgs e)
    {
        if (_activeAxis != null)
        {
            if (_activeAxis == "X") _xValue = 0.5f;
            if (_activeAxis == "Y") _yValue = 0.5f;
            if (_activeAxis == "Z") _zValue = 0.5f;
            _activeAxis = null;
        }
        if (_activeSquare != null)
        {
            if (_activeSquare == "XY") _xyCursor = new PointF(0.5f, 0.5f);
            if (_activeSquare == "XZ") _xzCursor = new PointF(0.5f, 0.5f);
            if (_activeSquare == "YZ") _yzCursor = new PointF(0.5f, 0.5f);
            _activeSquare = null;
        }
        Cursor = Cursors.Default;
        Invalidate();
    }

    private void UpdateAxisValue(string axis, Point location)
    {
        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;
        PointF dir = axis == "X" ? TransformVector(-1, 1, 0, unitScale) :
                     axis == "Y" ? TransformVector(1, 0, 0, unitScale) :
                                   TransformVector(0, 0, 1, unitScale);

        float dot = ((location.X - origin.X) * dir.X + (location.Y - origin.Y) * dir.Y) / (dir.X * dir.X + dir.Y * dir.Y);
        dot = Math.Max(0, Math.Min(1, dot));

        if (axis == "X" && _xValue != dot) { _xValue = dot; }
        if (axis == "Y" && _yValue != dot) { _yValue = dot; }
        if (axis == "Z" && _zValue != dot) { _zValue = dot; }
    }

    private void UpdateSquareValue(string square, Point location)
    {
        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;

        PointF v1, v2;
        if (square == "XY") { v1 = TransformVector(-1, 1, 0, unitScale); v2 = TransformVector(1, 0, 0, unitScale); }
        else if (square == "XZ") { v1 = TransformVector(-1, 1, 0, unitScale); v2 = TransformVector(0, 0, 1, unitScale); }
        else { v1 = TransformVector(1, 0, 0, unitScale); v2 = TransformVector(0, 0, 1, unitScale); }

        PointF offset = new PointF(location.X - origin.X, location.Y - origin.Y);

        float det = v1.X * v2.Y - v1.Y * v2.X;
        if (Math.Abs(det) < 1e-5f) return; // avoid divide by zero

        float a = (offset.X * v2.Y - offset.Y * v2.X) / det;
        float b = (offset.Y * v1.X - offset.X * v1.Y) / det;

        a = Math.Max(0, Math.Min(1, a));
        b = Math.Max(0, Math.Min(1, b));

        if (square == "XY" && _xyCursor != new PointF(a, b)) { _xyCursor = new PointF(a, b); }
        if (square == "XZ" && _xzCursor != new PointF(a, b)) { _xzCursor = new PointF(a, b); }
        if (square == "YZ" && _yzCursor != new PointF(a, b)) { _yzCursor = new PointF(a, b); }
    }

    private string HitTest(Point location)
    {
        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;
        float hitRadius = 8f;

        (string axis, PointF dir, float value)[] axes = new[]
        {
            ("X", TransformVector(-1, 1, 0, unitScale), _xValue),
            ("Y", TransformVector(1, 0, 0, unitScale), _yValue),
            ("Z", TransformVector(0, 0, 1, unitScale), _zValue),
        };

        foreach (var (name, dir, val) in axes)
        {
            PointF pt = Add(origin, Scale(dir, val));
            if (Math.Abs(location.X - pt.X) < hitRadius && Math.Abs(location.Y - pt.Y) < hitRadius)
                return name;
        }

        return null;
    }

    private string HitTestAxis(Point location)
    {
        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;
        float axisTolerance = 5f;

        (string axis, PointF dir)[] axes = new[]
        {
            ("X", TransformVector(-1, 1, 0, unitScale)),
            ("Y", TransformVector(1, 0, 0, unitScale)),
            ("Z", TransformVector(0, 0, 1, unitScale)),
        };

        foreach (var (name, dir) in axes)
        {
            for (float t = 0; t <= 1.2f; t += 0.05f)
            {
                PointF pt = Add(origin, Scale(dir, t));
                if (Math.Abs(location.X - pt.X) < axisTolerance && Math.Abs(location.Y - pt.Y) < axisTolerance)
                    return name;
            }
        }

        return null;
    }

    private string HitTestSquare(Point location)
    {
        PointF origin = new PointF(Width / 2f, Height / 2f);
        float margin = 20f;
        float unitScale = (Math.Min(Width, Height) - margin * 2) / 2.4f;

        (string name, PointF v1, PointF v2, PointF val)[] squares = new[]
        {
            ("XY", TransformVector(-1, 1, 0, unitScale), TransformVector(1, 0, 0, unitScale), _xyCursor),
            ("XZ", TransformVector(-1, 1, 0, unitScale), TransformVector(0, 0, 1, unitScale), _xzCursor),
            ("YZ", TransformVector(1, 0, 0, unitScale), TransformVector(0, 0, 1, unitScale), _yzCursor),
        };

        foreach (var (name, v1, v2, val) in squares)
        {
            PointF pt = Add(origin, Add(Scale(v1, val.X), Scale(v2, val.Y)));
            if (Math.Abs(location.X - pt.X) < 8 && Math.Abs(location.Y - pt.Y) < 8)
                return name;
        }
        return null;
    }

    private void SetCursorForAxis(string axis)
    {
        if (axis == "X") Cursor = Cursors.SizeWE;
        else if (axis == "Y") Cursor = Cursors.SizeNESW;
        else if (axis == "Z") Cursor = Cursors.SizeNS;
    }
}