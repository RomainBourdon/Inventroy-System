using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class FillInventory : MonoBehaviour
{
    ItemsStruct items;
    GameObject[] InventorySlots;
    Sprite[] sprites;
    float RandomisedInput = 0;
    public HighlightBox cursor;
    public InputManager input;

    // Start is called before the first frame update
    void Start()
    {
        items = GameObject.Find("InventoryMenu").GetComponent<ItemsStruct>();
        if (items != null)
        {
            sprites = items.getItemsList();
            InventorySlots = items.getInventorySlots();

            RandomiseInventory();
        }

        RandomisedInput = input.Y;

    }

    private void RandomiseInventory()
    {
        int rndNum = 0;
        for (int i = 0; i < 5; i++)
        {
            rndNum = Random.Range(0, InventorySlots.Length);
            InventorySlots[rndNum].GetComponent<Image>().sprite = sprites[Random.Range(0, sprites.Length)];
            if(InventorySlots[rndNum].activeInHierarchy == false)
            {
                InventorySlots[rndNum].SetActive(true);
            }
        }

        for (int i = 0; i < InventorySlots.Length; i++)
        {
            if (InventorySlots[i].GetComponent<Image>().sprite == null)
            {
                InventorySlots[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        RandomisedInput = input.Y;

        if (input.isButtonPressed == true)
        {
                if (RandomisedInput > 0)
                {
                    for (int i = 0; i < InventorySlots.Length; i++)
                    {
                        InventorySlots[i].GetComponent<Image>().sprite = null;
                        InventorySlots[i].SetActive(false);
                    }
                    RandomiseInventory();
                input.isButtonPressed = false;
            }
            
        }
    }
}
