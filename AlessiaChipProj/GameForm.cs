using AlessiaChipProj.Tiles.Items;
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
        Key[] inventory = new Key[3];
        int chipsRemaining;
        int chipsCollected;
        int currentLevel = 0;
        string levelHintText;

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
            else if (pw == "two") { StartLevelTwo(); }
            else if (pw == "three") { StartLevelThree(); }
            else if (pw == "four") { StartLevelFour(); }
            else if (pw == "five") { StartLevelFive(); }
            else { MessageBox.Show("Sorry, that's not a valid password!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Deals with Menu > Level > Restart
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentLevel == 1) { StartLevelOne(); }
            if (currentLevel == 2) { StartLevelTwo(); }
            if (currentLevel == 3) { StartLevelThree(); }
            if (currentLevel == 4) { StartLevelFour(); }
            if (currentLevel == 5) { StartLevelFive(); }
        }

        // START FORM
        private void GameForm_Load(object sender, EventArgs e)
        {
            InitializePanel();
        }

        // LEVELS
        private void NewLevel(int level, int remaining, int playerX, int playerY)
        {
            chipsRemaining = remaining;
            currentLevel = level;
            timeRemaining = 100;
            chipsCollected = 0;

            this.Text = $"[LEVEL {level}] Chips Challenge - Alessia";
            Array.Clear(inventory, 0, inventory.Length);
            invenRedKey.BackgroundImage = Resources.NoKey;
            invenYellowKey.BackgroundImage = Resources.NoKey;
            invenBlueKey.BackgroundImage = Resources.NoKey;

            InitializePanel();

            // Create player
            playerLocation[0] = playerX;
            playerLocation[1] = playerY;
            gameBoard[playerX, playerY].TogglePlayer();
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            this.secondsTimer.Start();
            this.gameTick.Start();
        }

        private void StartLevelOne()
        {
            NewLevel(1, 5, 7, 7);
            
            // Create hint
            levelHintText = "Hint: Collect all the chips and go to the exit door.";

            // Create chips
            gameBoard[6, 4].containsChip = true;
            gameBoard[0, 6].containsChip = true;
            gameBoard[3, 0].containsChip = true;
            gameBoard[7, 2].containsChip = true;
            gameBoard[1, 8].containsChip = true;

            // Create exit and hint tiles
            gameBoard[1, 1].isExit = true;
            gameBoard[6, 7].isHint = true;
        }

        private void StartLevelTwo()
        {
            NewLevel(2, 3, 0, 0);

            // Create hint
            levelHintText = "Hint: Try using the key to get through the door!";

            // Create chips
            gameBoard[0, 8].containsChip = true;
            gameBoard[8, 8].containsChip = true;
            gameBoard[4, 0].containsChip = true;

            // Create walls
            gameBoard[1, 0].walkable = false;
            gameBoard[1, 1].walkable = false;
            gameBoard[1, 2].walkable = false;
            gameBoard[1, 3].walkable = false;
            gameBoard[1, 4].walkable = false;
            gameBoard[1, 6].walkable = false;
            gameBoard[1, 7].walkable = false;
            gameBoard[1, 8].walkable = false;
            gameBoard[3, 1].walkable = false;
            gameBoard[3, 2].walkable = false;
            gameBoard[3, 3].walkable = false;
            gameBoard[3, 4].walkable = false;
            gameBoard[3, 6].walkable = false;
            gameBoard[3, 8].walkable = false;
            gameBoard[4, 1].walkable = false;
            gameBoard[4, 4].walkable = false;
            gameBoard[4, 6].walkable = false;
            gameBoard[5, 0].walkable = false;
            gameBoard[5, 1].walkable = false;
            gameBoard[5, 2].walkable = false;
            gameBoard[5, 4].walkable = false;
            gameBoard[5, 6].walkable = false;
            gameBoard[5, 7].walkable = false;
            gameBoard[6, 4].walkable = false;
            gameBoard[6, 6].walkable = false;
            gameBoard[7, 1].walkable = false;
            gameBoard[7, 2].walkable = false;
            gameBoard[7, 3].walkable = false;
            gameBoard[7, 4].walkable = false;
            gameBoard[7, 6].walkable = false;
            gameBoard[7, 8].walkable = false;
            gameBoard[8, 6].walkable = false;

            // Create exit and hint tiles
            gameBoard[4, 2].isExit = true;
            gameBoard[2, 8].isHint = true;

            // Create doors and keys
            gameBoard[4, 3].AddKey(Color.Red);
            gameBoard[3, 0].AddDoor(Color.Red);
        }

        private void StartLevelThree()
        {
            NewLevel(3, 4, 0, 8);

            // Create hint
            levelHintText = "Hint: Different colored keys open different doors!";

            // Create chips
            gameBoard[0, 0].containsChip = true;
            gameBoard[3, 6].containsChip = true;
            gameBoard[5, 0].containsChip = true;
            gameBoard[8, 3].containsChip = true;

            // Create walls
            gameBoard[0, 2].walkable = false;
            gameBoard[1, 2].walkable = false;
            gameBoard[1, 5].walkable = false;
            gameBoard[1, 6].walkable = false;
            gameBoard[1, 7].walkable = false;
            gameBoard[1, 8].walkable = false;
            gameBoard[2, 2].walkable = false;
            gameBoard[2, 5].walkable = false;
            gameBoard[3, 5].walkable = false;
            gameBoard[3, 7].walkable = false;
            gameBoard[4, 0].walkable = false;
            gameBoard[4, 1].walkable = false;
            gameBoard[4, 2].walkable = false;
            gameBoard[4, 5].walkable = false;
            gameBoard[4, 6].walkable = false;
            gameBoard[4, 7].walkable = false;
            gameBoard[6, 2].walkable = false;
            gameBoard[6, 5].walkable = false;
            gameBoard[6, 6].walkable = false;
            gameBoard[6, 8].walkable = false;
            gameBoard[7, 2].walkable = false;
            gameBoard[7, 5].walkable = false;
            gameBoard[8, 2].walkable = false;
            gameBoard[8, 5].walkable = false;
            gameBoard[8, 7].walkable = false;

            // Create exit and hint tiles
            gameBoard[8, 0].isExit = true;
            gameBoard[8, 4].isHint = true;

            // Create doors and keys
            gameBoard[8, 6].AddKey(Color.Red);
            gameBoard[2, 7].AddDoor(Color.Red);
            gameBoard[8, 8].AddKey(Color.Yellow);
            gameBoard[3, 2].AddDoor(Color.Yellow);
            gameBoard[0, 1].AddKey(Color.Blue);
            gameBoard[5, 2].AddDoor(Color.Blue);
        }

        private void StartLevelFour()
        {
            NewLevel(4, 5, 4, 4);

            // Create hint
            levelHintText = "Hint: The final chip is behind the blue door - work backwards!";

            // Create chips
            gameBoard[0, 1].containsChip = true;
            gameBoard[3, 1].containsChip = true;
            gameBoard[8, 0].containsChip = true;
            gameBoard[8, 5].containsChip = true;
            gameBoard[8, 7].containsChip = true;

            // Create walls
            gameBoard[0, 0].walkable = false;
            gameBoard[0, 2].walkable = false;
            gameBoard[0, 4].walkable = false;
            gameBoard[0, 5].walkable = false;
            gameBoard[1, 4].walkable = false;
            gameBoard[1, 7].walkable = false;
            gameBoard[2, 1].walkable = false;
            gameBoard[2, 2].walkable = false;
            gameBoard[2, 4].walkable = false;
            gameBoard[2, 5].walkable = false;
            gameBoard[2, 6].walkable = false;
            gameBoard[2, 7].walkable = false;
            gameBoard[3, 2].walkable = false;
            gameBoard[4, 0].walkable = false;
            gameBoard[4, 1].walkable = false;
            gameBoard[4, 2].walkable = false;
            gameBoard[4, 6].walkable = false;
            gameBoard[4, 7].walkable = false;
            gameBoard[4, 8].walkable = false;
            gameBoard[5, 6].walkable = false;
            gameBoard[6, 1].walkable = false;
            gameBoard[6, 2].walkable = false;
            gameBoard[6, 3].walkable = false;
            gameBoard[6, 4].walkable = false;
            gameBoard[6, 6].walkable = false;
            gameBoard[6, 7].walkable = false;
            gameBoard[7, 4].walkable = false;
            gameBoard[8, 1].walkable = false;
            gameBoard[8, 2].walkable = false;
            gameBoard[8, 4].walkable = false;
            gameBoard[8, 6].walkable = false;
            gameBoard[8, 8].walkable = false;

            // Create exit and hint tiles
            gameBoard[5, 7].isExit = true;
            gameBoard[0, 3].isHint = true;

            // Create doors and keys
            gameBoard[1, 5].AddKey(Color.Yellow);
            gameBoard[7, 2].AddDoor(Color.Yellow);
            gameBoard[5, 8].AddKey(Color.Red);
            gameBoard[3, 6].AddDoor(Color.Red);
            gameBoard[8, 3].AddKey(Color.Blue);
            gameBoard[2, 0].AddDoor(Color.Blue);
        }

        private void StartLevelFive()
        {
            NewLevel(5, 4, 2, 0);

            // Create "hint"
            levelHintText = "Hint: You're on your own...";

            // Create chips
            gameBoard[0, 0].containsChip = true;
            gameBoard[3, 6].containsChip = true;
            gameBoard[6, 3].containsChip = true;
            gameBoard[8, 0].containsChip = true;

            // Create walls
            gameBoard[0, 8].walkable = false;
            gameBoard[1, 0].walkable = false;
            gameBoard[1, 3].walkable = false;
            gameBoard[1, 4].walkable = false;
            gameBoard[1, 6].walkable = false;
            gameBoard[2, 2].walkable = false;
            gameBoard[2, 6].walkable = false;
            gameBoard[2, 7].walkable = false;
            gameBoard[3, 0].walkable = false;
            gameBoard[3, 3].walkable = false;
            gameBoard[3, 5].walkable = false;
            gameBoard[4, 0].walkable = false;
            gameBoard[4, 1].walkable = false;
            gameBoard[4, 2].walkable = false;
            gameBoard[4, 5].walkable = false;
            gameBoard[4, 6].walkable = false;
            gameBoard[4, 8].walkable = false;
            gameBoard[5, 0].walkable = false;
            gameBoard[5, 3].walkable = false;
            gameBoard[5, 5].walkable = false;
            gameBoard[6, 2].walkable = false;
            gameBoard[6, 6].walkable = false;
            gameBoard[6, 7].walkable = false;
            gameBoard[7, 0].walkable = false;
            gameBoard[7, 3].walkable = false;
            gameBoard[7, 4].walkable = false;
            gameBoard[7, 6].walkable = false;
            gameBoard[8, 8].walkable = false;

            // Create exit and hint tiles
            gameBoard[5, 2].isExit = true;
            gameBoard[4, 3].isHint = true;

            // Create doors and keys
            gameBoard[3, 2].AddKey(Color.Red);
            gameBoard[0, 6].AddDoor(Color.Red);
            gameBoard[5, 6].AddKey(Color.Yellow);
            gameBoard[1, 5].AddDoor(Color.Yellow);
            gameBoard[8, 3].AddDoor(Color.Yellow);
            gameBoard[2, 3].AddKey(Color.Blue);
            gameBoard[5, 1].AddDoor(Color.Blue);
            gameBoard[5, 4].AddDoor(Color.Blue);
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
                if (currentLevel != 5)
                {
                    if (MessageBox.Show("You have collected all of the chips in this level. Show password?", "You win!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (currentLevel == 1) { MessageBox.Show("Password for Level 2: two", "You win!", MessageBoxButtons.OK); }
                        if (currentLevel == 2) { MessageBox.Show("Password for Level 3: three", "You win!", MessageBoxButtons.OK); }
                        if (currentLevel == 3) { MessageBox.Show("Password for Level 4: four", "You win!", MessageBoxButtons.OK); }
                        if (currentLevel == 4) { MessageBox.Show("Password for Level 5: five", "You win!", MessageBoxButtons.OK); }
                    }
                }
                else
                {
                    MessageBox.Show("Thank you for playing!", "You win!", MessageBoxButtons.OK);
                }
                if (currentLevel == 1) { StartLevelTwo(); }
                else if (currentLevel == 2) { StartLevelThree(); }
                else if (currentLevel == 3) { StartLevelFour(); }
                else if (currentLevel == 4) { StartLevelFive(); }
                else if (currentLevel == 5) { Environment.Exit(0); }
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
                gameBoard[playerLocation[0], playerLocation[1]].key.collected = true;
                if (gameBoard[playerLocation[0], playerLocation[1]].key.color == Color.Red) { invenRedKey.BackgroundImage = Resources.RedKey; inventory[0] = gameBoard[playerLocation[0], playerLocation[1]].key; }
                if (gameBoard[playerLocation[0], playerLocation[1]].key.color == Color.Yellow) { invenYellowKey.BackgroundImage = Resources.YellowKey; inventory[1] = gameBoard[playerLocation[0], playerLocation[1]].key; }
                if (gameBoard[playerLocation[0], playerLocation[1]].key.color == Color.Blue) { invenBlueKey.BackgroundImage = Resources.BlueKey; inventory[2] = gameBoard[playerLocation[0], playerLocation[1]].key; }
                gameBoard[playerLocation[0], playerLocation[1]].containsKey = false;
            }

            // Handle hint blocks
            if (gameBoard[playerLocation[0], playerLocation[1]].isHint)
            {
                hintLabel.Text = levelHintText;
            }
            else
            {
                hintLabel.Text = "Hint: ";
            }

            // Handle movement
            gameBoard[playerLocation[0], playerLocation[1]].TogglePlayer();
            if (goUp && playerLocation[1] > 0 && gameBoard[playerLocation[0], playerLocation[1] - 1].walkable)
            {
                if (gameBoard[playerLocation[0], playerLocation[1] - 1].isDoor)
                {
                    try
                    {
                        foreach (var _ in inventory.Where(k => k.color == gameBoard[playerLocation[0], playerLocation[1] - 1].door.color).Select(k => new { })) { playerLocation[1] -= 1; }
                    } catch { } // Ignores null in inventory where there is no key
                }
                else { playerLocation[1] -= 1; }
            }
            if (goDown && playerLocation[1] < 8 && gameBoard[playerLocation[0], playerLocation[1] + 1].walkable)
            {
                if (gameBoard[playerLocation[0], playerLocation[1] + 1].isDoor)
                {
                    try
                    {
                        foreach (var _ in inventory.Where(k => k.color == gameBoard[playerLocation[0], playerLocation[1] + 1].door.color).Select(k => new { })) { playerLocation[1] += 1; }
                    } catch { }
                }
                else { playerLocation[1] += 1; }
            }
            if (goLeft && playerLocation[0] > 0 && gameBoard[playerLocation[0] - 1, playerLocation[1]].walkable)
            {
                if (gameBoard[playerLocation[0] - 1, playerLocation[1]].isDoor)
                {
                    try
                    {
                        foreach (var _ in inventory.Where(k => k.color == gameBoard[playerLocation[0] - 1, playerLocation[1]].door.color).Select(k => new { })) { playerLocation[0] -= 1; }
                    } catch { }
                }
                else { playerLocation[0] -= 1; }
            }
            if (goRight && playerLocation[0] < 8 && gameBoard[playerLocation[0] + 1, playerLocation[1]].walkable)
            {
                if (gameBoard[playerLocation[0] + 1, playerLocation[1]].isDoor)
                {
                    try
                    {
                        foreach (var _ in inventory.Where(k => k.color == gameBoard[playerLocation[0] + 1, playerLocation[1]].door.color).Select(k => new { })) { playerLocation[0] += 1; }
                    } catch { }
                }
                else { playerLocation[0] += 1; }
            }
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
                if (timeRemaining <= 10) { timeBar.ForeColor = Color.Red; }
                else { timeBar.ForeColor = Color.Green; }
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
