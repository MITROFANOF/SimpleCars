// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Test/InputMaster.inputactions'

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
            ""name"": ""Vehicle"",
            ""id"": ""a38aeea3-252b-4064-a86d-1c3cff3b0480"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6c4ae948-e84f-4353-866c-5ccfc62f8e5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Clamp(min=0.1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""PassThrough"",
                    ""id"": ""268d1656-6670-4551-8d87-cceb1660c6b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Clutch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c1bdbbec-a179-4478-befa-10b3f8d99076"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gear Up"",
                    ""type"": ""Button"",
                    ""id"": ""c15a4441-f139-43d9-8abf-a76133bcd854"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gear Down"",
                    ""type"": ""Button"",
                    ""id"": ""4ecd306f-f12b-45f1-89c1-2981b393407d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e7e390f-a215-4623-9077-601cc93b4483"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04bdace9-a094-49f7-b251-043e1a22edf8"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Clutch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c60a4d38-3ba1-4630-90a3-29260ad6d644"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""277e2962-7a55-460d-be2f-c6ddd9d22b6c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Gear Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04976987-be7e-4251-b601-b628677411e0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Gear Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Vehicle
        m_Vehicle = asset.FindActionMap("Vehicle", throwIfNotFound: true);
        m_Vehicle_Accelerate = m_Vehicle.FindAction("Accelerate", throwIfNotFound: true);
        m_Vehicle_Brake = m_Vehicle.FindAction("Brake", throwIfNotFound: true);
        m_Vehicle_Clutch = m_Vehicle.FindAction("Clutch", throwIfNotFound: true);
        m_Vehicle_GearUp = m_Vehicle.FindAction("Gear Up", throwIfNotFound: true);
        m_Vehicle_GearDown = m_Vehicle.FindAction("Gear Down", throwIfNotFound: true);
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

    // Vehicle
    private readonly InputActionMap m_Vehicle;
    private IVehicleActions m_VehicleActionsCallbackInterface;
    private readonly InputAction m_Vehicle_Accelerate;
    private readonly InputAction m_Vehicle_Brake;
    private readonly InputAction m_Vehicle_Clutch;
    private readonly InputAction m_Vehicle_GearUp;
    private readonly InputAction m_Vehicle_GearDown;
    public struct VehicleActions
    {
        private @InputMaster m_Wrapper;
        public VehicleActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Vehicle_Accelerate;
        public InputAction @Brake => m_Wrapper.m_Vehicle_Brake;
        public InputAction @Clutch => m_Wrapper.m_Vehicle_Clutch;
        public InputAction @GearUp => m_Wrapper.m_Vehicle_GearUp;
        public InputAction @GearDown => m_Wrapper.m_Vehicle_GearDown;
        public InputActionMap Get() { return m_Wrapper.m_Vehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleActions instance)
        {
            if (m_Wrapper.m_VehicleActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnAccelerate;
                @Brake.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnBrake;
                @Clutch.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
                @Clutch.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
                @Clutch.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnClutch;
                @GearUp.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearUp;
                @GearUp.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearUp;
                @GearUp.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearUp;
                @GearDown.started -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearDown;
                @GearDown.performed -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearDown;
                @GearDown.canceled -= m_Wrapper.m_VehicleActionsCallbackInterface.OnGearDown;
            }
            m_Wrapper.m_VehicleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Clutch.started += instance.OnClutch;
                @Clutch.performed += instance.OnClutch;
                @Clutch.canceled += instance.OnClutch;
                @GearUp.started += instance.OnGearUp;
                @GearUp.performed += instance.OnGearUp;
                @GearUp.canceled += instance.OnGearUp;
                @GearDown.started += instance.OnGearDown;
                @GearDown.performed += instance.OnGearDown;
                @GearDown.canceled += instance.OnGearDown;
            }
        }
    }
    public VehicleActions @Vehicle => new VehicleActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IVehicleActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnClutch(InputAction.CallbackContext context);
        void OnGearUp(InputAction.CallbackContext context);
        void OnGearDown(InputAction.CallbackContext context);
    }
}
