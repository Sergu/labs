using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1_figuer_s_hierarchy
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Pen pen;
        List<Point> pointsList = new List<Point>();
        Creator creator;
        Shape figure;
        List<Point> points;
        private int ptscount,ptsmaxcount;
        public Form1()
        {
            InitializeComponent();
        }

        public void Circle_but_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreator();
            ptsmaxcount = 2;
            points.Clear();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point;
            
            point = e.Location;
            points.Add(point);
            ptscount++;
            if (ptscount == ptsmaxcount)
            {
                ptscount = 0;
                figure = creator.FactoryMetod(graph, pen, points);
                Draw.Drawing(figure);
                points.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            points = new List<Point>();
            ptscount = 0;
            ptsmaxcount = 2;
            CompoboxPen.SelectedIndex = 0;
            graph = CreateGraphics();            
        }

        private void Rect_but_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreator();
            ptsmaxcount = 2;
            ptscount = 0;
            points.Clear();
        }

        private void Line_but_Click(object sender, EventArgs e)
        {
            creator = new LineCreator();
            ptsmaxcount = 2;
            ptscount = 0;
            points.Clear();
        }

        private Pen GetPen()
        {
            switch (CompoboxPen.SelectedIndex)
            {
                case 0: return new Pen(Color.Red);
                case 1: return new Pen(Color.Yellow);
                case 2: return new Pen(Color.Green);
                case 3: return new Pen(Color.Blue);
                case 4: return new Pen(Color.Brown);
                case 5: return new Pen(Color.Purple);
                default: return new Pen(Color.Black);
            }
        }

        private void Polygon_But_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreator();
            ptsmaxcount = Convert.ToInt32(numericCorners.Value);
            points.Clear();
        }

        private void numericCorners_ValueChanged(object sender, EventArgs e)
        {
            if (creator is PolygonCreator)
            {
                ptsmaxcount = Convert.ToInt32(numericCorners.Value);
                ptscount = 0;
                points.Clear();
            }
        }

        private void CompoboxPen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = GetPen();
        }

        private void But_Circle_Click(object sender, EventArgs e)
        {
            creator = new CircleCreator();
            ptsmaxcount = 2;
            ptscount = 0;
            points.Clear();
        }

        private void But_Square_Click(object sender, EventArgs e)
        {
            creator = new SquareCreator();
            ptsmaxcount = 2;
            ptscount = 0;
            points.Clear();
        }
    }
}
