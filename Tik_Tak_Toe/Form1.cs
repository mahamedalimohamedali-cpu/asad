using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tik_Tak_Toe.Properties;
namespace Tik_Tak_Toe
{
    public partial class Form1 : Form
    {



        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

         public bool CheckValues(Button btn1,Button btn2, Button btn3) 
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString()) 
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else 
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;

                }
            }

            GameStatus.GameOver = false;
            return false;

        }

        void EndGame() 
        {
            lbl_Turn.Text = "Game Over";
            switch (GameStatus.Winner) 
            {
                case enWinner.Player1:
                    lbl_Winner.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lbl_Winner.Text = "Player2";
                    break;

                default:
                    lbl_Winner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Disable();
        }

        public void CheckWinner()
        {
            //********************************RAWS***********************************
            //Raw1
            if (CheckValues(button1, button2, button3))
                return;
            //Raw2
            if (CheckValues(button4, button5, button6))
                return;
            //Raw3
            if (CheckValues(button7, button8, button9))
                return;

            //********************************Colons***********************************
            //Col1
            if (CheckValues(button1, button4, button7))
                return;
            //Col2
            if (CheckValues(button2, button5, button8))
                return;
            //Col3
            if (CheckValues(button3, button6, button9))
                return;

            //********************************Diagonals**********************************

            //Diagonal1
            if (CheckValues(button3, button5, button7))
                return;
            //Diagonal2
            if (CheckValues(button1, button5, button9))
                return;

        }


        void Disable() 
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void Enable() 
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        public void ChangImage(Button btn) 
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X; 
                        PlayerTurn = enPlayer.Player2;
                        lbl_Turn.Text = "Player2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbl_Turn.Text = "Player1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else 
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // draw Horizontal lines (من X = 400 إلى 850)
            e.Graphics.DrawLine(whitePen, 400, 290, 850, 290);
            e.Graphics.DrawLine(whitePen, 400, 440, 850, 440);

            // draw Vertical lines (من Y = 140 إلى 590)
            e.Graphics.DrawLine(whitePen, 550, 140, 550, 590);
            e.Graphics.DrawLine(whitePen, 700, 140, 700, 590);
        }

       

        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }
        private void RestartGame()
        {

            Enable();
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lbl_Turn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lbl_Winner.Text = "In Progress";



        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangImage((Button) sender);
        }

    }
}
