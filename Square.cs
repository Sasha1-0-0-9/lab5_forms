using System.Drawing;
using System.Windows.Forms;

namespace OOP_lab5
{
    public class Square : Figure
    {
        private int sideLength;

        public Square(int x_center, int y_center, int sideLength, PictureBox pictureBox)
        {
            this.x_center = x_center;
            this.y_center = y_center;
            this.sideLength = sideLength;
            this.pictureBox = pictureBox;
        }

        public override void DrawBlack()
        {
            graph.DrawRectangle(Pens.Black,
                x_center - sideLength / 2, y_center - sideLength / 2, sideLength, sideLength);
        }
    }
}
