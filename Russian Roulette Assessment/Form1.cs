using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette_Assessment
{
    public partial class Form1 : Form
    {
        Gameplay myGameplay = new Gameplay();

        public Form1()
        {
            InitializeComponent();
        }




        private void releaseButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            openButton.Visible = true;
            skipButton.Visible = true;

            // instruction on what to do
            lblMessages.Text = "Open Each Door 1 by 1 and save the puppies BUT beware of the lion hiding in one of the rooms, Skip the door if you feel it isn't safe";

            //Updates the picturebox with an image to show what happens
            pbMain.Image = Properties.Resources.door;


        }



        private void openButton_Click(object sender, EventArgs e)
        {

            myGameplay.LionChoiceText = myGameplay.Play();
            lblGameMsg.Text = "Opened Door: " + myGameplay.LionChoiceText;
            // add audio through the resource folder
            SoundPlayer OpenDoor = new SoundPlayer(Properties.Resources.door_1_open);
            OpenDoor.Play(); // plays the audio

            if (myGameplay.ConditionWin())
            {
                lblWin.Text = "Win: " + myGameplay.Win; // shows how many times u won
                nextlevelButton.Visible = true;
            }

            // checks if the user saved a puppy or got eaten by the lion and then adds an image based on what happened
            if (myGameplay.LionChoiceText == "You saved a Puppy")
            {
                lblScore.Text = "Score: " + myGameplay.Score; // updates score
                pbMain.Image = Properties.Resources.puppies;
            }

            else
            {
                //add audio
                SoundPlayer LionRoar = new SoundPlayer(Properties.Resources.lion_roar);
                LionRoar.Play(); //plays the audio
                pbMain.Image = Properties.Resources.lion;
                GameOver();
            }

        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            myGameplay.Skip();

            lblGameMsg.Text = "You Have Skipped this Door";
            pbMain.Image = Properties.Resources.door;

        }

        private void nextlevelButton_Click(object sender, EventArgs e)
        {
            nextlevelButton.Visible = false;
            pbMain.Image = Properties.Resources.stairs;

            //myGameplay.Score = -1;
            myGameplay.SavedPups = 0; // everytime this button gets clicked SavedPups resets back to zero to stop a bug from occuring
            myGameplay.Nextlvl();
        }

        private void GameOver()
        {
            endexitButton.Visible = true;
            //endplayagainButton.Visible = true;
            endscoreLbl.Visible = true;

            endscoreLbl.Text = "Score: " + myGameplay.Score;


        }

        private void endplayagainButton_Click(object sender, EventArgs e)
        {
            endexitButton.Visible = false;
            endplayagainButton.Visible = false;
            endscoreLbl.Visible = false;

            //myGameplay.gameOver = false;
            myGameplay.Play();
            myGameplay.Score = 0;
            myGameplay.SavedPups = 0;

        }

        private void endexitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
