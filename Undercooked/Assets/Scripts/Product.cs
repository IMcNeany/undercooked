using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : Pickup {

    public List<Item> item_list;
    public Sprite product_sprite;


    public void AddItem(ItemType type)
    {
        for (int i = 0; i < item_list.Count; i++)
        {
            //check for duplicates and that item is prepared
            
        }
    }

    public void RefreshSprite()
    {
        //loop through list and set sprite depending on its contents
    }

    public override void PlaceObject(GameObject obj)
    {
        base.PlaceObject(obj);
    }
}
