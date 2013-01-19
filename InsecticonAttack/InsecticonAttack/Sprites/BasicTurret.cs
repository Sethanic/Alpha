using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    class BasicTurret : Sprite , Iturret
    {
        BasicTurretBarrel BasicBarrel;

        /// <summary>
        /// Load the sprite
        /// </summary>
        public override void Load()
        {
            BasicBarrel = this.Scene.AddSprite<BasicTurretBarrel>();
            AddCostume("BasicTurret");
            Scale = 0.275f;

            this.Forever(0.3, Think);
        }
        public void Think()
        {
            List<Insecticon>insecticons=(this.Scene as PlayScene).
        }
        public void Shoot()
        {
            // Find nearest insecticon

            // Create a bullet

            // Point bullet in direction of insecticon

            // Set bullet speed
        }


        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
           
        }

        internal void SetPosition(Microsoft.Xna.Framework.Vector2 vector2)
        {
            this.Position = vector2;
            BasicBarrel.Position = vector2;
        }
    }

}
