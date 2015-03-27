using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace oop1_figuer_s_hierarchy
{
    public abstract class Shape
    {
        public List<Point> points; 
        public Pen pen;
        public Graphics graphics;
    }
}