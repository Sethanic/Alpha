using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    class BasicTurret : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("BasicTurret");
            Scale = 0.275f;
        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
           
        }
    }

}
