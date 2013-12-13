﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor.GUI
{
    public class CollisionLayerButton : Button
    {
        // Declare an instance variable
        public bool clicked = false;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="texture">The button texture</param>
        /// <param name="position">The button position</param>
        public CollisionLayerButton(Texture2D texture, Vector2 position)
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
            if (Game1.map.layers[Game1.drawableLayer].collidable == false)
            {
                Game1.map.layers[Game1.drawableLayer].collidable = true;
            }
            else
            {
                Game1.map.layers[Game1.drawableLayer].collidable = false;
            }


            base.Effect();
        }
    }
}
