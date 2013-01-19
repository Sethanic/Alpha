using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ScratchyXna
{
    
    class Bullet : Sprite
    {
        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            AddCostume("Bullet");
            Scale = 0.01f;
        }

        /// <summary>
        /// Update the start button
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            if (this.IsOffScreen())
            {
                Scene.Remove(this);
            }
        }

        /// <summary>
        /// If the mouse is over the button, turn it red
        /// </summary>
        private void ColorOnMOuseHover()
        {
            
        }

         /// <summary>
        /// Wiggle
        /// </summary>
        /// <param name="gameTime"></param>
        //private void WiggleAround(GameTime gameTime)
        //{
           //X = Math.Sin(gameTime.TotalGameTime.TotalSeconds) * 30;
            //Y = Math.Cos(gameTime.TotalGameTime.TotalSeconds) * 10;
        }
    }

