    private System.Drawing.Graphics g;
    System.Drawing.Point[] p = new System.Drawing.Point[6];
    p[0].X = 0;
    p[0].Y = 0;
    p[1].X = 53;
    p[1].Y = 111;
    p[2].X = 114;
    p[2].Y = 86;
    p[3].X = 34;
    p[3].Y = 34;
    p[4].X = 165;
    p[4].Y = 7;
    g = PictureBox1.CreateGraphics();
    g.DrawPolygon(pen1, p);


    public void DrawPolygonPoint(PaintEventArgs e)
    {

        // Create pen.
        Pen blackPen = new Pen(Color.Black, 3);

        // Create points that define polygon.
        Point point1 = new Point(50,  50);
        Point point2 = new Point(100,  25);
        Point point3 = new Point(200,   5);
        Point point4 = new Point(250,  50);
        Point point5 = new Point(300, 100);
        Point point6 = new Point(350, 200);
        Point point7 = new Point(250, 250);
        Point[] curvePoints =
                 {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5,
                     point6,
                     point7
                 };

        // Draw polygon to screen.
        e.Graphics.DrawPolygon(blackPen, curvePoints);
    }
