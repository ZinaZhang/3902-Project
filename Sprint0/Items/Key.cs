﻿using System;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Items
{
    class Key : IItem
    {
        private ItemKeySprite sprite = SpriteFactory.ItemKey;
        private int xAix;
        private int yAix;
        private bool picked;
        private int price;

        public Key(int x, int y)
        {
            xAix = x;
            yAix = y;
            picked = false;
            price = IntegerHolder.Five;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            if (picked == false)
            {
                sprite.Draw(location, false);
            }
        }
       
        public void PickedUp()
        {
            picked = true;
        }

        public Boolean isPickedUp()
        {
            return picked;
        }

        public void ItemReset()
        {
            picked = false;
        }

        public void Update()
        {
            //currently, does not need update
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yAix, 32, 32);
        }
        public int getPrice()
        {
            return price;
        }
    }
}


