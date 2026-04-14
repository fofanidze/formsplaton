namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
            Point cursorPos = this.PointToClient(Cursor.Position);

            
            int centerX = button1.Left + button1.Width / 2;
            int centerY = button1.Top + button1.Height / 2;

            int dx = centerX - cursorPos.X;
            int dy = centerY - cursorPos.Y;

            int step = 30;

            if (dx != 0) dx = dx / Math.Abs(dx) * step;
            if (dy != 0) dy = dy / Math.Abs(dy) * step;

            int newX = button1.Left + dx;
            int newY = button1.Top + dy;

            
            newX = Math.Max(0, Math.Min(this.ClientSize.Width - button1.Width, newX));
            newY = Math.Max(0, Math.Min(this.ClientSize.Height - button1.Height, newY));

            button1.Location = new Point(newX, newY);
        }
    }
    
}


