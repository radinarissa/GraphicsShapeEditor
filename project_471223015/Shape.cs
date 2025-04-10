using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_471223015
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Color FillColor { get; set; }

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
        public abstract bool IsPointInside(PointF point);
        public abstract void Move(int deltaX, int deltaY);
        public abstract Shape Clone();
        protected void CloneProperties(Shape shape)
        {
            this.Color = shape.Color;
            this.FillColor = shape.FillColor;
        }
    }
}
