using UnityEngine;

//Projectile of enemy weapon
namespace NanoWar {
    public class EnemyWeapon : Weapon {
        float fireTimer;

        void Update() {
            fireTimer += Time.deltaTime;
            
            if (fireTimer >= weaponStrategy.FireRate) {
                weaponStrategy.Fire(firePoint, layer);
                fireTimer = 0f;
            }
        }
    }
}