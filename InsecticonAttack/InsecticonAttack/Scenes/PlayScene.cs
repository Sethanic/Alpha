using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchyXna
{
    /// <summary>
    /// The Play Scene
    /// </summary>
    class PlayScene : Scene
    {
        /// <summary>
        /// Load happens once when the scene is created
        /// </summary>
        public override void Load()
        {
            // Background
            Background.AddLayer("PlaySceneBackground");
            Background.ScaleToScreen();

            // Text
            LoadFont("QuartzMS");
            Text titleText = new Text
            {
                Value = "                           Play"
            };
            AddText(titleText);  // Adds the title text object to the scene, so that it will be drawn
        }

        /// <summary>
        /// Update happens 30-60 times a second
        /// </summary>
        /// <param name="gameTime">The amount of time since the last update</param>
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            
        }
    }
}
