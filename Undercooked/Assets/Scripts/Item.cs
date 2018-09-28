using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Bun,
    Meat,
    Lettuce,
    Tomato,
    Onion,
    Mushroom,
    Fish,
    Chips
};


public class Item : Pickup {

    public ItemType type;
    public bool prepared = false;
    public Sprite current_sprite;
    public float prepare_timer = 3.0f;

    public Sprite unpreped_sprite;
    public Sprite preped_sprite;

    private void Start()
    {
        current_sprite = GetComponent<SpriteRenderer>().sprite;
    }

    public void SetPrepared()
    {
        prepared = true;
        current_sprite = preped_sprite;
    }

    public void Interact()
    {
        if(!prepared)
        {
            prepare_timer -= 1 * Time.deltaTime;
            if(prepare_timer <= 0.0f)
            {
                SetPrepared();
                prepare_timer = 0.0f;
            }
        }
    }

    public void PlaceItem(GameObject obj)
    {
        
    }

    public override void PlaceObject(GameObject obj)
    {
        base.PlaceObject(obj);

    }
}
