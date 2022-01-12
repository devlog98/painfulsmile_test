using UnityEngine;

namespace devlog98.PainfulSmile {
    public class Rotate : MonoBehaviour {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float rotateSpeed = 10f;
        private float rotateInput;

        public void Execute(float _rotateInput) {
            rotateInput = _rotateInput;
        }

        public void FixedUpdate() {
            rb.AddTorque(rotateInput * rotateSpeed);
        }
    }
}