using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Paper
{
    public partial class ChooseForm : Form
    {
        int playerChoose;
        int botChoose;
        int playerScore = 0;
        int botScore = 0;
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void RenderImage(int number)
        {
            switch (number)
            {
                case 1:
                    PbBot.Image = Rock_Scissors_Paper.Properties.Resources.rock;
                    botChoose = 1;
                    break;
                case 2:
                    PbBot.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
                    botChoose = 2;
                    break;
                case 3:
                    PbBot.Image = Rock_Scissors_Paper.Properties.Resources.paper;
                    botChoose = 3;
                    break;
               
            }
        }
        private void PbRock_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = Rock_Scissors_Paper.Properties.Resources.rock;
            PbBot.Image = Rock_Scissors_Paper.Properties.Resources.question;
            playerChoose = 1;
        }

        private void PbScissors_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = Rock_Scissors_Paper.Properties.Resources.scissors;
            PbBot.Image = Rock_Scissors_Paper.Properties.Resources.question;
            playerChoose = 2;
        }

        private void PbPaper_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = Rock_Scissors_Paper.Properties.Resources.paper;
            PbBot.Image = Rock_Scissors_Paper.Properties.Resources.question;
            playerChoose = 3;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            if (TbPlayerNickname.Text == "")
            {
                MessageBox.Show(" Въведете име !");
            }
            LbPlayerName.Text = TbPlayerNickname.Text;
            LbBotName.Visible = true;

            Random rnd = new Random();
            int num = rnd.Next(1,4);
            RenderImage(num);

            
            if ((playerChoose == 1 && botChoose == 2) || (playerChoose == 2 && botChoose == 3) || (playerChoose == 3 && botChoose == 1))
            {
                playerScore += 1;
                MessageBox.Show(LbPlayerName.Text + " печели ! ");
            }
            else if (playerChoose == botChoose)
            {
                MessageBox.Show(" Равен ! ");
            }
            else if (playerChoose == 4)
            {
            }
            else
            {
                botScore += 1;
                MessageBox.Show(LbBotName.Text + " печели ! ");
            }

            LbResult.Text = "Резултат: " + playerScore + " : " + botScore;
            
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = Rock_Scissors_Paper.Properties.Resources.question;
            PbBot.Image = Rock_Scissors_Paper.Properties.Resources.question;
            playerScore = 0;
            botScore = 0;
            LbResult.Text = "Резултат: " + playerScore + " : " + botScore;
            TbPlayerNickname.Text = string.Empty;
            LbPlayerName.Text = string.Empty;
            LbBotName.Visible = false;

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {
            playerChoose = 4;
        }
    }
}
