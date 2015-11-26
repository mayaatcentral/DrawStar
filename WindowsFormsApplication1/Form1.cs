///Made by Maya Stuart
/// On November 26, 2015
/// Draw Star program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            float xCoor = Convert.ToSingle(xInput.Text);      //holds x value user inputted 
            float yCoor = Convert.ToSingle(yInput.Text);      //holds y value user inputted
            float size = Convert.ToSingle(sizeInput.Text);    //holds size value user inputted
                      
            //Go to method 
            DrawStar(yCoor, xCoor, size);
        }
        /// <summary>
        /// Draws star in different position and size
        /// </summary>
        /// <param name="yCoor">y position of star</param>
        /// <param name="xCoor">x postion of star</param>
        /// <param name="size">size (pixels) of star</param>
        private void DrawStar(float yCoor, float xCoor, float size)
        {
            //create formGraphics 
            Graphics formGraphics = this.CreateGraphics();

            //create pen
            Pen drawPen = new Pen(Color.Yellow, 5);

            //Draw Star
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(drawPen, (110 + xCoor) * (size/140) , (9 + yCoor) * (size/194), (84 + xCoor) * (size / 140), (84 + yCoor) * (size/194));
            formGraphics.DrawLine(drawPen, (110 + xCoor) * (size / 140), (9 + yCoor) * (size / 194), (133 + xCoor) * (size / 140), (83 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (8 + xCoor) * (size / 140), (84 + yCoor) * (size / 194), (84 + xCoor) * (size / 140), (84 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (8 + xCoor) * (size / 140), (84 + yCoor) * (size / 194), (70 + xCoor) * (size / 140), (129 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (47 + xCoor) * (size / 140), (203 + yCoor) * (size / 194), (70 + xCoor) * (size / 140), (129 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (47 + xCoor) * (size / 140), (203 + yCoor) * (size / 194), (109 + xCoor) * (size / 140), (158 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (173 + xCoor) * (size / 140), (203 + yCoor) * (size / 194), (109 + xCoor) * (size / 140), (158 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (173 + xCoor) * (size / 140), (203 + yCoor) * (size / 194), (148 + xCoor) * (size / 140), (129 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (211 + xCoor) * (size / 140), (84 + yCoor) * (size / 194), (148 + xCoor) * (size / 140), (129 + yCoor) * (size / 194));
            formGraphics.DrawLine(drawPen, (211 + xCoor) * (size / 140), (84 + yCoor) * (size / 194), (133 + xCoor) * (size / 140), (83 + yCoor) * (size / 194));

        }

    }
    }
