// GENERATED AUTOMATICALLY FROM 'Assets/Input System/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d118b516-24c5-4c4d-ab2f-f2b2538b6138"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""089a3bf9-7ee8-4938-87f1-704bd2df5b5c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b03ae7a4-5c4e-48fe-b5ed-22d005cb2775"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""08a6aac9-13cf-4c9f-a8f6-2ffa0106ce0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Modifier"",
                    ""type"": ""Button"",
                    ""id"": ""aa9e3940-0271-4dc3-83f8-8a2806c5cf36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""37dcc61a-4a97-4204-9889-4f39143a0e61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""ccfbc569-830e-432d-bb7d-6dc4975151e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""5f71c2c8-8505-4f72-b922-5acb3e9f48d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""068d5887-93f7-46e2-a997-b25a2fb6a2a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectItemPrevious"",
                    ""type"": ""Button"",
                    ""id"": ""fbe0d590-57e0-4a8f-9011-5add9fe37cf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectItemNext"",
                    ""type"": ""Button"",
                    ""id"": ""2db8c677-0d78-423e-9779-6185866dc9e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""100f220d-94fe-4789-966e-e5d2df283384"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steam"",
                    ""type"": ""Button"",
                    ""id"": ""9ad8190b-39ce-4441-984a-4aa44d490e73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""b42e7ff8-45af-4dba-89d6-24eddfee2cbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""09b93e20-ea62-4d60-8f35-9d05b1ea41f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""2db9effc-9d4e-4f2f-be55-f26cedf77329"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GunAimDirection"",
                    ""type"": ""Value"",
                    ""id"": ""697f32c8-46f4-4e8d-9412-e85135add472"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""422e5d25-d4c3-4b9f-abc4-f05c24fca2f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLinear"",
                    ""type"": ""Value"",
                    ""id"": ""27ccced0-4983-47b0-a816-0b6834793c64"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1defd62d-d559-469b-87c6-47d40276eddb"",
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
                    ""id"": ""3cb64c01-91dd-4ae3-89a4-ec089f62bca7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a4d5117-e313-421d-8e2d-2f2a4821e272"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e6ef462-6814-476e-b4a5-cad790d065f5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e7cdf35c-7f56-4c13-90e4-c790f72979de"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""88536852-6714-4507-a651-44fa04a9cabc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.2,max=0.9)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f579938-d5a4-4749-942d-75ccb5fa5f6b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9233b666-66a9-41cd-bdb1-ff311904fe58"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60e12d85-1bbe-4332-84f8-53f78d98e248"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f9c43db-3410-4778-9d5c-424c0d9ba451"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Modifier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3af48577-9990-4e33-88b6-6e52ea9507ef"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Modifier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5168c60-e185-43fa-8cea-963a41297c5d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57923a58-1680-4d77-b710-d20758df53cd"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0df7f4fc-ade5-4005-8186-56e341b1b91c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d0b2027-f533-48a1-9bb9-e392f3b49b56"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""189feb55-cdab-4860-ae86-789693c1735e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectItemPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6678289-5322-40ba-b757-d8b48569c3a8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SelectItemPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23c74e38-9e71-4fdc-9d9f-e38ead7108ed"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffb99640-892b-4153-9d23-bd494fa6cce9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04afbeb8-c6e0-4a5d-9cb4-54e111bf0c36"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40713dc1-108d-493f-98a0-f6b8513a20f7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Steam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10289b10-cc4f-41af-868d-ceeee1ee4f70"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f53a743-d870-4176-a966-05be07d4f7c2"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c9d8555-f297-4dad-8e40-5415d5d1846c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectItemNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34318e71-16f0-486b-93d8-448754bf2680"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SelectItemNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3381475c-39de-485c-9bb7-98005e7f7693"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d06d25c-def8-4fe5-bdaa-84ed697dc604"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be7c02d6-99c5-4e72-8ed8-3c9db905f6a6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c9c87d0-8f56-45b2-9134-f10d5ae7c41f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cc8e9eb-3f0e-43e2-9fc6-70469898721b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f38a1eb-d708-417b-aaa6-2638103b71e5"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""013ee2c0-5025-4367-a107-6bcb93cc9681"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98487c49-f220-4b27-83ec-9d8b344548ed"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GunAimDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cb30a49-6947-484c-85e4-c9b4cedcea42"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55314a4d-be7a-4b68-9f97-43858afdfddc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9781da8-ec72-436a-82a8-835fecfffe80"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveLinear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""cf62be9c-9d82-4e94-8fcb-d388d7f7aceb"",
            ""actions"": [
                {
                    ""name"": ""MenuDirection"",
                    ""type"": ""Value"",
                    ""id"": ""b3ccbd1b-43b9-43d7-9bf4-8591bd848a9d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectMenuItem"",
                    ""type"": ""Button"",
                    ""id"": ""b8a7dbfb-7d4d-4310-a3e5-a049c5bbf2bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuBack"",
                    ""type"": ""Button"",
                    ""id"": ""18fdb9d5-a7a6-4652-ba7d-f75f20b4549a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitMenu"",
                    ""type"": ""Button"",
                    ""id"": ""c5c819b1-f1cf-44e2-a38b-2060779c43c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""1f7055c4-012e-4a1c-a4c9-e026c9e198be"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a942eb74-b4ae-49e7-aacb-68f5019973d1"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MenuDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""198e4f64-11b5-432c-8565-e815f4957c19"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectMenuItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13f2f2f9-5065-4780-a3b0-128d8c149849"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SelectMenuItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9ca4473-35fa-45c1-96e6-3b2c86094ad6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MenuBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8e993bd-b5a7-458b-b88f-5eb0c958f097"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74d59a22-a0e8-4b9c-ba07-74abda192ebb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff54e9e2-3aff-43b2-9e05-60556d81bf1b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MouseDelta"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Modifier = m_Player.FindAction("Modifier", throwIfNotFound: true);
        m_Player_Throw = m_Player.FindAction("Throw", throwIfNotFound: true);
        m_Player_Melee = m_Player.FindAction("Melee", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Map = m_Player.FindAction("Map", throwIfNotFound: true);
        m_Player_SelectItemPrevious = m_Player.FindAction("SelectItemPrevious", throwIfNotFound: true);
        m_Player_SelectItemNext = m_Player.FindAction("SelectItemNext", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_Steam = m_Player.FindAction("Steam", throwIfNotFound: true);
        m_Player_UseItem = m_Player.FindAction("UseItem", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_GunAimDirection = m_Player.FindAction("GunAimDirection", throwIfNotFound: true);
        m_Player_PauseMenu = m_Player.FindAction("PauseMenu", throwIfNotFound: true);
        m_Player_MoveLinear = m_Player.FindAction("MoveLinear", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_MenuDirection = m_UI.FindAction("MenuDirection", throwIfNotFound: true);
        m_UI_SelectMenuItem = m_UI.FindAction("SelectMenuItem", throwIfNotFound: true);
        m_UI_MenuBack = m_UI.FindAction("MenuBack", throwIfNotFound: true);
        m_UI_ExitMenu = m_UI.FindAction("ExitMenu", throwIfNotFound: true);
        m_UI_MouseDelta = m_UI.FindAction("MouseDelta", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Modifier;
    private readonly InputAction m_Player_Throw;
    private readonly InputAction m_Player_Melee;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Map;
    private readonly InputAction m_Player_SelectItemPrevious;
    private readonly InputAction m_Player_SelectItemNext;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_Steam;
    private readonly InputAction m_Player_UseItem;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_GunAimDirection;
    private readonly InputAction m_Player_PauseMenu;
    private readonly InputAction m_Player_MoveLinear;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Modifier => m_Wrapper.m_Player_Modifier;
        public InputAction @Throw => m_Wrapper.m_Player_Throw;
        public InputAction @Melee => m_Wrapper.m_Player_Melee;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Map => m_Wrapper.m_Player_Map;
        public InputAction @SelectItemPrevious => m_Wrapper.m_Player_SelectItemPrevious;
        public InputAction @SelectItemNext => m_Wrapper.m_Player_SelectItemNext;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @Steam => m_Wrapper.m_Player_Steam;
        public InputAction @UseItem => m_Wrapper.m_Player_UseItem;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @GunAimDirection => m_Wrapper.m_Player_GunAimDirection;
        public InputAction @PauseMenu => m_Wrapper.m_Player_PauseMenu;
        public InputAction @MoveLinear => m_Wrapper.m_Player_MoveLinear;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Modifier.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnModifier;
                @Modifier.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnModifier;
                @Modifier.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnModifier;
                @Throw.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                @Melee.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMelee;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Map.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @SelectItemPrevious.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemPrevious;
                @SelectItemPrevious.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemPrevious;
                @SelectItemPrevious.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemPrevious;
                @SelectItemNext.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemNext;
                @SelectItemNext.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemNext;
                @SelectItemNext.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectItemNext;
                @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Steam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteam;
                @Steam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteam;
                @Steam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSteam;
                @UseItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseItem;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @GunAimDirection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunAimDirection;
                @GunAimDirection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunAimDirection;
                @GunAimDirection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunAimDirection;
                @PauseMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @MoveLinear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLinear;
                @MoveLinear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLinear;
                @MoveLinear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLinear;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Modifier.started += instance.OnModifier;
                @Modifier.performed += instance.OnModifier;
                @Modifier.canceled += instance.OnModifier;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @SelectItemPrevious.started += instance.OnSelectItemPrevious;
                @SelectItemPrevious.performed += instance.OnSelectItemPrevious;
                @SelectItemPrevious.canceled += instance.OnSelectItemPrevious;
                @SelectItemNext.started += instance.OnSelectItemNext;
                @SelectItemNext.performed += instance.OnSelectItemNext;
                @SelectItemNext.canceled += instance.OnSelectItemNext;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Steam.started += instance.OnSteam;
                @Steam.performed += instance.OnSteam;
                @Steam.canceled += instance.OnSteam;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @GunAimDirection.started += instance.OnGunAimDirection;
                @GunAimDirection.performed += instance.OnGunAimDirection;
                @GunAimDirection.canceled += instance.OnGunAimDirection;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @MoveLinear.started += instance.OnMoveLinear;
                @MoveLinear.performed += instance.OnMoveLinear;
                @MoveLinear.canceled += instance.OnMoveLinear;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_MenuDirection;
    private readonly InputAction m_UI_SelectMenuItem;
    private readonly InputAction m_UI_MenuBack;
    private readonly InputAction m_UI_ExitMenu;
    private readonly InputAction m_UI_MouseDelta;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuDirection => m_Wrapper.m_UI_MenuDirection;
        public InputAction @SelectMenuItem => m_Wrapper.m_UI_SelectMenuItem;
        public InputAction @MenuBack => m_Wrapper.m_UI_MenuBack;
        public InputAction @ExitMenu => m_Wrapper.m_UI_ExitMenu;
        public InputAction @MouseDelta => m_Wrapper.m_UI_MouseDelta;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @MenuDirection.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDirection;
                @MenuDirection.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDirection;
                @MenuDirection.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDirection;
                @SelectMenuItem.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectMenuItem;
                @SelectMenuItem.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectMenuItem;
                @SelectMenuItem.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectMenuItem;
                @MenuBack.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuBack;
                @MenuBack.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuBack;
                @MenuBack.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuBack;
                @ExitMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnExitMenu;
                @ExitMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnExitMenu;
                @ExitMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnExitMenu;
                @MouseDelta.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseDelta;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuDirection.started += instance.OnMenuDirection;
                @MenuDirection.performed += instance.OnMenuDirection;
                @MenuDirection.canceled += instance.OnMenuDirection;
                @SelectMenuItem.started += instance.OnSelectMenuItem;
                @SelectMenuItem.performed += instance.OnSelectMenuItem;
                @SelectMenuItem.canceled += instance.OnSelectMenuItem;
                @MenuBack.started += instance.OnMenuBack;
                @MenuBack.performed += instance.OnMenuBack;
                @MenuBack.canceled += instance.OnMenuBack;
                @ExitMenu.started += instance.OnExitMenu;
                @ExitMenu.performed += instance.OnExitMenu;
                @ExitMenu.canceled += instance.OnExitMenu;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
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
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnModifier(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnSelectItemPrevious(InputAction.CallbackContext context);
        void OnSelectItemNext(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnSteam(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnGunAimDirection(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnMoveLinear(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMenuDirection(InputAction.CallbackContext context);
        void OnSelectMenuItem(InputAction.CallbackContext context);
        void OnMenuBack(InputAction.CallbackContext context);
        void OnExitMenu(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
    }
}
