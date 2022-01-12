using UnityEngine;

namespace devlog98.PainfulSmile {
    public class InputManager : MonoBehaviour {
        private PlayerInput playerInput;
        private PlayerInput.PlayerControllerActions playerController;

        [Header("Actions")]
        [SerializeField] private MoveForward moveForward;
        private float moveForwardInput;

        [SerializeField] private Rotate rotate;
        private float rotateInput;

        private void OnEnable() {
            playerInput.Enable();
        }

        private void OnDisable() {
            playerInput.Disable();
        }

        private void Awake() {
            playerInput = new PlayerInput();
            playerController = playerInput.PlayerController;

            playerController.Move.performed += ctx => moveForwardInput = ctx.ReadValue<float>();
            playerController.Rotate.performed += ctx => rotateInput = ctx.ReadValue<float>();
        }

        private void Update() {
            moveForward.Execute(moveForwardInput);
            rotate.Execute(rotateInput);
        }
    }
}