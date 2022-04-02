using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    private float AInput;
    private float YInput;
    private float LeftInput;
    private float RightInput;
    private float UpInput;
    private float DownInput;
    private float LeftBumperInput;
    private float RightBumperInput;
    private float BInput;

    public bool isButtonPressed { get; set; }
    public float RightBumper { get => RightBumperInput; set => RightBumperInput = value; }
    public float LeftBumper { get => LeftBumperInput; set => LeftBumperInput = value; }
    public float Down { get => DownInput; set => DownInput = value; }
    public float Up { get => UpInput; set => UpInput = value; }
    public float Right { get => RightInput; set => RightInput = value; }
    public float Left { get => LeftInput; set => LeftInput = value; }
    public float Y { get => YInput; set => YInput = value; }
    public float A { get => AInput; set => AInput = value; }
    public float B { get => BInput; set => BInput = value; }

    // Start is called before the first frame update
    public void OnA(InputAction.CallbackContext context)
    {
       AInput = context.ReadValue<float>();
        if (AInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnY(InputAction.CallbackContext context)
    {
        YInput = context.ReadValue<float>();
        if (YInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        LeftInput = context.ReadValue<float>();
        if (LeftInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnRight(InputAction.CallbackContext context)
    {

        RightInput = context.ReadValue<float>();

        if (RightInput > 0)
        {
            isButtonPressed = true;

        }

    }

    public void OnUp(InputAction.CallbackContext context)
    {
        UpInput = context.ReadValue<float>();
        if (UpInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnDown(InputAction.CallbackContext context)
    {
        DownInput = context.ReadValue<float>();
        if (DownInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnLeftBumper(InputAction.CallbackContext context)
    {
        LeftBumperInput = context.ReadValue<float>();
        if (LeftBumperInput > 0)
        {
            isButtonPressed = true;

        }
    }

    public void OnRightBumper(InputAction.CallbackContext context)
    {
        RightBumperInput = context.ReadValue<float>();
        if (RightBumperInput > 0)
        {
            isButtonPressed = true;

        }
    }
    public void OnB(InputAction.CallbackContext context)
    {
        BInput = context.ReadValue<float>();
        if (BInput > 0)
        {
            isButtonPressed = true;

        }
    }
}
