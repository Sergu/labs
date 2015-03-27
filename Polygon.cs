using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop1_figuer_s_hierarchy
{
    class Polygon : Shape
    {
        public Polygon(Graphics graphics, Pen pen, List<Point> points)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.points = points;
        }
    }
}
