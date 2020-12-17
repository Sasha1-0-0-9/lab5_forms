using System.Drawing;
using System.Windows.Forms;

namespace OOP_lab5
{
    public class Romb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;
        public Romb(int x_center, int y_center, int horDiagLen, int vertDiagLen, PictureBox pictureBox)
        {
            this.x_center = x_center;
            this.y_center = y_center;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
            this.pictureBox = pictureBox;
        }

        public override void DrawBlack()
        {
            graph.DrawPolygon(Pens.Black,
                new Point[]
                {
                    new Point(x_center - horDiagLen / 2, y_center),
                    new Point(x_center, y_center - vertDiagLen / 2),
                    new Point(x_center + horDiagLen / 2, y_center),
                    new Point(x_center, y_center + vertDiagLen / 2),
                });
        }
    }
}
