using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    class BasicTurretBarrel : Sprite
    {
        public float TargetRotation;
        public float TurretTurnSpeed = 100;
        public bool HaveTarget = false;
        public bool GunLoaded = true;

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
            //Rotation = Rotation + (float)gameTime.ElapsedGameTime.TotalSeconds*20;
            if (Rotation < TargetRotation - 5)
            {
                Rotation += (float)gameTime.ElapsedGameTime.TotalSeconds * TurretTurnSpeed;
            }
            else if (Rotation > TargetRotation + 5)
            {
                Rotation -= (float)gameTime.ElapsedGameTime.TotalSeconds * TurretTurnSpeed;
            }
            else
            {
                if (HaveTarget)
                {
                    if (GunLoaded)
                    {
                        Shoot();
                    }
                }
            }
        }

        
        

        public void Shoot()
        {
            {
                Bullet bullet = new Bullet();
                bullet.Position = this.Position;
                bullet.Direction = 360 - this.Rotation;
                bullet.Speed = 1;
                Scene.AddSprite(bullet);
                GunLoaded = false;
            }
        }
    }
}