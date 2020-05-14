using AlessiaChipProj.Tiles;
using AlessiaChipProj.Tiles.Items;
using System.Drawing;
using System.Windows.Forms;

namespace AlessiaChipProj
{
    public interface IGameTile
    {
        int[] location { get; set; }
        PictureBox pictureBox { get; set; }
        bool containsChip { get; set; }
        bool walkable { get; set; }
        bool containsKey { get; set; }
        Key key { get; set; }
        bool isExit { get; set; }
        bool isHint { get; set; }
        bool isDoor { get; set; }
        Door door { get; set; }

        void TogglePlayer();
        void AddKey(Color c);
        void AddDoor(Color c);
    }
}