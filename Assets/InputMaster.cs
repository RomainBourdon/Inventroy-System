// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6cb3e044-d229-4ba4-9c88-0c4fb862c95f"",
            ""actions"": [
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""9b109947-c40e-4a64-a4ba-b31e697ee7d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""CursorLeft"",
                    ""type"": ""Button"",
                    ""id"": ""20bf138e-e5a0-4a23-8864-b06c1759edf7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""CursorRight"",
                    ""type"": ""Button"",
                    ""id"": ""a4d6ff44-e549-4dad-aede-6f78765c9a76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""CursorUp"",
                    ""type"": ""Button"",
                    ""id"": ""9699cceb-9d2b-4b2a-96e8-d0bb84976f69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""CursorDown"",
                    ""type"": ""Button"",
                    ""id"": ""3d6e4982-0cae-4376-9ae8-d3edf24356e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""RandomiseItems"",
                    ""type"": ""Button"",
                    ""id"": ""024bf9de-b92d-4ab4-9d2e-47714ed8f86a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""ResUp"",
                    ""type"": ""Button"",
                    ""id"": ""1bdbdebc-4580-4f1c-b0ce-3965ec6f079d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""ResDown"",
                    ""type"": ""Button"",
                    ""id"": ""51176a0b-85c3-4b39-9931-82ea9c269eb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Delete"",
                    ""type"": ""Button"",
                    ""id"": ""448a1f98-e9cb-450d-b538-1eacb620fb3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b425a45a-10a5-4a43-8d6c-202317cb51ea"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9da1f21b-775f-44a4-9467-22729b19d16d"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04f76338-4127-42c3-b8b8-bb1b44bf933c"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1542920-26e4-41bd-9c20-67bc24f95061"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5303c978-d664-48db-ae32-b8ea6c0c2082"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebffea63-645d-491e-ad07-f5de7cd93afb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f6fd4da-f715-48d7-ae26-c680ced048ee"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b84c11b4-34c6-4d9e-9240-9b6a840f2350"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a714418f-6641-4cd8-b480-8279858bdeaa"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf1a031b-4702-4de1-a0fa-a537d1f0116f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f66afa78-fbc3-41a1-83c9-2a5549555ec7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4e3bbcb-4da3-44e6-b783-aa9d6af0952c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7d78b32-27d0-4763-ae35-b4a4c0c16aca"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00f35921-8b8a-4e49-abfd-3930707f6d01"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""CursorDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27ca0306-b571-49da-b66c-3959f3537efc"",
                    ""path"": ""<Keyboard>/#(Y)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""RandomiseItems"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdd173e2-03c1-4dc3-b9eb-0260fe99be51"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""RandomiseItems"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cbcdafd-b132-4609-81bf-b08b75b2443d"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""ResUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0ace66a-b158-490b-87cb-9ac55cf5507b"",
                    ""path"": ""<Keyboard>/#(R)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""ResUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58855bc7-2ce0-45a9-8a29-65d4358249a7"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""ResDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b465796-c6c7-4f61-8cab-ffb17fbbbced"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""ResDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de99ad0a-69f7-4cd9-abcd-80f3c61e47dd"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d854997f-7e4f-417e-a9cc-b72a9cdf8521"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox/Keyboard"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox/Keyboard"",
            ""bindingGroup"": ""Xbox/Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PickUp = m_Player.FindAction("PickUp", throwIfNotFound: true);
        m_Player_CursorLeft = m_Player.FindAction("CursorLeft", throwIfNotFound: true);
        m_Player_CursorRight = m_Player.FindAction("CursorRight", throwIfNotFound: true);
        m_Player_CursorUp = m_Player.FindAction("CursorUp", throwIfNotFound: true);
        m_Player_CursorDown = m_Player.FindAction("CursorDown", throwIfNotFound: true);
        m_Player_RandomiseItems = m_Player.FindAction("RandomiseItems", throwIfNotFound: true);
        m_Player_ResUp = m_Player.FindAction("ResUp", throwIfNotFound: true);
        m_Player_ResDown = m_Player.FindAction("ResDown", throwIfNotFound: true);
        m_Player_Delete = m_Player.FindAction("Delete", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_PickUp;
    private readonly InputAction m_Player_CursorLeft;
    private readonly InputAction m_Player_CursorRight;
    private readonly InputAction m_Player_CursorUp;
    private readonly InputAction m_Player_CursorDown;
    private readonly InputAction m_Player_RandomiseItems;
    private readonly InputAction m_Player_ResUp;
    private readonly InputAction m_Player_ResDown;
    private readonly InputAction m_Player_Delete;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @PickUp => m_Wrapper.m_Player_PickUp;
        public InputAction @CursorLeft => m_Wrapper.m_Player_CursorLeft;
        public InputAction @CursorRight => m_Wrapper.m_Player_CursorRight;
        public InputAction @CursorUp => m_Wrapper.m_Player_CursorUp;
        public InputAction @CursorDown => m_Wrapper.m_Player_CursorDown;
        public InputAction @RandomiseItems => m_Wrapper.m_Player_RandomiseItems;
        public InputAction @ResUp => m_Wrapper.m_Player_ResUp;
        public InputAction @ResDown => m_Wrapper.m_Player_ResDown;
        public InputAction @Delete => m_Wrapper.m_Player_Delete;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @PickUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @CursorLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorLeft;
                @CursorLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorLeft;
                @CursorRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorRight;
                @CursorRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorRight;
                @CursorRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorRight;
                @CursorUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorUp;
                @CursorUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorUp;
                @CursorUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorUp;
                @CursorDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorDown;
                @CursorDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorDown;
                @CursorDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCursorDown;
                @RandomiseItems.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRandomiseItems;
                @RandomiseItems.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRandomiseItems;
                @RandomiseItems.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRandomiseItems;
                @ResUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResUp;
                @ResUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResUp;
                @ResUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResUp;
                @ResDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResDown;
                @ResDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResDown;
                @ResDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResDown;
                @Delete.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDelete;
                @Delete.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDelete;
                @Delete.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDelete;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @CursorLeft.started += instance.OnCursorLeft;
                @CursorLeft.performed += instance.OnCursorLeft;
                @CursorLeft.canceled += instance.OnCursorLeft;
                @CursorRight.started += instance.OnCursorRight;
                @CursorRight.performed += instance.OnCursorRight;
                @CursorRight.canceled += instance.OnCursorRight;
                @CursorUp.started += instance.OnCursorUp;
                @CursorUp.performed += instance.OnCursorUp;
                @CursorUp.canceled += instance.OnCursorUp;
                @CursorDown.started += instance.OnCursorDown;
                @CursorDown.performed += instance.OnCursorDown;
                @CursorDown.canceled += instance.OnCursorDown;
                @RandomiseItems.started += instance.OnRandomiseItems;
                @RandomiseItems.performed += instance.OnRandomiseItems;
                @RandomiseItems.canceled += instance.OnRandomiseItems;
                @ResUp.started += instance.OnResUp;
                @ResUp.performed += instance.OnResUp;
                @ResUp.canceled += instance.OnResUp;
                @ResDown.started += instance.OnResDown;
                @ResDown.performed += instance.OnResDown;
                @ResDown.canceled += instance.OnResDown;
                @Delete.started += instance.OnDelete;
                @Delete.performed += instance.OnDelete;
                @Delete.canceled += instance.OnDelete;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_XboxKeyboardSchemeIndex = -1;
    public InputControlScheme XboxKeyboardScheme
    {
        get
        {
            if (m_XboxKeyboardSchemeIndex == -1) m_XboxKeyboardSchemeIndex = asset.FindControlSchemeIndex("Xbox/Keyboard");
            return asset.controlSchemes[m_XboxKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPickUp(InputAction.CallbackContext context);
        void OnCursorLeft(InputAction.CallbackContext context);
        void OnCursorRight(InputAction.CallbackContext context);
        void OnCursorUp(InputAction.CallbackContext context);
        void OnCursorDown(InputAction.CallbackContext context);
        void OnRandomiseItems(InputAction.CallbackContext context);
        void OnResUp(InputAction.CallbackContext context);
        void OnResDown(InputAction.CallbackContext context);
        void OnDelete(InputAction.CallbackContext context);
    }
}
