using UnityEngine;

//To define the projectile details used to control the projectile.
namespace NanoWar {
    public abstract class WeaponStrategy : ScriptableObject {
        [SerializeField] int damage = 10;
        [SerializeField] float fireRate = 0.1f;
        [SerializeField] protected float projectileSpeed = 100f;
        [SerializeField] protected float projectileLifetime = 5f;
        [SerializeField] protected GameObject projectilePrefab;
        
        public int Damage => damage;
        public float FireRate => fireRate;

        public virtual void Initialize() {
            // no-op
        }

        public abstract void Fire(Transform firePoint, LayerMask layer);
    }
}