using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ScratchyXna
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class InsecticonAttack : ScratchyXnaGame
    {
        public static InsecticonAttack Game;
        public InsecticonAttack()
        {
            Game = this;
        }
        public override void LoadScenes()
        {
            this.
            AddScene<TitleScene>();
            AddScene<PlayScene>();
        }

        
    }
}
