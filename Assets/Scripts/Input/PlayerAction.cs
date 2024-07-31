//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Input/PlayerAction.inputactions
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

public partial class @PlayerAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""MovementInput"",
            ""id"": ""bae35015-3f09-49ba-b1c8-028519a364df"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Button"",
                    ""id"": ""931a8a74-72c7-46d2-9349-4a4a2c310a17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rudder"",
                    ""type"": ""Button"",
                    ""id"": ""0898806b-226d-4112-b2c3-597ad1b980cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5f0ec2c0-eb74-4b1f-82c3-27a65cbad1b1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8f7bd41-c710-4719-8ca7-250148b459c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""de97c017-00b5-4e63-b3ac-7b1472337885"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""986014ad-c1a5-4596-919b-dd99a8f3d0e7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9b552739-acd5-47e9-9005-4ad0914357b4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7764c5ca-6e20-4137-9d55-095e6b2f6ffb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ActionInput"",
            ""id"": ""6fa83146-ecdc-46b4-abdd-bd2156e7fa34"",
            ""actions"": [
                {
                    ""name"": ""Modular1"",
                    ""type"": ""Button"",
                    ""id"": ""bdca147e-4a6a-4ba5-80d5-cb907e56da14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Modular2"",
                    ""type"": ""Button"",
                    ""id"": ""42a39e6f-dd47-4a1c-855a-12412874b940"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Modular3"",
                    ""type"": ""Button"",
                    ""id"": ""222d28b9-7917-429f-a653-268d69d61058"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Modular4"",
                    ""type"": ""Button"",
                    ""id"": ""e49fc008-9e1a-440d-aae9-c5656cc11923"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Modular5"",
                    ""type"": ""Button"",
                    ""id"": ""0384c9ab-7e3e-46e4-b45e-964ed01328ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Modular6"",
                    ""type"": ""Button"",
                    ""id"": ""b36ac23b-1f9f-4ea3-9dc5-8787d34c8ec1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""fbb200ce-4ca2-49bc-b1a5-3a28dba228d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""708905c8-e4d7-4674-b8ff-fff276c4a30c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a9f61035-c737-4c63-a368-58cd6452f104"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbad300d-8ee4-4f77-a1f9-9049a293d8e6"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63ce6586-f7ff-415c-9852-488d4d750cb8"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e698e88e-55ab-45fc-a2df-68510006eb68"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e286f5b2-3e5a-49cd-a5d5-e39ceb83be86"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""234df7d4-1fa6-44f9-9c5e-1d5ed418dba3"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Modular6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""880253e6-d817-46a2-94fe-51dbf562e24f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""040a3d95-4530-4a92-90d9-c3c2e2a1f9aa"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MovementInput
        m_MovementInput = asset.FindActionMap("MovementInput", throwIfNotFound: true);
        m_MovementInput_Throttle = m_MovementInput.FindAction("Throttle", throwIfNotFound: true);
        m_MovementInput_Rudder = m_MovementInput.FindAction("Rudder", throwIfNotFound: true);
        // ActionInput
        m_ActionInput = asset.FindActionMap("ActionInput", throwIfNotFound: true);
        m_ActionInput_Modular1 = m_ActionInput.FindAction("Modular1", throwIfNotFound: true);
        m_ActionInput_Modular2 = m_ActionInput.FindAction("Modular2", throwIfNotFound: true);
        m_ActionInput_Modular3 = m_ActionInput.FindAction("Modular3", throwIfNotFound: true);
        m_ActionInput_Modular4 = m_ActionInput.FindAction("Modular4", throwIfNotFound: true);
        m_ActionInput_Modular5 = m_ActionInput.FindAction("Modular5", throwIfNotFound: true);
        m_ActionInput_Modular6 = m_ActionInput.FindAction("Modular6", throwIfNotFound: true);
        m_ActionInput_Confirm = m_ActionInput.FindAction("Confirm", throwIfNotFound: true);
        m_ActionInput_Cancel = m_ActionInput.FindAction("Cancel", throwIfNotFound: true);
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

    // MovementInput
    private readonly InputActionMap m_MovementInput;
    private List<IMovementInputActions> m_MovementInputActionsCallbackInterfaces = new List<IMovementInputActions>();
    private readonly InputAction m_MovementInput_Throttle;
    private readonly InputAction m_MovementInput_Rudder;
    public struct MovementInputActions
    {
        private @PlayerAction m_Wrapper;
        public MovementInputActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_MovementInput_Throttle;
        public InputAction @Rudder => m_Wrapper.m_MovementInput_Rudder;
        public InputActionMap Get() { return m_Wrapper.m_MovementInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementInputActions set) { return set.Get(); }
        public void AddCallbacks(IMovementInputActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementInputActionsCallbackInterfaces.Add(instance);
            @Throttle.started += instance.OnThrottle;
            @Throttle.performed += instance.OnThrottle;
            @Throttle.canceled += instance.OnThrottle;
            @Rudder.started += instance.OnRudder;
            @Rudder.performed += instance.OnRudder;
            @Rudder.canceled += instance.OnRudder;
        }

        private void UnregisterCallbacks(IMovementInputActions instance)
        {
            @Throttle.started -= instance.OnThrottle;
            @Throttle.performed -= instance.OnThrottle;
            @Throttle.canceled -= instance.OnThrottle;
            @Rudder.started -= instance.OnRudder;
            @Rudder.performed -= instance.OnRudder;
            @Rudder.canceled -= instance.OnRudder;
        }

        public void RemoveCallbacks(IMovementInputActions instance)
        {
            if (m_Wrapper.m_MovementInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementInputActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementInputActions @MovementInput => new MovementInputActions(this);

    // ActionInput
    private readonly InputActionMap m_ActionInput;
    private List<IActionInputActions> m_ActionInputActionsCallbackInterfaces = new List<IActionInputActions>();
    private readonly InputAction m_ActionInput_Modular1;
    private readonly InputAction m_ActionInput_Modular2;
    private readonly InputAction m_ActionInput_Modular3;
    private readonly InputAction m_ActionInput_Modular4;
    private readonly InputAction m_ActionInput_Modular5;
    private readonly InputAction m_ActionInput_Modular6;
    private readonly InputAction m_ActionInput_Confirm;
    private readonly InputAction m_ActionInput_Cancel;
    public struct ActionInputActions
    {
        private @PlayerAction m_Wrapper;
        public ActionInputActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Modular1 => m_Wrapper.m_ActionInput_Modular1;
        public InputAction @Modular2 => m_Wrapper.m_ActionInput_Modular2;
        public InputAction @Modular3 => m_Wrapper.m_ActionInput_Modular3;
        public InputAction @Modular4 => m_Wrapper.m_ActionInput_Modular4;
        public InputAction @Modular5 => m_Wrapper.m_ActionInput_Modular5;
        public InputAction @Modular6 => m_Wrapper.m_ActionInput_Modular6;
        public InputAction @Confirm => m_Wrapper.m_ActionInput_Confirm;
        public InputAction @Cancel => m_Wrapper.m_ActionInput_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_ActionInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionInputActions set) { return set.Get(); }
        public void AddCallbacks(IActionInputActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionInputActionsCallbackInterfaces.Add(instance);
            @Modular1.started += instance.OnModular1;
            @Modular1.performed += instance.OnModular1;
            @Modular1.canceled += instance.OnModular1;
            @Modular2.started += instance.OnModular2;
            @Modular2.performed += instance.OnModular2;
            @Modular2.canceled += instance.OnModular2;
            @Modular3.started += instance.OnModular3;
            @Modular3.performed += instance.OnModular3;
            @Modular3.canceled += instance.OnModular3;
            @Modular4.started += instance.OnModular4;
            @Modular4.performed += instance.OnModular4;
            @Modular4.canceled += instance.OnModular4;
            @Modular5.started += instance.OnModular5;
            @Modular5.performed += instance.OnModular5;
            @Modular5.canceled += instance.OnModular5;
            @Modular6.started += instance.OnModular6;
            @Modular6.performed += instance.OnModular6;
            @Modular6.canceled += instance.OnModular6;
            @Confirm.started += instance.OnConfirm;
            @Confirm.performed += instance.OnConfirm;
            @Confirm.canceled += instance.OnConfirm;
            @Cancel.started += instance.OnCancel;
            @Cancel.performed += instance.OnCancel;
            @Cancel.canceled += instance.OnCancel;
        }

        private void UnregisterCallbacks(IActionInputActions instance)
        {
            @Modular1.started -= instance.OnModular1;
            @Modular1.performed -= instance.OnModular1;
            @Modular1.canceled -= instance.OnModular1;
            @Modular2.started -= instance.OnModular2;
            @Modular2.performed -= instance.OnModular2;
            @Modular2.canceled -= instance.OnModular2;
            @Modular3.started -= instance.OnModular3;
            @Modular3.performed -= instance.OnModular3;
            @Modular3.canceled -= instance.OnModular3;
            @Modular4.started -= instance.OnModular4;
            @Modular4.performed -= instance.OnModular4;
            @Modular4.canceled -= instance.OnModular4;
            @Modular5.started -= instance.OnModular5;
            @Modular5.performed -= instance.OnModular5;
            @Modular5.canceled -= instance.OnModular5;
            @Modular6.started -= instance.OnModular6;
            @Modular6.performed -= instance.OnModular6;
            @Modular6.canceled -= instance.OnModular6;
            @Confirm.started -= instance.OnConfirm;
            @Confirm.performed -= instance.OnConfirm;
            @Confirm.canceled -= instance.OnConfirm;
            @Cancel.started -= instance.OnCancel;
            @Cancel.performed -= instance.OnCancel;
            @Cancel.canceled -= instance.OnCancel;
        }

        public void RemoveCallbacks(IActionInputActions instance)
        {
            if (m_Wrapper.m_ActionInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionInputActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionInputActions @ActionInput => new ActionInputActions(this);
    public interface IMovementInputActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnRudder(InputAction.CallbackContext context);
    }
    public interface IActionInputActions
    {
        void OnModular1(InputAction.CallbackContext context);
        void OnModular2(InputAction.CallbackContext context);
        void OnModular3(InputAction.CallbackContext context);
        void OnModular4(InputAction.CallbackContext context);
        void OnModular5(InputAction.CallbackContext context);
        void OnModular6(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
