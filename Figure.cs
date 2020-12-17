using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab5
{
    public abstract class Figure
    {
        protected int x_center;
        protected int y_center;
        protected Graphics graph;
        protected PictureBox pictureBox;
        protected Bitmap bmp;

        public abstract void DrawBlack();
        public void MoveRight()
        {
            InIt();
            while (x_center < pictureBox.Width)
            {
                DrawBlack();
                Thread.Sleep(10);
                pictureBox.Refresh();
                graph.FillRectangle(Brushes.White, 0, 0, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bmp;
                x_center++;
            }
            graph.Clear(Color.White);
        }

        private void InIt()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = SmoothingMode.HighQuality;
        }
    }
}
