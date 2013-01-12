using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    class BasicTurretBarrel : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("BasicTurretBarrel");
            Scale = 0.275f;
            Layer = 50;
        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            Rotation = Rotation + (float)gameTime.ElapsedGameTime.TotalSeconds*20;
        }
    }

}
