using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    class FrontLayerButton : Button
    {
        // Declare an instance variable
        public bool clicked = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="texture">The button texture</param>
        /// <param name="position">The button position</param>
        public FrontLayerButton(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
        }


        /// <summary>
        /// Update clicked
        /// </summary>
        public override void Update()
        {
            clicked = base.clicked;
            base.Update();
        }


        /// <summary>
        /// Event for the button
        /// </summary>
        public override void Effect()
        {
            // Increment the drawable layer
            if (Game1.drawableLayer++ >= Game1.map.layers.Count - 1)
            {
                Game1.map.layers.Add(new Layer(Game1.map.mapWidth, Game1.map.mapHeight, Game1.map.tileWidth, Game1.map.tileHeight, false));
            }


            base.Effect();
        }
    }
}
