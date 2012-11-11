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
    class StartButton : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("StartButton");   
        }

        /// <summary>
        /// Update the start button
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            WiggleAround(gameTime);
            ColorOnMOuseHover();
        }

        /// <summary>
        /// If the mouse is over the button, turn it red
        /// </summary>
        private void ColorOnMOuseHover()
        {
            if (IsTouching(Mouse.Position))
            {
                SpriteColor = Color.Red;
            }
            else
            {
                SpriteColor = Color.White;
            }
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
