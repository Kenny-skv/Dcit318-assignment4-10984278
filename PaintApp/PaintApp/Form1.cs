namespace PaintApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
            isDrawing = false;
            lastPoint = Point.Empty;
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (lastPoint != Point.Empty)
                {
                    using (Graphics g = drawingPanel.CreateGraphics())
                    {
                        g.DrawLine(Pens.Black, lastPoint, e.Location);
                    }
                    lastPoint = e.Location;
                }
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
            }
        }
    }
}
