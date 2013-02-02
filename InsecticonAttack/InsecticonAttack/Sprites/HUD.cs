using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ScratchyXna
{

    class HUD : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("InsecticonAttackHUD");
            Scale = 0.33292f;
            Y = 83.29;
        }

        /// <summary>
        /// Update the start button
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {

        }

    }
}