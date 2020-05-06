using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlessiaChipProj.Tiles;
using AlessiaChipProj.Tiles.Items;

namespace AlessiaChipProj
{
    class Tile : IGameTile
    {
        // Properties
        public PictureBox pictureBox { get; set; }
        public bool containsPlayer { get; set; }
        public Key key { get; set; }
        public Door door { get; set; }
        public int[] location { get; set; }

        // Constructor
        public Tile(int x, int y)
        {
            this.location = new int[2];
            this.containsPlayer = false;
            this.location[0] = x;
            this.location[1] = y;

            this.pictureBox = new PictureBox();
            this.pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox.BackgroundImage = Resources.Block;
        }

        // Getters and setters
        private bool _containsChip = false;
        public bool containsChip
        {
            get { return _containsChip; }
            set
            {
                this._containsChip = value;
                if (this._containsChip) { this.pictureBox.BackgroundImage = Resources.Chip; }
            }
        }

        private bool _walkable = true;
        public bool walkable
        {
            get { return _walkable; }
            set
            {
                this._walkable = value;
                if (!this._walkable) { this.pictureBox.BackgroundImage = Resources.Wall; }
            }
        }

        private bool _containsKey = false;
        public bool containsKey
        {
            get { return _containsKey; }
            set
            {
                this._containsKey = value;
                if (this._containsKey)
                {
                    if(this.key.color == Color.Red && this._containsKey) { this.pictureBox.BackgroundImage = Resources.RedDoor; }
                }
            }
        }

        private bool _isExit = false;
        public bool isExit
        {
            get { return _isExit; }
            set
            {
                this._isExit = value;
                if (this._isExit) { this.pictureBox.BackgroundImage = Resources.ExitBlock; }
            }
        }

        private bool _isDoor = false;
        public bool isDoor
        {
            get { return _isDoor; }
            set
            {
                this._isDoor = value;
                if (this._isDoor && this.door.color == Color.Red) { this.pictureBox.BackgroundImage = Resources.RedDoor; }
                if (this._isDoor && this.door.color == Color.Yellow) { this.pictureBox.BackgroundImage = Resources.YellowDoor; }
                if (this._isDoor && this.door.color == Color.Yellow) { this.pictureBox.BackgroundImage = Resources.BlueDoor; }
            }
        }

        private bool _isHint = false;
        public bool isHint
        {
            get { return _isHint; }
            set
            {
                this._isHint = value;
                if (this._isHint) { this.pictureBox.BackgroundImage = Resources.HintBlock; }
            }
        }

        // Methods
        public void AddKey(Color c)
        {
            this.key = new Key(c);
            this.containsKey = true;
        }

        public void AddDoor(Color c)
        {
            this.door = new Door(c);
            this.isDoor = true;
        }

        public void TogglePlayer()
        {
            if (this.containsPlayer)
            {
                this.containsPlayer = false;
                if (this.isExit) { this.pictureBox.BackgroundImage = Resources.ExitBlock; }
                else if (this.isHint) { this.pictureBox.BackgroundImage = Resources.HintBlock; }
                else { this.pictureBox.BackgroundImage = Resources.Block; }
            }
            else
            {
                this.containsPlayer = true;
                this.pictureBox.BackgroundImage = null;
            }
        }
    }
}
