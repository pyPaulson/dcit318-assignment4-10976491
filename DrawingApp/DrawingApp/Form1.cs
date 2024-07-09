using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            graphics = panelCanvas.CreateGraphics();
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;

















        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                graphics.DrawLine(Pens.Black, startPoint, e.Location);
                startPoint = e.Location;
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }

    internal class panelCanvas
    {
        internal static Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }
}
    

