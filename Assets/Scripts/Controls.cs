// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""9026c4aa-8a14-47f6-964b-6e44dc084ec5"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""7bc4f202-4f25-4007-8d10-33011fa12966"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""BlockViewDrag"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""Button"",
                    ""id"": ""906bd9dc-b939-4a5e-aee2-1e5242ed613a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Detector Movement"",
                    ""type"": ""Button"",
                    ""id"": ""f796e78e-6628-43e3-be3b-74315678f913"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Screen Point"",
                    ""type"": ""Value"",
                    ""id"": ""6b714e1f-1297-4037-b161-f800cf0f320c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21009d03-e223-445f-88d4-0cc5984bfccc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fdfaad6-87d6-4e67-831d-ac25c33c0fc0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eac880db-68df-4648-af00-1a2f43050060"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Detector Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12c89776-12ea-4e84-83ad-e51fc367873c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Screen Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Camera = m_Default.FindAction("Camera", throwIfNotFound: true);
        m_Default_CameraMovement = m_Default.FindAction("Camera Movement", throwIfNotFound: true);
        m_Default_DetectorMovement = m_Default.FindAction("Detector Movement", throwIfNotFound: true);
        m_Default_ScreenPoint = m_Default.FindAction("Screen Point", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Camera;
    private readonly InputAction m_Default_CameraMovement;
    private readonly InputAction m_Default_DetectorMovement;
    private readonly InputAction m_Default_ScreenPoint;
    public struct DefaultActions
    {
        private @Controls m_Wrapper;
        public DefaultActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Default_Camera;
        public InputAction @CameraMovement => m_Wrapper.m_Default_CameraMovement;
        public InputAction @DetectorMovement => m_Wrapper.m_Default_DetectorMovement;
        public InputAction @ScreenPoint => m_Wrapper.m_Default_ScreenPoint;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Camera.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCamera;
                @CameraMovement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnCameraMovement;
                @DetectorMovement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDetectorMovement;
                @DetectorMovement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDetectorMovement;
                @DetectorMovement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnDetectorMovement;
                @ScreenPoint.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScreenPoint;
                @ScreenPoint.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScreenPoint;
                @ScreenPoint.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnScreenPoint;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @DetectorMovement.started += instance.OnDetectorMovement;
                @DetectorMovement.performed += instance.OnDetectorMovement;
                @DetectorMovement.canceled += instance.OnDetectorMovement;
                @ScreenPoint.started += instance.OnScreenPoint;
                @ScreenPoint.performed += instance.OnScreenPoint;
                @ScreenPoint.canceled += instance.OnScreenPoint;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnDetectorMovement(InputAction.CallbackContext context);
        void OnScreenPoint(InputAction.CallbackContext context);
    }
}
