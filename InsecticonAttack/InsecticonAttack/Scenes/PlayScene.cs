using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ScratchyXna
{
    /// <summary>
    /// The Play Scene
    /// </summary>
    class PlayScene : Scene
    {
        TurretPlacement Square;

        /// <summary>
        /// Load happens once when the scene is created
        /// </summary>
        public override void Load()
        {

            {
                // Background 
                Background.AddLayer("PlaySceneBackground");
                Background.ScaleToScreen();
                BackButtonBehaviour = BackButtonBehaviours.Ignore;

                float LeadX = 200;
                float LeadY = 0;
                float dx = 20;
                float dy = 20;

                //BasicTurret Turret1 = new BasicTurret();
                //AddSprite(Turret1);

                //BasicTurret Turret2 = new BasicTurret();
                //AddSprite(Turret2);
                //Turret2.SetPosition(-50.0, 50.0);

                //BasicTurret Turret3 = new BasicTurret();
                //AddSprite(Turret3);
                //Turret3.SetPosition(-50.0, -50.0);

                Square = new TurretPlacement();
                AddSprite(Square);


                Insecticon insecect1 = new Insecticon();
                insecect1.Scale = 0.05f;
                AddSprite(insecect1);
                insecect1.SetPosition(LeadX, LeadY);

                for (int col = 1; col <= 3; col = col + 1)
                {
                    Insecticon insect = new Insecticon();
                    insect.Scale = 0.05f;
                    AddSprite(insect);
                    insect.SetPosition(LeadX + dx * col, LeadY + dy * col);

                    insect = new Insecticon();
                    insect.Scale = 0.05f;
                    AddSprite(insect);
                    insect.SetPosition(LeadX + dx * col, LeadY - dy * col);
                }


            }
        }

        public List<Insecticon> FindInsecticons()
        {
            List<Insecticon> found = new List<Insecticon>();
            foreach (Sprite Insecticon in Sprites.Where(s => s is Insecticon))
            {
                found.Add(Insecticon as Insecticon);


            }
            return found;
        }
    
        /// <summary>
        /// Update happens 30-60 times a second
        /// </summary>
        /// <param name="gameTime">The amount of time since the last update</param>
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {


            if (Mouse.Button1Pressed()) {
                if (isTurretatposition(Square.Position) == false)
                {
                    BasicTurret newTurret = new BasicTurret();
                    AddSprite(newTurret);
                    newTurret.SetPosition(Square.Position);

                }
            }
        }
        public bool isTurretatposition(Vector2 position)
        {
            foreach(Sprite Turret in Sprites.Where(s=>s is Iturret ))
            {
                if (Turret.Position == position){
                    return true;        
                }          }
            return false;
        }
    }
}