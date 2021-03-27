// GENERATED AUTOMATICALLY FROM 'Assets/gascontrols.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Gascontrols : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Gascontrols()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""gascontrols"",
    ""maps"": [
        {
            ""name"": ""gasmode"",
            ""id"": ""6a223b55-9959-472b-aa83-1f82a6b48ec4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f7c9dae7-f667-4e68-a543-66da1d64cd47"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5c48fffc-55ae-4528-9acf-e96666087c89"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f767de6-4fa5-470d-aba1-bfb6bb852242"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""616df745-f211-4278-92a5-5d9c6ab4f72a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f84cb269-9d48-45e0-a268-5037b2033b34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0fc42cae-a2a5-425a-bbd5-51c5f81b2833"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gasmode
        m_gasmode = asset.FindActionMap("gasmode", throwIfNotFound: true);
        m_gasmode_Move = m_gasmode.FindAction("Move", throwIfNotFound: true);
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

    // gasmode
    private readonly InputActionMap m_gasmode;
    private IGasmodeActions m_GasmodeActionsCallbackInterface;
    private readonly InputAction m_gasmode_Move;
    public struct GasmodeActions
    {
        private @Gascontrols m_Wrapper;
        public GasmodeActions(@Gascontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_gasmode_Move;
        public InputActionMap Get() { return m_Wrapper.m_gasmode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GasmodeActions set) { return set.Get(); }
        public void SetCallbacks(IGasmodeActions instance)
        {
            if (m_Wrapper.m_GasmodeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GasmodeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GasmodeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GasmodeActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GasmodeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GasmodeActions @gasmode => new GasmodeActions(this);
    public interface IGasmodeActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
