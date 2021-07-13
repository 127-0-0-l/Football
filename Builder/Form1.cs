using System;
using System.Drawing;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        int scoreL = 0;
        int scoreR = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Right:
                    gamer2.Left += 30;
                    if (gamer2.Location == box.Location)
                    {
                        box.Left += 30;
                    }
                    break;
                case Keys.Left:
                    gamer2.Left -= 30;
                    if (gamer2.Location == box.Location)
                    {
                        box.Left -= 30;
                    }
                    break;
                case Keys.Up:
                    gamer2.Top -= 30;
                    if (gamer2.Location == box.Location)
                    {
                        box.Top -= 30;
                    }
                    break;
                case Keys.Down:
                    gamer2.Top += 30;
                    if (gamer2.Location == box.Location)
                    {
                        box.Top += 30;
                    }
                    break;
                case Keys.D:
                    gamer1.Left += 30;
                    if (gamer1.Location == box.Location)
                    {
                        box.Left += 30;
                    }
                    break;
                case Keys.A:
                    gamer1.Left -= 30;
                    if (gamer1.Location == box.Location)
                    {
                        box.Left -= 30;
                    }
                    break;
                case Keys.W:
                    gamer1.Top -= 30;
                    if (gamer1.Location == box.Location)
                    {
                        box.Top -= 30;
                    }
                    break;
                case Keys.S:
                    gamer1.Top += 30;
                    if (gamer1.Location == box.Location)
                    {
                        box.Top += 30;
                    }
                    break;
                case Keys.R:
                    scoreL = 0;
                    scoreR = 0;
                    scoreLeft.Text = "0";
                    scoreRight.Text = "0";
                    box.Location = new Point(300, 210);
                    gamer1.Location = new Point(30, 210);
                    gamer2.Location = new Point(570, 210);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }

            if (box.Left == goalL.Left && box.Top >= goalL.Top && box.Top < goalL.Top + goalL.Height)
            {
                scoreL++;
                scoreRight.Text = Convert.ToString(scoreL);
                box.Location = new Point(300, 210);
                gamer1.Location = new Point(30, 210);
                gamer2.Location = new Point(570, 210);
            }
            if (box.Left == goalR.Left && box.Top >= goalR.Top && box.Top < goalR.Top + goalR.Height)
            {
                scoreR++;
                scoreLeft.Text = Convert.ToString(scoreR);
                box.Location = new Point(300, 210);
                gamer1.Location = new Point(30, 210);
                gamer2.Location = new Point(570, 210);
            }
        }
    }
}
