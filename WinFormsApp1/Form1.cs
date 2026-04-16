using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] memes = { "meme1.jpg", "meme2.png", "meme3.jpg" };
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(memes[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i >= memes.Length)
                i = 0;

            pictureBox1.Image = Image.FromFile(memes[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;

            if (i < 0)
                i = memes.Length - 1;

            pictureBox1.Image = Image.FromFile(memes[i]);
        }
    }
}