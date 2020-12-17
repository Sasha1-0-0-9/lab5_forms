using System;
using System.Windows.Forms;

namespace OOP_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(50, 50, 100, pictureBox1);
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square(100, 100, 100, pictureBox1);
            square.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb(50, 150, 150, 200, pictureBox1);
            romb.MoveRight();
        }
    }
}
