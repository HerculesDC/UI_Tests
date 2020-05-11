// GENERATED AUTOMATICALLY FROM 'Assets/Input/CameraControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CameraControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CameraControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CameraControls"",
    ""maps"": [
        {
            ""name"": ""CameraMap"",
            ""id"": ""18822e3b-fcd8-4905-8617-c9c279c69522"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""a23a8e6c-334c-450e-b379-fa36f3d20bcc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8dc03af5-c5b0-44df-8b1a-ed4e252415a1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamepadControls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""70f0d8ee-e4b9-4f2c-8d94-38b9ef4ff43e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6bc05a33-f88a-4b38-b449-6742e3660ea5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardControls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8e32e42f-3f3b-4202-95c3-fa9c08799502"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardControls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""435ca458-a58b-4ac3-b472-5a75999f39a5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardControls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7e45b9d-5a3c-4e60-a86d-0841426ef713"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardControls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardControls"",
            ""bindingGroup"": ""KeyboardControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamepadControls"",
            ""bindingGroup"": ""GamepadControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CameraMap
        m_CameraMap = asset.FindActionMap("CameraMap", throwIfNotFound: true);
        m_CameraMap_Look = m_CameraMap.FindAction("Look", throwIfNotFound: true);
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

    // CameraMap
    private readonly InputActionMap m_CameraMap;
    private ICameraMapActions m_CameraMapActionsCallbackInterface;
    private readonly InputAction m_CameraMap_Look;
    public struct CameraMapActions
    {
        private @CameraControls m_Wrapper;
        public CameraMapActions(@CameraControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_CameraMap_Look;
        public InputActionMap Get() { return m_Wrapper.m_CameraMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMapActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMapActions instance)
        {
            if (m_Wrapper.m_CameraMapActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_CameraMapActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CameraMapActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CameraMapActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_CameraMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public CameraMapActions @CameraMap => new CameraMapActions(this);
    private int m_KeyboardControlsSchemeIndex = -1;
    public InputControlScheme KeyboardControlsScheme
    {
        get
        {
            if (m_KeyboardControlsSchemeIndex == -1) m_KeyboardControlsSchemeIndex = asset.FindControlSchemeIndex("KeyboardControls");
            return asset.controlSchemes[m_KeyboardControlsSchemeIndex];
        }
    }
    private int m_GamepadControlsSchemeIndex = -1;
    public InputControlScheme GamepadControlsScheme
    {
        get
        {
            if (m_GamepadControlsSchemeIndex == -1) m_GamepadControlsSchemeIndex = asset.FindControlSchemeIndex("GamepadControls");
            return asset.controlSchemes[m_GamepadControlsSchemeIndex];
        }
    }
    public interface ICameraMapActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
}
