using UnityEngine;

//The single shot mechanism of the projectile.
namespace NanoWar {
    [CreateAssetMenu(fileName = "SingleShot", menuName = "NanoWar/WeaponStrategy/SingleShot")]
    public class SingleShot : WeaponStrategy {
        public override void Fire(Transform firePoint, LayerMask layer) {
            var projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            projectile.transform.SetParent(null);
            projectile.layer = layer;
            var projectileComponent = projectile.GetComponent<Projectile>();
            projectileComponent.SetSpeed(projectileSpeed);
            
            Destroy(projectile, projectileLifetime);
        }
    }
}
