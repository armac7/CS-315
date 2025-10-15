using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Paint
{
    public partial class Form1 : Form
    {
        Color currPen = Color.Black;
        Color currBrush = Color.Transparent;
        Shape.Shapes currShape = Shape.Shapes.LINE;
        ArrayList screenShapes = new ArrayList();
        int prevX = 0, prevY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            prevX = e.X; prevY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Shape s;
            int x1, y1, x2, y2;
            Graphics g;

            if (currShape == Shape.Shapes.LINE)
            {
                x1 = prevX; y1 = prevY;
                x2 = e.X; y2 = e.Y;
            }
            else
            {
                if (prevX < e.X)
                {
                    x1 = prevX;
                    x2 = e.X - prevX;
                }
                else
                {
                    x1 = e.X;
                    x2 = prevX - e.X;
                }

                if (prevY < e.Y)
                {
                    y1 = prevY;
                    y2 = e.Y - prevY;
                }
                else
                {
                    y1 = e.Y;
                    y2 = prevY - e.Y;
                }
            }

            s = new Shape(currShape, x1, y1, x2, y2, currPen, currBrush);
            using (g = this.CreateGraphics())
                s.draw(g);
            screenShapes.Add(s);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            using (g = this.CreateGraphics())
                g.Clear(this.BackColor);

            screenShapes.Clear();

            currPen = Color.Black;
            currBrush = Color.Transparent;
            currShape = Shape.Shapes.LINE;
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                currBrush = colorDialog1.Color;
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                currPen = colorDialog1.Color;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currShape = Shape.Shapes.LINE;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currShape = Shape.Shapes.RECTANGLE;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currShape = Shape.Shapes.ELLIPSE;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
                foreach (Shape s in screenShapes)
                    s.draw(g);
        }
    }

    class Shape 
    { 
        public enum Shapes { LINE, RECTANGLE, ELLIPSE };
        int x1, y1, x2, y2;
        Color penColor, brushColor;
        Shapes shape;

        public Shape(Shapes shape,
            int x1, int y1,
            int x2, int y2,
            Color penColor, Color brushColor)
        { 
            this.shape = shape;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.penColor = penColor;
            this.brushColor = brushColor;
        }

        public void draw(Graphics g) 
        {
            Brush b;
            Pen p;

            using (b = new SolidBrush(brushColor))
            using (p = new Pen(penColor)) 
            {
                if (shape == Shapes.ELLIPSE)
                {
                    g.FillEllipse(b, x1, y1, x2, y2);
                    g.DrawEllipse(p, x1, y1, x2, y2);
                }
                else if (shape == Shapes.RECTANGLE)
                {
                    g.FillRectangle(b, x1, y1, x2, y2);
                    g.DrawRectangle(p, x1, y1, x2, y2);
                }
                else
                {
                    g.DrawLine(p, x1, y1, x2, y2);
                }
            }
        }
    }
}
