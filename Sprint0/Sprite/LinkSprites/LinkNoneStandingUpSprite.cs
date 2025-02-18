﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.UtilityClass;

namespace Sprint0
{
    public class LinkNoneStandingUpSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Rectangle sourceRec = new Rectangle(69, 11, 16, 16);
        Color myColor = Color.GreenYellow;
        public void Update()
        {

        }
        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }
        public void Draw(Vector2 location, Boolean isDamaged)
        {
            if (isDamaged)
            {
                myColor = Color.Red;
            }
            else
            {
                myColor = Color.GreenYellow;
            }
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, IntegerHolder.FoutyFive, IntegerHolder.FoutyFive), sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
