using System.Drawing;
using System.Windows.Forms;

namespace OOP_lab5
{
    public class Circle : Figure
    {
        private int radius;

        public Circle(int x_center, int y_center, int radius, PictureBox pictureBox)
        {
            this.x_center = x_center;
            this.y_center = y_center;
            this.radius = radius;
            this.pictureBox = pictureBox;
        }

        public override void DrawBlack()
        {
            graph.DrawEllipse(Pens.Black, x_center - radius / 2, y_center - radius / 2, radius, radius);
        }
    }
}
