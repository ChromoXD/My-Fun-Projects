using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int XScore = 0;
        int OScore = 0;
        bool isX = false;
        bool XWon = false;
        bool OWon = false;
        bool Stop = false;
        bool Start = true;
        public Point offset;
        bool isMouseDown = false;
        bool Clicked = false, Clicked1 = false, Clicked2 = false, Clicked3 = false, Clicked4 = false, Clicked5 = false, Clicked6 = false, Clicked7 = false, Clicked8 = false;
        bool isImageX = false, isImageX1 = false, isImageX2 = false, isImageX3 = false, isImageX4 = false, isImageX5 = false, isImageX6 = false, isImageX7 = false, isImageX8 = false;
        bool isImageO = false, isImageO1 = false, isImageO2 = false, isImageO3 = false, isImageO4 = false, isImageO5 = false, isImageO6 = false, isImageO7 = false, isImageO8 = false;

        bool ClickedOne = false, ClickedTwo = false, ClickedThree = false, ClickedFour = false, ClickedFive = false, ClickedSix = false, ClickedSeven = false, ClickedEight = false, ClickedNine = false;
        public Form1()
        {
            InitializeComponent();
            if (Start == true)
            {
                btn.Text = "Start";
            }
            else if (Start == false)
            {
                btn.Text = "OK!";
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            Tab_0.BackgroundImage = null; Tab_1.BackgroundImage = null; Tab_2.BackgroundImage = null; Tab_3.BackgroundImage = null; Tab_4.BackgroundImage = null; Tab_5.BackgroundImage = null; Tab_6.BackgroundImage = null; Tab_7.BackgroundImage = null; Tab_8.BackgroundImage = null; isMouseDown = false; isX = false; isImageX = false; isImageX1 = false; isImageX2 = false; isImageX3 = false; isImageX4 = false; isImageX5 = false; isImageX6 = false; isImageX7 = false; isImageX8 = false; isImageO = false; isImageO1 = false; isImageO2 = false; isImageO3 = false; isImageO4 = false; isImageO5 = false; isImageO6 = false; isImageO7 = false; isImageO8 = false; Clicked = false; Clicked1 = false; Clicked2 = false; Clicked3 = false; Clicked4 = false; Clicked5 = false; Clicked6 = false; Clicked7 = false; Clicked8 = false; Stop = false; Start = false; MsgX.Visible = false; ClickedOne = false; ClickedTwo = false; ClickedThree = false; ClickedFour = false; ClickedFive = false; ClickedSix = false; ClickedSeven = false; ClickedEight = false; ClickedNine = false; XWon = false; OWon = false;
        }
        public void roundButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void roundButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void MousePressedDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            isMouseDown = true;
        }
        public void formPosition(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                Point CurrentScreenpos = PointToScreen(e.Location);
                Location = new Point(CurrentScreenpos.X - offset.X, CurrentScreenpos.Y - offset.Y);
            }
        }
        public void MousePressedUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }


        private void btn_Click(object sender, EventArgs e)
        {
            lbl_O.Text = Txt_Bx_O.Text;
            lbl_X.Text = Txt_Bx_X.Text;
            pnl_Menu.Visible = false;
            Start = false;
        }
        private void zero(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked == false)
                {
                    ClickedOne = true;
                    if (isX == true)
                    {
                        Tab_0.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX = true;
                    }
                    else if (isX == false)
                    {
                        Tab_0.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO = true;
                    }
                }
                Clicked = true;
            }
        }
        private void One(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked1 == false)
                {
                    ClickedTwo = true;
                    if (isX == true)
                    {
                        Tab_1.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX1 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_1.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO1 = true;
                    }
                }
                Clicked1 = true;
            }
        }
        private void Two(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked2 == false)
                {
                    ClickedThree = true;
                    if (isX == true)
                    {
                        Tab_2.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX2 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_2.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO2 = true;
                    }
                }
                Clicked2 = true;
            }
        }
        private void Three(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked3 == false)
                {
                    ClickedFour = true;
                    if (isX == true)
                    {
                        Tab_3.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX3 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_3.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO3 = true;
                    }
                }
                Clicked3 = true;
            }
        }
        private void Four(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked4 == false)
                {
                    ClickedFive = true;
                    if (isX == true)
                    {
                        Tab_4.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX4 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_4.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO4 = true;
                    }
                }
                Clicked4 = true;
            }
        }
        private void Five(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked5 == false)
                {
                    ClickedSix = true;
                    if (isX == true)
                    {
                        Tab_5.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX5 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_5.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO5 = true;
                    }
                }
                Clicked5 = true;
            }
        }
        private void Six(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked6 == false)
                {
                    ClickedSeven = true;
                    if (isX == true)
                    {
                        Tab_6.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX6 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_6.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO6 = true;
                    }
                }
                Clicked6 = true;
            }
        }
        private void Seven(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked7 == false)
                {
                    ClickedEight = true;
                    if (isX == true)
                    {
                        Tab_7.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX7 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_7.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO7 = true;
                    }
                }
            }
            Clicked7 = true;
        }
        private void Eight(object sender, MouseEventArgs e)
        {
            if (Start == false)
            {
                if (Clicked8 == false)
                {
                    ClickedNine = true;
                    if (isX == true)
                    {
                        Tab_8.BackgroundImage = Properties.Resources.X;
                        isX = false;
                        isImageX8 = true;
                    }
                    else if (isX == false)
                    {
                        Tab_8.BackgroundImage = Properties.Resources.O;
                        isX = true;
                        isImageO8 = true;
                    }
                }
                Clicked8 = true;
            }
        }

        private void Declare(object sender, EventArgs e)
        {
            Scor_O.Text = OScore.ToString();
            Scor_X.Text = XScore.ToString();

            if (Stop == false && isImageX == true && isImageX1 == true && isImageX2 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX3 == true && isImageX4 == true && isImageX5 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX6 == true && isImageX7 == true && isImageX8 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX == true && isImageX4 == true && isImageX8 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX2 == true && isImageX4 == true && isImageX6 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX == true && isImageX3 == true && isImageX6 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX1 == true && isImageX4 == true && isImageX7 == true)
            {
                XLine();
            }
            if (Stop == false && isImageX2 == true && isImageX5 == true && isImageX8 == true)
            {
                XLine();
            }

            if (Stop == false && isImageO == true && isImageO1 == true && isImageO2 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO3 == true && isImageO4 == true && isImageO5 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO6 == true && isImageO7 == true && isImageO8 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO == true && isImageO4 == true && isImageO8 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO2 == true && isImageO4 == true && isImageO6 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO == true && isImageO3 == true && isImageO6 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO1 == true && isImageO4 == true && isImageO7 == true)
            {
                OLine();
            }
            if (Stop == false && isImageO2 == true && isImageO5 == true && isImageO8 == true)
            {
                OLine();
            }
            if (CkBx_Score_On.Checked == false)
            {
                Scor_O.Visible = false; Scor_X.Visible = false;
            }
            if (ClickedOne == true && ClickedTwo == true && ClickedThree == true && ClickedFour == true && ClickedFive == true && ClickedSix == true && ClickedSeven == true && ClickedEight == true && ClickedNine == true && XWon == false && OWon == false)
            {
                MsgX.Visible = true;
                WonText.Text = "Draw";
                lbl_Winner.Text = " ";
            }
        }
        public void XLine()
        {
            XWon = true;
            Stop = true;
            Start = true;
            WonText.Text = "Won";
            lbl_Winner.Text = Txt_Bx_X.Text;
            MsgX.Visible = true;
            XScore++;
        }
        public void OLine()
        {
            OWon = true;
            Stop = true;
            Start = true;
            WonText.Text = "Won";
            lbl_Winner.Text = Txt_Bx_O.Text;
            MsgX.Visible = true;
            OScore++;
        }
    }
}