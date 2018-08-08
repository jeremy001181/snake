using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private readonly Brush brush = new SolidBrush(Color.Black);
        private readonly Snake snake = new Snake(20);

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(brush, this.panel1.ClientRectangle);

            Draw(e.Graphics, snake);
        }

        private void Draw(Graphics graphics, Snake snake)
        {
            var rectangles = snake.BodyParts.Select(part => {
                var size = new Size(part.Width, part.Height);
                return new Rectangle(new Point(size), size);
            });

            foreach (var rectangle in rectangles)
            {
                graphics.FillRectangle(brush, rectangle);
            }
        }
    }
}
