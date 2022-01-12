using UnityEngine;

namespace devlog98.PainfulSmile {
    public class InputManager : MonoBehaviour {
        private PlayerInput playerInput;
        private PlayerInput.PlayerControllerActions playerController;

        private void OnEnable() {
            playerInput.Enable();
        }

        private void OnDisable() {
            playerInput.Disable();
        }

        private void Awake() {
            playerInput = new PlayerInput();
            playerController = playerInput.PlayerController;
        }
    }
}