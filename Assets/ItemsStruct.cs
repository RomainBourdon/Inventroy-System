using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemsStruct : MonoBehaviour
{
    public GameObject[] InventorySlots;
    public Sprite[] sprites;

   public Sprite[] getItemsList()
    {
        var spritesObject = Resources.LoadAll("Sprites16x16", typeof(Sprite)).Cast<Sprite>().ToArray();

        return spritesObject;
    }

    public GameObject[] getInventorySlots()
    {
        return InventorySlots;            
    }
}
