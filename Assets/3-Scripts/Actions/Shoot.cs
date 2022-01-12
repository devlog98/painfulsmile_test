using System.Collections.Generic;
using UnityEngine;

namespace devlog98.PainfulSmile {
    public class Shoot : MonoBehaviour {
        [SerializeField] private List<Transform> firePoints;
        [SerializeField] private float fireRate = 1f;
        [SerializeField] private Bullet bullet;
        private float timeToShoot;

        public void Execute() {
            if (Time.time > timeToShoot) {
                foreach (Transform firePoint in firePoints) {
                    Bullet newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                }

                timeToShoot = Time.time + (1 / fireRate);
            }
        }
    }
}