using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
public class HighlightBox : MonoBehaviour
{
    ItemsStruct items;
    GameObject[] InventorySlots;
    public TextMeshProUGUI itemNameText;
    public Sprite HighlightSprite;
    GameObject currentSlot;
    int currentSlotIndex;
    int currentResIndex;
    bool isPickingUp = false;
    public bool IsPickingUp { get { return isPickingUp; } }

    float PickedUpInput = 0, DeleteInput = 0, RightInput = 0, LeftInput = 0, UpInput = 0, DownInput = 0, LeftBumperInput = 0, RightBumperInput = 0;
    public InputManager input;
    // Start is called before the first frame update

    Vector2[] res = { new Vector2(1280, 720), new Vector2(1920, 1080), new Vector2(3860, 2160) };
    void Start()
    {
        items = GameObject.Find("InventoryMenu").GetComponent<ItemsStruct>();
        if (items != null)
        {

            InventorySlots = items.getInventorySlots();

        }

        foreach (var t in InventorySlots)
        {
            Debug.Log(t.name);
        }

        isPickingUp = false;
        currentResIndex = 0;
        currentSlotIndex = 0;
        currentSlot = InventorySlots[currentSlotIndex];

        GetComponent<Image>().sprite = HighlightSprite;

        Screen.SetResolution((int)res[currentResIndex].x, (int)res[currentResIndex].y, true);

        setInputs();

    }

    private void setInputs()
    {
        PickedUpInput = input.A;
        DeleteInput = input.B;
        RightInput = input.Right;
        LeftInput = input.Left;
        UpInput = input.Up;
        DownInput = input.Down;
        LeftBumperInput = input.LeftBumper;
        RightBumperInput = input.RightBumper;

    }

    // Update is called once per frame
    void Update()
    {
        setInputs();
        currentSlot = InventorySlots[currentSlotIndex];
        transform.position = currentSlot.transform.position;

        if (input.isButtonPressed)
        {
           
           
            if (PickedUpInput > 0)
            {
                if (currentSlot.activeInHierarchy == true)
                {

                    if (isPickingUp == false)
                    {
                        GetComponent<Image>().sprite = currentSlot.GetComponent<Image>().sprite;
                        currentSlot.GetComponent<Image>().sprite = null;
                        currentSlot.SetActive(false);
                        isPickingUp = true;
                    }
                    else
                    {
                        Sprite temp = GetComponent<Image>().sprite;
                        GetComponent<Image>().sprite = currentSlot.GetComponent<Image>().sprite;
                        currentSlot.GetComponent<Image>().sprite = temp;

                    }
                    itemNameText.text = GetComponent<Image>().sprite.name;
                }
                else
                {
                    if (isPickingUp == true)
                    {
                        currentSlot.SetActive(true);
                        currentSlot.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                        GetComponent<Image>().sprite = HighlightSprite;
                        isPickingUp = false;
                        itemNameText.text = " ";
                    }
                }


                input.isButtonPressed = false;
            }
            if (DeleteInput > 0)
            {
                if (IsPickingUp == true)
                {
                    isPickingUp = false;
                    GetComponent<Image>().sprite = HighlightSprite;

                    itemNameText.text = " ";

                    input.isButtonPressed = false;
                }

            }
            if (UpInput > 0)
            {
                if (currentSlotIndex - 6 >= 0)
                {
                    currentSlotIndex -= 6;
                }
                input.isButtonPressed = false;
            }
            if (DownInput > 0)
            {
                if (currentSlotIndex + 6 < InventorySlots.Length)
                {
                    currentSlotIndex += 6;

                }
                input.isButtonPressed = false;
            }
            if (RightInput > 0)
            {
                if (currentSlotIndex < InventorySlots.Length - 1)
                {
                    currentSlotIndex++;
                }
                input.isButtonPressed = false;
            }
            if (LeftInput > 0)
            {
                if (currentSlotIndex > 0)
                {
                    currentSlotIndex--;
                }

                input.isButtonPressed = false;
            }
            if (LeftBumperInput > 0)
            {

                if (currentResIndex > 0)
                {
                    currentResIndex--;
                    Screen.SetResolution((int)res[currentResIndex].x, (int)res[currentResIndex].y, false);
                }

                input.isButtonPressed = false;
            }
            if (RightBumperInput > 0)
            {

                if (currentResIndex < res.Length - 1)
                {
                    currentResIndex++;
                    Screen.SetResolution((int)res[currentResIndex].x, (int)res[currentResIndex].y, false);
                }
                input.isButtonPressed = false;

            }
        }
    }

}
