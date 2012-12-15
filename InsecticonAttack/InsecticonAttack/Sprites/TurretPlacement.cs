using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    class TurretPlacement : Sprite
    {
        int gridsize = 20;

        public override void Load()
        {
            AddCostume("GreenSquare");
            AddCostume("RedSquare");
            Scale = 0.275f;
        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {

            this.Position = Mouse.Position;
            this.X = ((int)this.X / gridsize) * gridsize;
            this.Y = ((int)this.Y / gridsize) * gridsize;
        }
    }
}
