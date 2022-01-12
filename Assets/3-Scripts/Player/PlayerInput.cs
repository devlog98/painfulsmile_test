// GENERATED AUTOMATICALLY FROM 'Assets/3-Scripts/Player/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""90c6d38e-744d-4f7d-9f91-0dc2e19c82ed"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1ae47816-eff0-4341-8e40-34ba5e32f2bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d72edf3-9abc-4d28-a776-41491ea01913"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot Forward"",
                    ""type"": ""Button"",
                    ""id"": ""2bd984a0-37f2-4c5e-a74e-c10d6e98d698"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot Sideways"",
                    ""type"": ""Button"",
                    ""id"": ""22cc9db8-1950-4d81-8b5b-da765a33d9b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1a092c30-91d4-4078-b3e4-f7ec51381c49"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dc634606-8858-4ad9-9975-9a1bff90043d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e5128bc4-2bd7-437d-918c-b3a054342d7b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0197c1e0-a9e5-4be9-ad3a-19f609ba09ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e4a88fed-59d8-44e9-9651-99ecf109df03"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""75d92b59-2da8-4290-ae91-0174f81d5bfd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08b3a5ef-b338-4b18-b431-9d6a062da46a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bbc8bbd-c2cd-4355-aba9-a82f62ff8e2b"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3afff04-72eb-4db5-823d-a9efa5c00259"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6332f52-8cc5-4c89-89eb-7cb951b85526"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71a386b6-6f13-4a75-9231-da4757eb88b9"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Move = m_PlayerController.FindAction("Move", throwIfNotFound: true);
        m_PlayerController_Rotate = m_PlayerController.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerController_ShootForward = m_PlayerController.FindAction("Shoot Forward", throwIfNotFound: true);
        m_PlayerController_ShootSideways = m_PlayerController.FindAction("Shoot Sideways", throwIfNotFound: true);
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

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Move;
    private readonly InputAction m_PlayerController_Rotate;
    private readonly InputAction m_PlayerController_ShootForward;
    private readonly InputAction m_PlayerController_ShootSideways;
    public struct PlayerControllerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerController_Move;
        public InputAction @Rotate => m_Wrapper.m_PlayerController_Rotate;
        public InputAction @ShootForward => m_Wrapper.m_PlayerController_ShootForward;
        public InputAction @ShootSideways => m_Wrapper.m_PlayerController_ShootSideways;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnRotate;
                @ShootForward.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootForward;
                @ShootForward.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootForward;
                @ShootForward.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootForward;
                @ShootSideways.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootSideways;
                @ShootSideways.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootSideways;
                @ShootSideways.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnShootSideways;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ShootForward.started += instance.OnShootForward;
                @ShootForward.performed += instance.OnShootForward;
                @ShootForward.canceled += instance.OnShootForward;
                @ShootSideways.started += instance.OnShootSideways;
                @ShootSideways.performed += instance.OnShootSideways;
                @ShootSideways.canceled += instance.OnShootSideways;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    public interface IPlayerControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShootForward(InputAction.CallbackContext context);
        void OnShootSideways(InputAction.CallbackContext context);
    }
}
