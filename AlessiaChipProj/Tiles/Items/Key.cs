using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaChipProj.Tiles.Items
{
    public class Key
    {
        public Color color { get; set; }
        public bool collected { get; set; }

        public Key(Color c)
        {
            this.color = c;
            this.collected = false;
        }
    }
}
