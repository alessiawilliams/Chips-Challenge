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
        // Fields of the form
        IGameTile[,] gameBoard = new IGameTile[9, 9];
        int timeRemaining = 100;
        int[] playerLocation = new int[2];
        int chipsRemaining;
        int chipsCollected;
        int currentLevel = 0;

        // Form UI
        public GameForm()
        {
            InitializeComponent();
        }

        private void InitializePanel()
        {
            tilePanel.Controls.Clear();
            // Adds a Tile object to hold each PictureBox control, so that it can be manipulated.
            // Creates a PictureBox in each Tile to show in each square of the grid which is initially gray.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gameBoard[i, j] = new Tile(i, j);
                    tilePanel.Controls.Add(gameBoard[i, j].pictureBox, i, j);
                }
            }
        }

        // Deals with Menu > File > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Deals with Menu > File > New Game
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartLevelOne();
        }

        // Deals with Menu > Level > Enter Password
        private void enterPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm pf = new PasswordForm();
            pf.ShowDialog();
            string pw = pf.passwordBox.Text;
            pf.Dispose();
            if (pw == "one") { StartLevelOne(); }
            else if (pw == "two") { } // Start level 2, etc
            else { MessageBox.Show("Sorry, that's not a valid password!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Deals with Menu > Level > Restart
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // START FORM
        private void GameForm_Load(object sender, EventArgs e)
        {
            InitializePanel();
        }

        // LEVELS
        private void StartLevelOne()
        {
            // Form
            InitializePanel();
            currentLevel = 1;
            this.Text = "[LEVEL 1] Chips Challenge - Alessia";
            this.secondsTimer.Enabled = true;
            this.gameTick.Enabled = true;

            // Initialize player
            playerLocation[0] = 7;
            playerLocation[1] = 7;
            gameBoard[7, 7].TogglePlayer();

            // Create chips
            chipsRemaining = 5;
            chipsCollected = 0;

            gameBoard[6, 4].containsChip = true;
            gameBoard[0, 6].containsChip = true;
            gameBoard[3, 0].containsChip = true;
            gameBoard[7, 2].containsChip = true;
            gameBoard[1, 8].containsChip = true;

            // Create walls
            gameBoard[6, 8].walkable = false;

            // Create exit and hint tiles
            gameBoard[1, 1].isExit = true;
            gameBoard[6, 7].isHint = true;
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
            if (chipsRemaining == 0 && gameBoard[playerLocation[0], playerLocation[1]].isExit)
            {
                gameTick.Stop();
                secondsTimer.Stop();
                if (MessageBox.Show("You have collected all of the chips in this level. Show password?", "You win!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (currentLevel == 1) { MessageBox.Show("Password for Level 2: two", "You win!", MessageBoxButtons.OK); }
                }
            }

            // Update chip counts
            if (gameBoard[playerLocation[0], playerLocation[1]].containsChip)
            {
                gameBoard[playerLocation[0], playerLocation[1]].containsChip = false;
                chipsCollected += 1;
                chipsRemaining -= 1;
            }
            chipsRLabel.Text = chipsRemaining.ToString();
            chipsCLabel.Text = chipsCollected.ToString();

            // Pick up keys
            if (gameBoard[playerLocation[0], playerLocation[1]].containsKey)
            {
                gameBoard[playerLocation[0], playerLocation[1]].containsKey = false;
                gameBoard[playerLocation[0], playerLocation[1]].key.collected = true;
            }

            // Handle movement
            gameBoard[playerLocation[0], playerLocation[1]].TogglePlayer();
            if (goUp && playerLocation[1] > 0 && gameBoard[playerLocation[0], playerLocation[1] - 1].walkable) { playerLocation[1] -= 1; }
            if (goDown && playerLocation[1] < 8 && gameBoard[playerLocation[0], playerLocation[1] + 1].walkable) { playerLocation[1] += 1; }
            if (goLeft && playerLocation[0] > 0 && gameBoard[playerLocation[0] - 1, playerLocation[1]].walkable) { playerLocation[0] -= 1; }
            if (goRight && playerLocation[0] < 8 && gameBoard[playerLocation[0] + 1, playerLocation[1]].walkable) { playerLocation[0] += 1; }
            gameBoard[playerLocation[0], playerLocation[1]].TogglePlayer();


        }

        // Handle key presses
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

        // Handle key releases
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

        // Handle seconds timer
        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining != 0)
            {
                timeRemaining -= 1;
                timeLabel.Text = timeRemaining.ToString();
                timeBar.Value = timeRemaining;
            }
            else
            {
                timeRemaining = -1;
                secondsTimer.Stop();
                gameTick.Stop();
                MessageBox.Show("Out of time!", "Game over!", MessageBoxButtons.OK);
            }
        }
    }
}
