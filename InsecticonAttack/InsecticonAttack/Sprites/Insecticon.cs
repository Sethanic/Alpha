using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ScratchyXna
{
    /// <summary>
    /// A Start Button Sprite
    /// </summary>
    class Insecticon : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("Insecticon");
            Direction = -180;
            Speed = 0.175f;
        }

        /// <summary>
        /// Update the start button
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
        }
       

        /// <summary>
        /// Wiggle
        /// </summary>
        /// <param name="gameTime"></param>
        private void WiggleAround(GameTime gameTime)
        {
            X = Math.Sin(gameTime.TotalGameTime.TotalSeconds) * 30;
            Y = Math.Cos(gameTime.TotalGameTime.TotalSeconds) * 10;
        }
    }
}
