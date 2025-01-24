using UnityEngine;
using UnityEngine.InputSystem;

//To define input actions from the input device and to relate the input with the actions that are going to be taken by objects in game.
namespace NanoWar {
    [RequireComponent(typeof(PlayerInput))]
    public class InputReader : MonoBehaviour {
        // NOTE: Make sure to set the Player Input component to C# events
        PlayerInput playerInput;
        InputAction moveAction;
        InputAction fireAction;
        
        public Vector2 Move => moveAction.ReadValue<Vector2>();
        public bool Fire => fireAction.ReadValue<float>() > 0f;

        void Start() {
            playerInput = GetComponent<PlayerInput>();
            moveAction = playerInput.actions["Move"];
            fireAction = playerInput.actions["Fire"];
        }
    }
}