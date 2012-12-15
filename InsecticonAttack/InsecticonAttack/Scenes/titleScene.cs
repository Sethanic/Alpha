using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace ScratchyXna
{
    /// <summary>
    /// The Title Scene
    /// </summary>
    class TitleScene : Scene
    {
        StartButton startButton;

        /// <summary>
        /// Load happens once when the scene is created
        /// </summary>
        public override void Load()
        {

            // Background
            Background.AddLayer("TitleSceneBackground");
            Background.ScaleToScreen();

            // Text
            LoadFont("INATitle");
            Text titleText = new Text
            {
                Value =@"Insecticon
   Attack",
                VerticalAlign = VerticalAlignments.Top,
                Alignment = HorizontalAlignments.Center,
                Scale = 10,
                X = 0,
                Y = 90, Color= Color.LimeGreen
            };
            AddText(titleText);  // Adds the title text object to the scene, so that it will be drawn

            AddSong("BackgroundMusic1");
            PlaySong("BackgroundMusic1", true);

            // Sprites
            startButton = new StartButton();
            AddSprite(startButton);
        }

        /// <summary>
        /// Update happens 30-60 times a second
        /// </summary>
        /// <param name="gameTime">The amount of time since the last update</param>
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            if (Mouse.Button1Down() && startButton.IsTouching(Mouse.Position))
            {
                ShowScene("Play");
            }
        }

    }
}
