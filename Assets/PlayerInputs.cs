//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerI"",
            ""id"": ""bd89e612-e54a-45bc-836e-d0660e298083"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""07c338ac-0e55-48c8-909e-742dff6d0269"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a9e6dc4a-b852-4cc6-a5fe-8445c3adf8a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""af157b0f-4d33-4c89-b165-15fa08da97d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AlternateInteract"",
                    ""type"": ""Button"",
                    ""id"": ""e4f54829-df9f-4e20-8e26-0f48faf1c083"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""97cd3822-8317-48d3-82db-c9d31542410a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9e714b2c-c3a8-480c-88b7-5ee44d9772b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e080d337-d4bf-4960-a6f4-6b0442927f09"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f905c06b-214f-4ee7-9d1d-a7b44fc91d45"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c5d4c26e-0aef-46cf-b9f4-03d00456608b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b04bfbc-d8fa-4691-9544-7a165d6373b3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f2c659b0-eddf-41c4-9b73-6418568e25e5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76cfd237-a31a-4461-9438-5e580ea711c5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d545ff81-80d2-4778-9fa5-94da4fb14271"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternateInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd793b1f-de62-4f64-aca0-b4c97f52ab1d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerI
        m_PlayerI = asset.FindActionMap("PlayerI", throwIfNotFound: true);
        m_PlayerI_Movement = m_PlayerI.FindAction("Movement", throwIfNotFound: true);
        m_PlayerI_Jump = m_PlayerI.FindAction("Jump", throwIfNotFound: true);
        m_PlayerI_Interact = m_PlayerI.FindAction("Interact", throwIfNotFound: true);
        m_PlayerI_AlternateInteract = m_PlayerI.FindAction("AlternateInteract", throwIfNotFound: true);
        m_PlayerI_Sprint = m_PlayerI.FindAction("Sprint", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerI
    private readonly InputActionMap m_PlayerI;
    private List<IPlayerIActions> m_PlayerIActionsCallbackInterfaces = new List<IPlayerIActions>();
    private readonly InputAction m_PlayerI_Movement;
    private readonly InputAction m_PlayerI_Jump;
    private readonly InputAction m_PlayerI_Interact;
    private readonly InputAction m_PlayerI_AlternateInteract;
    private readonly InputAction m_PlayerI_Sprint;
    public struct PlayerIActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerIActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerI_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerI_Jump;
        public InputAction @Interact => m_Wrapper.m_PlayerI_Interact;
        public InputAction @AlternateInteract => m_Wrapper.m_PlayerI_AlternateInteract;
        public InputAction @Sprint => m_Wrapper.m_PlayerI_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_PlayerI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerIActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerIActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerIActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @AlternateInteract.started += instance.OnAlternateInteract;
            @AlternateInteract.performed += instance.OnAlternateInteract;
            @AlternateInteract.canceled += instance.OnAlternateInteract;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
        }

        private void UnregisterCallbacks(IPlayerIActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @AlternateInteract.started -= instance.OnAlternateInteract;
            @AlternateInteract.performed -= instance.OnAlternateInteract;
            @AlternateInteract.canceled -= instance.OnAlternateInteract;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
        }

        public void RemoveCallbacks(IPlayerIActions instance)
        {
            if (m_Wrapper.m_PlayerIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerIActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerIActions @PlayerI => new PlayerIActions(this);
    public interface IPlayerIActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAlternateInteract(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
