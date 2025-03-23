using System;
using System.Drawing;
using System.Windows.Forms;
/*
public class DpmJoystickControl : Control
{
    private PointF circlePosition;
    private bool isDragging = false;
    private float radius = 30;
    private PointF center => new PointF(Width / 2f, Height / 2f);
    public event EventHandler<CircleMovedEventArgs> CircleMoved;

    public string XLabel { get; set; } = "X";
    public string YLabel { get; set; } = "Y";

    public DpmJoystickControl()
    {
        DoubleBuffered = true;
        BackColor = Color.Black;
        circlePosition = center;

        MouseDown += DpmJoystickControl_MouseDown;
        MouseMove += DpmJoystickControl_MouseMove;
        MouseUp += DpmJoystickControl_MouseUp;
        SizeChanged += DpmJoystickControl_SizeChanged;
    }

    private void DpmJoystickControl_SizeChanged(object sender, EventArgs e)
    {
        circlePosition = center;
        Invalidate();
    }

    private void DpmJoystickControl_MouseDown(object sender, MouseEventArgs e)
    {
        if (Distance(e.Location, circlePosition) <= radius)
        {
            isDragging = true;
        }
        else
        {
            circlePosition = e.Location;
            isDragging = true;
            Invalidate();
            NotifyMovement();
        }
    }

    private void DpmJoystickControl_MouseMove(object sender, MouseEventArgs e)
    {
        if (Distance(e.Location, circlePosition) <= radius || isDragging)
        {
            Cursor = Cursors.Hand;
        }
        else
        {
            Cursor = Cursors.Default;
        }

        if (isDragging)
        {
            circlePosition = e.Location;
            Invalidate();
            NotifyMovement();
        }
    }

    private void DpmJoystickControl_MouseUp(object sender, MouseEventArgs e)
    {
        isDragging = false;
        Cursor = Cursors.Default;
        circlePosition = center;
        Invalidate();
        NotifyMovement();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;

        // Axes
        Pen axisPen = new Pen(Color.White, 2);
        Point origin = new Point(10, Height - 10);

        // X-axis
        Point xEnd = new Point(origin.X + Width / 4, origin.Y);
        g.DrawLine(axisPen, origin, xEnd);
        DrawArrow(g, origin, xEnd);
        g.DrawString(XLabel, Font, Brushes.White, xEnd.X - 10, xEnd.Y - 25);

        // Y-axis
        Point yEnd = new Point(origin.X, origin.Y - Height / 4);
        g.DrawLine(axisPen, origin, yEnd);
        DrawArrow(g, origin, yEnd);
        g.DrawString(YLabel, Font, Brushes.White, yEnd.X + 10, yEnd.Y);

        // Circle
        Brush greenBrush = Brushes.LimeGreen;
        g.FillEllipse(greenBrush, circlePosition.X - radius, circlePosition.Y - radius, radius * 2, radius * 2);
    }

    private void DrawArrow(Graphics g, PointF from, PointF to)
    {
        Pen arrowPen = new Pen(Color.White, 2);
        arrowPen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4);
        g.DrawLine(arrowPen, from, to);
    }

    private void NotifyMovement()
    {
        float dx = (circlePosition.X - center.X) / (Width / 2);
        float dy = -(circlePosition.Y - center.Y) / (Height / 2); // Y axis flipped
        CircleMoved?.Invoke(this, new CircleMovedEventArgs(dx, dy));
    }

    private float Distance(PointF a, PointF b)
    {
        float dx = a.X - b.X;
        float dy = a.Y - b.Y;
        return (float)Math.Sqrt(dx * dx + dy * dy);
    }
}

public class CircleMovedEventArgs : EventArgs
{
    public float X { get; }
    public float Y { get; }

    public CircleMovedEventArgs(float x, float y)
    {
        X = x;
        Y = y;
    }
}*/