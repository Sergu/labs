using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace oop1_figuer_s_hierarchy
{
    public class Line : Shape
    {
        protected float width;
        protected float height;
        public Line(Graphics graphics, Pen pen,List<Point> points)
        {
            this.points = points;
            this.graphics = graphics;
            this.pen = pen;
        }
    }
}