﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace oop1_figuer_s_hierarchy
{
    public class Circle : Oval
    {
        public Circle(Graphics graphics, Pen pen,List<Point> points)
            : base(graphics,pen,points)
        {
        }
    }
}
