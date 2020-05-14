using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaChipProj.Tiles
{
    public class Door
    {
        public Color color { get; set; }
        public bool open { get; set; }

        public Door(Color c)
        {
            this.color = c;
            this.open = false;
        }
    }
}
