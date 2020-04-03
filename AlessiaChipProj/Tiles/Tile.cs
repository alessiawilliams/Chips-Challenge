using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlessiaChipProj
{
    class Tile : IGameTile
    {
        public PictureBox pictureBox { get; set; }
        public bool containsPlayer { get; set; }
        public string keyColor { get; set; }
        public bool containsChip { get; set; }
        public int[] location { get; set; }

        public Tile(int x, int y)
        {
            this.location = new int[2];
            this.containsPlayer = false;
            this.location[0] = x;
            this.location[1] = y;

            this.pictureBox = new PictureBox();
            this.pictureBox.BackColor = Color.Gray;
        }

        public void TogglePlayer()
        {
            if (this.containsPlayer)
            {
                this.containsPlayer = false;
                this.pictureBox.BackColor = Color.Gray;
            }
            else
            {
                this.containsPlayer = true;
                this.pictureBox.BackColor = Color.White;
            }
        }
    }
}
