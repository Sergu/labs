using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace oop1_figuer_s_hierarchy
{
    class Draw
    {
        public static void Drawing(Shape fig)
        {
            Graphics gr;
            int x,y,width,height;
            if (fig is Oval)
            {
                Analysis(fig.points, out x, out y, out width, out height);
                gr = fig.graphics;
                
                gr.DrawEllipse(fig.pen,x,y,width,height);                
            }
            if (fig is Line)
            {
                gr = fig.graphics;
                gr.DrawLine(fig.pen, fig.points[0], fig.points[1]);
            }
            if (fig is Rectangle)
            {
                Analysis(fig.points, out x, out y, out width, out height);
                gr = fig.graphics;

                gr.DrawRectangle(fig.pen, x, y, width, height); 
            }
            if (fig is Polygon)
            {
                int size = fig.points.Count;
                Point[] pts = new Point[size];
                pts = fig.points.ToArray();
                gr = fig.graphics;
                try
                {
                    if (pts.Length <= 2)
                    { 
                        throw new ArgumentException();
                    }
                    gr.DrawPolygon(fig.pen, pts);
                }
                catch(System.ArgumentException e)
                {
                    MessageBox.Show("Corners number should be more than 2");
                }
            }
            if (fig is Square)
            {
                Analysis(fig.points, out x, out y, out width, out height);
                gr = fig.graphics;
                if (width < height)
                {
                    height = width;
                }
                else
                {
                    width = height;
                }
                gr.DrawRectangle(fig.pen, x, y, width, height);
            }
            if (fig is Circle)
            {
                Analysis(fig.points, out x, out y, out width, out height);
                gr = fig.graphics;
                if (width < height)
                    height = width;
                else
                    width = height;

                gr.DrawEllipse(fig.pen, x, y, width, height);
            }
        }

        private static void Analysis(List<Point> points,out int xmin,out int ymin,out int width,out int height)
        {
            int size = points.Count();

            if (points[0].X < points[1].X)
            {
                xmin = points[0].X;
            }
            else
            {
                xmin = points[1].X;
            }
            if (points[0].Y < points[1].Y)
            {
                ymin = points[0].Y;
            }
            else
            {
                ymin = points[1].Y;
            }
            width = Convert.ToInt32(Math.Abs(points[0].X - points[1].X));
            height =Convert.ToInt32(Math.Abs(points[0].Y - points[1].Y));
        }
    }
}
