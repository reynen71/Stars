using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StarField(100);
        }
        public void StarField(int stars)
        {
            Random randNum = new Random();
            int rand; 

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 5);
            rand = randNum.Next(1, 10001);

            for (int i = 0; i < stars; i ++)
            {
                int xValue = randNum.Next(0, this.Width);
                int yValue = randNum.Next(0, this.Height);
                int RGBValue1 = randNum.Next(0, 225);
                int RGBValue2 = randNum.Next(0, 225);
                int RGBValue3 = randNum.Next(0, 225);
                int size1 = randNum.Next(0, 100);
                int size2 = randNum.Next(0, 100);

                drawPen.Color = Color.FromArgb(RGBValue1, RGBValue2, RGBValue3, 0);
                formGraphics.DrawEllipse(drawPen, xValue, yValue, size1, size2);
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);

        }
    }
}
