//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Module/PlayerSpawner/Player/PlayerInput/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""_PlayerMapInput"",
            ""id"": ""8a6525dd-02b5-4d46-9fa7-35d82248491a"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""4f506b7b-68c7-4f1f-9210-0e109d75bf21"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""rotate"",
                    ""type"": ""Value"",
                    ""id"": ""66dcbaed-b1a6-4810-99a8-c6374700d252"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""af8bb017-8653-4420-bd35-247d2388716f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""bomb"",
                    ""type"": ""Button"",
                    ""id"": ""443b4f19-e638-4088-8b86-04ecc6014276"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""c2a187be-db86-4588-be1c-43e65543192c"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c0d807a9-20e3-4939-8fd2-cf07eb17f22a"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""beaf2355-a340-4e9f-b466-fbae70d0d0f7"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""af3d7a54-929e-4515-aee0-c81f02dacf17"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""1531e87d-199e-404e-acca-fecd0bb56bcd"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""857aa7b9-6f34-43ab-b0f3-dff3f55db76b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""083eab23-3e4b-4f7e-8851-67ff5547db80"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4d286668-a4cb-41e3-ae44-38b9c4457d5e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""1e9b3e8e-e99a-480d-80bc-842411fde350"",
                    ""path"": ""<Keyboard>/#(Q)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""9b921b84-a742-49ee-9b26-9c23e1c9bace"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""_PlayerMapInput1"",
            ""id"": ""da203755-315c-4f05-9dc2-fdfd9b269792"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""7a52ca3c-2b86-40f7-b282-e48f60cffd31"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""rotate"",
                    ""type"": ""Value"",
                    ""id"": ""d7476256-daec-4a27-b70d-c205bbaae7a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""53ae4807-bc71-401a-963f-72aaba02baad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""bomb"",
                    ""type"": ""Button"",
                    ""id"": ""bbe4ae80-a527-49c0-8dbd-73022aaaee70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""dd7d908e-2c0e-453e-b443-2708bcc43aea"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1e4f5d87-48f0-4b04-bbf9-3b897c1ebe9c"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c35fed88-f8f6-4423-85c5-a35e99053f47"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""10bbbc15-930c-4a4a-9048-3d626d35eea2"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""f839680f-8f50-490b-a528-eba776f7d11c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4585f991-c1f5-4dfb-b212-2fc26604a7c1"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""3b3f6016-3885-4371-8a0d-5b456d3bd387"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""da77ee73-8f89-4cb6-8e37-3e708dab7432"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d13880ec-44c2-44b0-bac7-afea2536ebb5"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5c16b09-ed8a-4181-9413-b50a53fc6beb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // _PlayerMapInput
        m__PlayerMapInput = asset.FindActionMap("_PlayerMapInput", throwIfNotFound: true);
        m__PlayerMapInput_move = m__PlayerMapInput.FindAction("move", throwIfNotFound: true);
        m__PlayerMapInput_rotate = m__PlayerMapInput.FindAction("rotate", throwIfNotFound: true);
        m__PlayerMapInput_attack = m__PlayerMapInput.FindAction("attack", throwIfNotFound: true);
        m__PlayerMapInput_bomb = m__PlayerMapInput.FindAction("bomb", throwIfNotFound: true);
        // _PlayerMapInput1
        m__PlayerMapInput1 = asset.FindActionMap("_PlayerMapInput1", throwIfNotFound: true);
        m__PlayerMapInput1_move = m__PlayerMapInput1.FindAction("move", throwIfNotFound: true);
        m__PlayerMapInput1_rotate = m__PlayerMapInput1.FindAction("rotate", throwIfNotFound: true);
        m__PlayerMapInput1_attack = m__PlayerMapInput1.FindAction("attack", throwIfNotFound: true);
        m__PlayerMapInput1_bomb = m__PlayerMapInput1.FindAction("bomb", throwIfNotFound: true);
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

    // _PlayerMapInput
    private readonly InputActionMap m__PlayerMapInput;
    private I_PlayerMapInputActions m__PlayerMapInputActionsCallbackInterface;
    private readonly InputAction m__PlayerMapInput_move;
    private readonly InputAction m__PlayerMapInput_rotate;
    private readonly InputAction m__PlayerMapInput_attack;
    private readonly InputAction m__PlayerMapInput_bomb;
    public struct _PlayerMapInputActions
    {
        private @PlayerInput m_Wrapper;
        public _PlayerMapInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m__PlayerMapInput_move;
        public InputAction @rotate => m_Wrapper.m__PlayerMapInput_rotate;
        public InputAction @attack => m_Wrapper.m__PlayerMapInput_attack;
        public InputAction @bomb => m_Wrapper.m__PlayerMapInput_bomb;
        public InputActionMap Get() { return m_Wrapper.m__PlayerMapInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_PlayerMapInputActions set) { return set.Get(); }
        public void SetCallbacks(I_PlayerMapInputActions instance)
        {
            if (m_Wrapper.m__PlayerMapInputActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnMove;
                @rotate.started -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnRotate;
                @rotate.performed -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnRotate;
                @rotate.canceled -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnRotate;
                @attack.started -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnAttack;
                @attack.performed -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnAttack;
                @attack.canceled -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnAttack;
                @bomb.started -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnBomb;
                @bomb.performed -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnBomb;
                @bomb.canceled -= m_Wrapper.m__PlayerMapInputActionsCallbackInterface.OnBomb;
            }
            m_Wrapper.m__PlayerMapInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @rotate.started += instance.OnRotate;
                @rotate.performed += instance.OnRotate;
                @rotate.canceled += instance.OnRotate;
                @attack.started += instance.OnAttack;
                @attack.performed += instance.OnAttack;
                @attack.canceled += instance.OnAttack;
                @bomb.started += instance.OnBomb;
                @bomb.performed += instance.OnBomb;
                @bomb.canceled += instance.OnBomb;
            }
        }
    }
    public _PlayerMapInputActions @_PlayerMapInput => new _PlayerMapInputActions(this);

    // _PlayerMapInput1
    private readonly InputActionMap m__PlayerMapInput1;
    private I_PlayerMapInput1Actions m__PlayerMapInput1ActionsCallbackInterface;
    private readonly InputAction m__PlayerMapInput1_move;
    private readonly InputAction m__PlayerMapInput1_rotate;
    private readonly InputAction m__PlayerMapInput1_attack;
    private readonly InputAction m__PlayerMapInput1_bomb;
    public struct _PlayerMapInput1Actions
    {
        private @PlayerInput m_Wrapper;
        public _PlayerMapInput1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m__PlayerMapInput1_move;
        public InputAction @rotate => m_Wrapper.m__PlayerMapInput1_rotate;
        public InputAction @attack => m_Wrapper.m__PlayerMapInput1_attack;
        public InputAction @bomb => m_Wrapper.m__PlayerMapInput1_bomb;
        public InputActionMap Get() { return m_Wrapper.m__PlayerMapInput1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_PlayerMapInput1Actions set) { return set.Get(); }
        public void SetCallbacks(I_PlayerMapInput1Actions instance)
        {
            if (m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnMove;
                @rotate.started -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnRotate;
                @rotate.performed -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnRotate;
                @rotate.canceled -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnRotate;
                @attack.started -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnAttack;
                @attack.performed -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnAttack;
                @attack.canceled -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnAttack;
                @bomb.started -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnBomb;
                @bomb.performed -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnBomb;
                @bomb.canceled -= m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface.OnBomb;
            }
            m_Wrapper.m__PlayerMapInput1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @rotate.started += instance.OnRotate;
                @rotate.performed += instance.OnRotate;
                @rotate.canceled += instance.OnRotate;
                @attack.started += instance.OnAttack;
                @attack.performed += instance.OnAttack;
                @attack.canceled += instance.OnAttack;
                @bomb.started += instance.OnBomb;
                @bomb.performed += instance.OnBomb;
                @bomb.canceled += instance.OnBomb;
            }
        }
    }
    public _PlayerMapInput1Actions @_PlayerMapInput1 => new _PlayerMapInput1Actions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface I_PlayerMapInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnBomb(InputAction.CallbackContext context);
    }
    public interface I_PlayerMapInput1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnBomb(InputAction.CallbackContext context);
    }
}
