using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace project_471223015
{
    public class RectangleShape : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public RectangleShape(Point location, float width, float height, Color outlineColor)
        {
            X = location.X;
            Y = location.Y;
            Width = width;
            Height = height;
            Color = outlineColor;
        }

        public override bool IsPointInside(PointF point)
        {
            return point.X >= X && point.X <= X + Width &&
                   point.Y >= Y && point.Y <= Y + Height;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }

        public override void Fill(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }

        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
        public override Shape Clone()
        {
            RectangleShape newRectangle = new RectangleShape(new Point(X, Y), Width, Height, Color);
            newRectangle.FillColor = FillColor; 
            return newRectangle;
        }
    }
}
