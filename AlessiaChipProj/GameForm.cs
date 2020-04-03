using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlessiaChipProj
{
    public partial class GameForm : Form
    {
        Tile[,] gameBoard = new Tile[9, 9];
        int timeRemaining = 100;
        int[] playerLocation = new int[2];
        int chipsRemaining;
        int chipsCollected;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            InitializePanel();
            StartLevelOne();
        }

        private void InitializePanel()
        {
            // Adds a Tile object to hold each PictureBox control, so that it can be manipulated.
            // Creates a PictureBox in each Tile to show in each square of the grid which is initially gray.
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    this.gameBoard[i, j] = new Tile(i, j);
                    this.tilePanel.Controls.Add(this.gameBoard[i, j].pictureBox, i, j);
                }
            }

            
        }

        private void StartLevelOne()
        {
            playerLocation[0] = 4;
            playerLocation[1] = 7;
            this.gameBoard[4, 7].TogglePlayer();
            chipsRemaining = 1;
            chipsCollected = 0;

            // TODO: Write a setter for this
            this.gameBoard[5, 4].containsChip = true;
            this.gameBoard[5, 4].pictureBox.BackColor = Color.Green;
        }

        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining != 0)
            {
                timeRemaining -= 1;
                this.timeLabel.Text = timeRemaining.ToString();
                this.timeBar.Value = timeRemaining;
            }
            else
            {
                timeRemaining = -1;
                secondsTimer.Stop();
                gameTick.Stop();
                MessageBox.Show("Out of time!", "Game over!", MessageBoxButtons.OK);
            }
        }

        // GAME ENGINE VARIABLES
        bool goUp;
        bool goLeft;
        bool goDown;
        bool goRight;

        // GAME ENGINE CODE
        private void gameTick_Tick(object sender, EventArgs e)
        {
            // Check for win
            if (chipsRemaining == 0)
            {
                gameTick.Stop();
                secondsTimer.Stop();
                MessageBox.Show("You have collected all of the chips in this level.", "You win!", MessageBoxButtons.OK);
            }

            // Update chip counts
            if (this.gameBoard[playerLocation[0], playerLocation[1]].containsChip)
            {
                this.gameBoard[playerLocation[0], playerLocation[1]].containsChip = false;
                chipsCollected += 1;
                chipsRemaining -= 1;
            }
            this.chipsRLabel.Text = chipsRemaining.ToString();
            this.chipsCLabel.Text = chipsCollected.ToString();

            // Handle movement
            this.gameBoard[playerLocation[0], playerLocation[1]].TogglePlayer();
            if (goUp && playerLocation[1] > 0) { playerLocation[1] -= 1; }
            if (goDown && playerLocation[1] < 8) { playerLocation[1] += 1; }
            if (goLeft && playerLocation[0] > 0) { playerLocation[0] -= 1; }
            if (goRight && playerLocation[0] < 8) { playerLocation[0] += 1; }
            this.gameBoard[playerLocation[0], playerLocation[1]].TogglePlayer();


        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

        }
    }
}
