// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""PlayerGraphicAdventure"",
            ""id"": ""428653a5-13e8-44c6-ad25-1a346bf58d8c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""00a9abb4-1892-4d1a-9580-8103558e4208"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""ae4b3e2d-1c3b-44d2-9884-c1054a83b983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backpack"",
                    ""type"": ""Button"",
                    ""id"": ""c1768998-4a34-4ff0-b2ec-edb8e39074cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowKeyObjects"",
                    ""type"": ""Button"",
                    ""id"": ""dd6b0008-db66-4129-abf9-6cd5e161eafa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""b23d7fb4-1557-4237-aa43-ba2d00bc8057"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a37ac345-355d-448e-8e6b-d10ad3e8bb81"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4b4f0a7-3c2d-4ef5-9256-2b793cdbd2f4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48adb250-693b-499b-a318-86962ee67a38"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Backpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32b4094a-631e-411a-85fa-1004c6cfad5e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Backpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""43bbff13-d72c-4e3a-8420-cc8bcc9a4c80"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dde498da-6586-4fd7-9444-bba13b9262d4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0ea9adfb-5474-4444-bbb4-3033c222c5c9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ecf1553b-936f-4a70-ac20-6700bb86f921"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cd620ca5-c70e-4035-a8a4-a2066515eb3f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""e0d7c4a7-5fe4-4629-9d62-75dc6137fe7a"",
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
                    ""id"": ""cbe9582d-2055-4c3c-aed5-bfd746caa4a0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a22fdd10-597d-4110-9949-6d79d3672fd2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0c9c06d6-0a2d-4bad-9123-57d54412450b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""09e995e6-911f-4f24-9968-9e18c7264e4d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5ece5b82-19d1-4e8c-859e-5e6b9f837dd6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""798a041f-a2c7-48e2-82f6-a74c5d9963c3"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShowKeyObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0dd9a1e-4aaf-4286-bb46-e6a4122a83ab"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShowKeyObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfda9dc6-84d7-471d-add0-56a380bf1cef"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1675dbb5-7f29-419c-839c-ca4a6a4f4407"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerDemolitionRace"",
            ""id"": ""dcecbeab-d9f0-47f8-b866-f55c461021e6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c17a45a7-a504-412f-881f-3c5cc54f7a9c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""fbfd1301-95f2-48a5-8dda-edbe7dc4ad75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""90032980-8093-4612-941d-23ac66f9e77f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8ea4cb58-7061-4b33-8433-125b34db60d8"",
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
                    ""id"": ""7985b50c-9b75-43ae-be62-7114e1b405b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c302d895-4723-4513-ba5b-540dd8a68b14"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""468cb992-3547-4001-803c-4f3f31e9c9ac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""39d176a0-5d2f-4612-b1f0-c297d4560dd2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d03b027f-4e53-4ac6-9b03-65d6117bb6a3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6d452a1-289b-4311-bffe-20db29a955c7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41dd0d9a-6345-4b0b-ac66-56d1c702bee2"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""870efe80-74f0-4fe0-bee9-291a5ac1f7d6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2aeadd1c-dc67-465a-9870-4a2cdd17e156"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65150d85-0d7b-4bf7-8bb0-cca4c1af0366"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Backpack"",
            ""id"": ""55e597a1-b76d-45e5-9bbf-9e925d44264a"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""1d08d445-badc-4b09-973b-2fe3833a7603"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""8a6e09f4-6bd1-4597-848b-477f2b84688f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseBackpack"",
                    ""type"": ""Button"",
                    ""id"": ""48a0ada0-80a1-45f5-a8e6-c86a312268cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ArrowsGamepad"",
                    ""id"": ""878dec03-5025-494e-87cd-3aa72e7046b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5fa05865-0516-447a-9d42-514d7ecafb0f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8705e3be-e446-4063-b17e-05b5a795e789"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4ebcd0e6-f367-4586-abd0-c15614791251"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""816293b2-2141-49d9-8cbf-e7246d5f1a7e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Stick"",
                    ""id"": ""c19cdbd5-be4a-4972-8c9e-311e1d6a87ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6c76b476-c47e-4ab4-8015-a84fcae0a27b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1bf35556-c0cf-402b-a9ea-5dee20c34762"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a1f99508-7006-47d1-b2d9-ac8994fb0574"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""39bc0474-6556-4474-a727-08a9057b2a55"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b8a11835-1a67-4f53-b554-1254a4db33c9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40a61e5e-0897-496e-a499-d8073b78c694"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ca1f88d-a670-4b7f-9760-82ccfba09354"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""58783f52-c007-4ad0-97d8-10c13568ac1b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""031bec6c-2207-4c70-91aa-7203906aa75d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""41ef6f5b-b618-4155-850b-b0bba70ec22b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79c9d869-3158-4a9e-8710-4751b58835d9"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3481385-63ff-41f6-98bf-33e12da0ef3f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CloseBackpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1cecafc-da9e-48ed-8df9-de3ff50ac440"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseBackpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""105b3cbd-849e-4009-a017-60f5acd10aeb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseBackpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menú"",
            ""id"": ""a4deefab-1528-40e9-889b-62e149fb9125"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""2ba33545-4031-4884-a8e4-c5efb0bbd386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""947a5479-7f4d-46e4-8aa5-40a338ace6fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""3df7f86a-af2b-4b77-bb42-1bb406408ccf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ArrowsGamepad"",
                    ""id"": ""9dfb0bc2-f8f8-4578-bc52-939b88383f6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f285228-d7b0-48b0-b988-4693fd89dfd1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7687877c-db57-4ecc-a7c4-df9b92251466"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7fb16a08-2f07-49d1-8ade-63145c7b192f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8a2a34a-2914-4c0d-bf69-c311c2bf034e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Stick"",
                    ""id"": ""a7b5012a-2688-48d4-a00b-62070596e103"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e1023449-2afb-4a14-a62d-da317fa58547"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""408b367e-a28d-4960-b18f-000afd7fd7cb"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12a41182-b807-478e-9fae-ca2724a0d7d8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c483f769-79a0-49d0-b6cd-dcecfbc23292"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9b1a5f30-5425-4fe1-8e6b-9b9bda1cbc31"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c6089b4f-8157-46b6-ad8b-b18e55bd5fd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10cb73f1-1cca-47be-9159-e3fa71e55322"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9991cf19-87d3-44f9-be21-4b7c7205e441"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""04517aeb-dfee-4527-bcd1-1724dc2e15d6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0b108a66-06f1-4861-b6c0-4d3a32744557"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25683673-8d15-4a6f-893b-e261013d32c4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""facff3e3-7dd9-4d86-b614-ea1867b2addd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eadc02c4-357b-454f-9130-6b74f9c7c3e2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
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
        }
    ]
}");
        // PlayerGraphicAdventure
        m_PlayerGraphicAdventure = asset.FindActionMap("PlayerGraphicAdventure", throwIfNotFound: true);
        m_PlayerGraphicAdventure_Movement = m_PlayerGraphicAdventure.FindAction("Movement", throwIfNotFound: true);
        m_PlayerGraphicAdventure_Action = m_PlayerGraphicAdventure.FindAction("Action", throwIfNotFound: true);
        m_PlayerGraphicAdventure_Backpack = m_PlayerGraphicAdventure.FindAction("Backpack", throwIfNotFound: true);
        m_PlayerGraphicAdventure_ShowKeyObjects = m_PlayerGraphicAdventure.FindAction("ShowKeyObjects", throwIfNotFound: true);
        m_PlayerGraphicAdventure_Menu = m_PlayerGraphicAdventure.FindAction("Menu", throwIfNotFound: true);
        // PlayerDemolitionRace
        m_PlayerDemolitionRace = asset.FindActionMap("PlayerDemolitionRace", throwIfNotFound: true);
        m_PlayerDemolitionRace_Movement = m_PlayerDemolitionRace.FindAction("Movement", throwIfNotFound: true);
        m_PlayerDemolitionRace_HandBrake = m_PlayerDemolitionRace.FindAction("HandBrake", throwIfNotFound: true);
        m_PlayerDemolitionRace_Accelerate = m_PlayerDemolitionRace.FindAction("Accelerate", throwIfNotFound: true);
        // Backpack
        m_Backpack = asset.FindActionMap("Backpack", throwIfNotFound: true);
        m_Backpack_Navigate = m_Backpack.FindAction("Navigate", throwIfNotFound: true);
        m_Backpack_Action = m_Backpack.FindAction("Action", throwIfNotFound: true);
        m_Backpack_CloseBackpack = m_Backpack.FindAction("CloseBackpack", throwIfNotFound: true);
        // Menú
        m_Menú = asset.FindActionMap("Menú", throwIfNotFound: true);
        m_Menú_Navigate = m_Menú.FindAction("Navigate", throwIfNotFound: true);
        m_Menú_Action = m_Menú.FindAction("Action", throwIfNotFound: true);
        m_Menú_Back = m_Menú.FindAction("Back", throwIfNotFound: true);
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

    // PlayerGraphicAdventure
    private readonly InputActionMap m_PlayerGraphicAdventure;
    private IPlayerGraphicAdventureActions m_PlayerGraphicAdventureActionsCallbackInterface;
    private readonly InputAction m_PlayerGraphicAdventure_Movement;
    private readonly InputAction m_PlayerGraphicAdventure_Action;
    private readonly InputAction m_PlayerGraphicAdventure_Backpack;
    private readonly InputAction m_PlayerGraphicAdventure_ShowKeyObjects;
    private readonly InputAction m_PlayerGraphicAdventure_Menu;
    public struct PlayerGraphicAdventureActions
    {
        private @PlayerActionControls m_Wrapper;
        public PlayerGraphicAdventureActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerGraphicAdventure_Movement;
        public InputAction @Action => m_Wrapper.m_PlayerGraphicAdventure_Action;
        public InputAction @Backpack => m_Wrapper.m_PlayerGraphicAdventure_Backpack;
        public InputAction @ShowKeyObjects => m_Wrapper.m_PlayerGraphicAdventure_ShowKeyObjects;
        public InputAction @Menu => m_Wrapper.m_PlayerGraphicAdventure_Menu;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGraphicAdventure; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGraphicAdventureActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGraphicAdventureActions instance)
        {
            if (m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMovement;
                @Action.started -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnAction;
                @Backpack.started -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnBackpack;
                @Backpack.performed -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnBackpack;
                @Backpack.canceled -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnBackpack;
                @ShowKeyObjects.started -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnShowKeyObjects;
                @ShowKeyObjects.performed -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnShowKeyObjects;
                @ShowKeyObjects.canceled -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnShowKeyObjects;
                @Menu.started -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_PlayerGraphicAdventureActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Backpack.started += instance.OnBackpack;
                @Backpack.performed += instance.OnBackpack;
                @Backpack.canceled += instance.OnBackpack;
                @ShowKeyObjects.started += instance.OnShowKeyObjects;
                @ShowKeyObjects.performed += instance.OnShowKeyObjects;
                @ShowKeyObjects.canceled += instance.OnShowKeyObjects;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public PlayerGraphicAdventureActions @PlayerGraphicAdventure => new PlayerGraphicAdventureActions(this);

    // PlayerDemolitionRace
    private readonly InputActionMap m_PlayerDemolitionRace;
    private IPlayerDemolitionRaceActions m_PlayerDemolitionRaceActionsCallbackInterface;
    private readonly InputAction m_PlayerDemolitionRace_Movement;
    private readonly InputAction m_PlayerDemolitionRace_HandBrake;
    private readonly InputAction m_PlayerDemolitionRace_Accelerate;
    public struct PlayerDemolitionRaceActions
    {
        private @PlayerActionControls m_Wrapper;
        public PlayerDemolitionRaceActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerDemolitionRace_Movement;
        public InputAction @HandBrake => m_Wrapper.m_PlayerDemolitionRace_HandBrake;
        public InputAction @Accelerate => m_Wrapper.m_PlayerDemolitionRace_Accelerate;
        public InputActionMap Get() { return m_Wrapper.m_PlayerDemolitionRace; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerDemolitionRaceActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerDemolitionRaceActions instance)
        {
            if (m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnMovement;
                @HandBrake.started -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnHandBrake;
                @HandBrake.performed -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnHandBrake;
                @HandBrake.canceled -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnHandBrake;
                @Accelerate.started -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface.OnAccelerate;
            }
            m_Wrapper.m_PlayerDemolitionRaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @HandBrake.started += instance.OnHandBrake;
                @HandBrake.performed += instance.OnHandBrake;
                @HandBrake.canceled += instance.OnHandBrake;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
            }
        }
    }
    public PlayerDemolitionRaceActions @PlayerDemolitionRace => new PlayerDemolitionRaceActions(this);

    // Backpack
    private readonly InputActionMap m_Backpack;
    private IBackpackActions m_BackpackActionsCallbackInterface;
    private readonly InputAction m_Backpack_Navigate;
    private readonly InputAction m_Backpack_Action;
    private readonly InputAction m_Backpack_CloseBackpack;
    public struct BackpackActions
    {
        private @PlayerActionControls m_Wrapper;
        public BackpackActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_Backpack_Navigate;
        public InputAction @Action => m_Wrapper.m_Backpack_Action;
        public InputAction @CloseBackpack => m_Wrapper.m_Backpack_CloseBackpack;
        public InputActionMap Get() { return m_Wrapper.m_Backpack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BackpackActions set) { return set.Get(); }
        public void SetCallbacks(IBackpackActions instance)
        {
            if (m_Wrapper.m_BackpackActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_BackpackActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_BackpackActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_BackpackActionsCallbackInterface.OnNavigate;
                @Action.started -= m_Wrapper.m_BackpackActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_BackpackActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_BackpackActionsCallbackInterface.OnAction;
                @CloseBackpack.started -= m_Wrapper.m_BackpackActionsCallbackInterface.OnCloseBackpack;
                @CloseBackpack.performed -= m_Wrapper.m_BackpackActionsCallbackInterface.OnCloseBackpack;
                @CloseBackpack.canceled -= m_Wrapper.m_BackpackActionsCallbackInterface.OnCloseBackpack;
            }
            m_Wrapper.m_BackpackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @CloseBackpack.started += instance.OnCloseBackpack;
                @CloseBackpack.performed += instance.OnCloseBackpack;
                @CloseBackpack.canceled += instance.OnCloseBackpack;
            }
        }
    }
    public BackpackActions @Backpack => new BackpackActions(this);

    // Menú
    private readonly InputActionMap m_Menú;
    private IMenúActions m_MenúActionsCallbackInterface;
    private readonly InputAction m_Menú_Navigate;
    private readonly InputAction m_Menú_Action;
    private readonly InputAction m_Menú_Back;
    public struct MenúActions
    {
        private @PlayerActionControls m_Wrapper;
        public MenúActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_Menú_Navigate;
        public InputAction @Action => m_Wrapper.m_Menú_Action;
        public InputAction @Back => m_Wrapper.m_Menú_Back;
        public InputActionMap Get() { return m_Wrapper.m_Menú; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenúActions set) { return set.Get(); }
        public void SetCallbacks(IMenúActions instance)
        {
            if (m_Wrapper.m_MenúActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MenúActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenúActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenúActionsCallbackInterface.OnNavigate;
                @Action.started -= m_Wrapper.m_MenúActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_MenúActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_MenúActionsCallbackInterface.OnAction;
                @Back.started -= m_Wrapper.m_MenúActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenúActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenúActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_MenúActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public MenúActions @Menú => new MenúActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
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
    public interface IPlayerGraphicAdventureActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnBackpack(InputAction.CallbackContext context);
        void OnShowKeyObjects(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IPlayerDemolitionRaceActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnHandBrake(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
    }
    public interface IBackpackActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCloseBackpack(InputAction.CallbackContext context);
    }
    public interface IMenúActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
