using UnityEngine;

namespace devlog98.PainfulSmile {
    public class MoveForward : MonoBehaviour {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float moveSpeed = 10f;
        private float moveInput;

        public void Execute(float _moveInput) {
            moveInput = _moveInput;
        }

        public void FixedUpdate() {
            if (moveInput > 0) {
                rb.AddForce(transform.up * moveSpeed);
            }
        }
    }
}