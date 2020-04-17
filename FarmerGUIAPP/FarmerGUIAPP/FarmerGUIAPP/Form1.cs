using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGUIAPP
{
    public partial class FarmerGUI : Form
    {
        Farmer Game = new Farmer();
        string playermove;
        bool wrongmove;
        int eaten = 1;

        public FarmerGUI()
        {
            InitializeComponent();
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n Name:\t\t Adam Peterka" +
            "\n Course:\t\t IT DEV 115" +
            "\n Assignment:\t Fox Chicken Grain Game" +
            "\n Date:\t\t " + System.DateTime.Today.ToShortDateString());
        }

        private void introductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome to the Farmer Game. " +
                "\n\n You are a farmer that must safely get his fox, chicken, and grain across \n a roaring river." +
                "\n\n The tricky part is you can only take one thing at a time across." +
                "\n\n This also means that you don't need to take anything at all." +
                "\n\n The catch though is that, if you leave the fox alone with the chicken, \n the fox will devour the chicken." +
                "\n\n Also, if the chicken is left alone with the grain, the chicken will nibble \n away at the grain." +
                "\n\n The game ends when you have moved the fox, chicken, and grain all \n across the river." +
                "\n\n\t Good luck! Press enter to start.");
        }

        private void directionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the pictures to move the item you want." +
                "\n\n If you would like to move just the farmer, just click the farmer." +
                "\n\n To restart, click File -> Restart.");
        }

        private void picBxFarmerNorth_Click(object sender, EventArgs e)
        {
            playermove = "";

            Game.Move(playermove);

            picBxFarmerNorth.Visible = false;
            picBxFarmerSouth.Visible = true;

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

        }

        private void picBxFarmerSouth_Click(object sender, EventArgs e)
        {
            playermove = "";

            Game.Move(playermove);
            picBxFarmerNorth.Visible = true;
            picBxFarmerSouth.Visible = false;

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);


        }

        private void picBxChickenNorth_Click(object sender, EventArgs e)
        {
            playermove = "CHICKEN";

            wrongmove = Game.Move(playermove);
            if(wrongmove == false)
            {
                picBxFarmerNorth.Visible = false;
                picBxFarmerSouth.Visible = true;
                picBxChickenNorth.Visible = false;
                picBxChickenSouth.Visible = true;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();



        }

        private void picBxChickenSouth_Click(object sender, EventArgs e)
        {
            playermove = "CHICKEN";

            wrongmove = Game.Move(playermove);
            if (wrongmove == false)
            {
                picBxFarmerNorth.Visible = true;
                picBxFarmerSouth.Visible = false;
                picBxChickenNorth.Visible = true;
                picBxChickenSouth.Visible = false;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();
        }

        private void picBxGrainNorth_Click(object sender, EventArgs e)
        {
            playermove = "GRAIN";

            wrongmove = Game.Move(playermove);
            if (wrongmove == false)
            {
                picBxFarmerNorth.Visible = false;
                picBxFarmerSouth.Visible = true;
                picBxGrainNorth.Visible = false;
                picBxGrainSouth.Visible = true;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();


        }

        private void picBxGrainSouth_Click(object sender, EventArgs e)
        {
            playermove = "GRAIN";

            wrongmove = Game.Move(playermove);
            if (wrongmove == false)
            {
                picBxFarmerNorth.Visible = true;
                picBxFarmerSouth.Visible = false;
                picBxGrainNorth.Visible = true;
                picBxGrainSouth.Visible = false;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();


        }

        private void picBxFoxNorth_Click(object sender, EventArgs e)
        {
            playermove = "FOX";

            wrongmove = Game.Move(playermove);
            if (wrongmove == false)
            {
                picBxFarmerNorth.Visible = false;
                picBxFarmerSouth.Visible = true;
                picBxFoxNorth.Visible = false;
                picBxFoxSouth.Visible = true;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();


        }

        private void picBxFoxSouth_Click(object sender, EventArgs e)
        {
            playermove = "FOX";

            wrongmove = Game.Move(playermove);
            if (wrongmove == false)
            {
                picBxFarmerNorth.Visible = true;
                picBxFarmerSouth.Visible = false;
                picBxFoxNorth.Visible = true;
                picBxFoxSouth.Visible = false;
            }
            else
            {
                InvalidMove();
            }

            eaten = Game.AnimalAteFood();
            EatenDisplay(eaten);

            WinCheck();


        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void InvalidMove()
        {
            MessageBox.Show(" Invalid Move! \n\n The farmer is not on the same side as that item.");
        }

        private void WinCheck()
        {
            bool win;

            win = Game.DetermineWin();

            if (win == true) //displays win message box
            {
                MessageBox.Show(" Congratulations! \n\n You have won! \n\n Click File -> Restart to start a new game!" +
                    "\n\n Click File -> Exit to exit the game.");
                LockElements();
            }
        }

        private void EatenDisplay(int eaten)
        {
            switch(eaten)
            {
                case 1:
                    break;

                case 2:
                    MessageBox.Show(" The Fox ate the Chicken! \n\n You lose!" +
                        "\n\n Please click File -> Restart to start a new game!");
                    LockElements();
                    break;
                case 3:
                    MessageBox.Show(" The Chicken ate the Grain! \n\n You lose!" +
                        "\n\n Please click File -> Restart to start a new game!");
                    LockElements();
                    break;
            }
        }

        private void LockElements()
        {
            picBxFarmerNorth.Enabled = false;
            picBxFarmerSouth.Enabled = false;

            picBxChickenNorth.Enabled = false;
            picBxChickenSouth.Enabled = false;

            picBxFoxNorth.Enabled = false;
            picBxFoxSouth.Enabled = false;

            picBxGrainNorth.Enabled = false;
            picBxGrainSouth.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
