namespace PaintProject
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap;
        bool mouseDown = false;
        public Form1()
        {
            InitializeComponent();
            myBitmap = new Bitmap(Size.Width, Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == false)
            {
                return;

            }
            Graphics g = Graphics.FromImage(myBitmap); //get graphics context of off screen bitmap
            Pen p = new Pen(Color.Red, 2);
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1); //draw a point on off screen bitmap
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //get graphics context of form(which is being displayed)
            g.DrawImageUnscaled(myBitmap, 0, 0);
        }
    }
}