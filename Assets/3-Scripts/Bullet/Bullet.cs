using UnityEngine;

namespace devlog98.PainfulSmile {
    public class Bullet : MonoBehaviour {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float duration = 5f;

        private void Start() {
            rb.velocity = transform.up * moveSpeed;
            Invoke("DestroyOnDuration", duration);
        }

        private void DestroyOnDuration() {
            Destroy(this.gameObject);
        }
    }
}