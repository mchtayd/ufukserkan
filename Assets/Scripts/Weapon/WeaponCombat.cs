using UnityEngine;

public class WeaponCombat : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab = null;
    [SerializeField] private Transform _bulletOrientation = null;
    [SerializeField] private float _fireRate = 0.20f;

    private float _nextShootTime = 0.00f;

    private void Update()
    {
        if (_nextShootTime < Time.time)
        {
            _nextShootTime = Time.time + _fireRate;
            Bullet spawnedBullet = Instantiate(_bulletPrefab, _bulletOrientation.position, _bulletOrientation.rotation);
            spawnedBullet.Execute(-_bulletOrientation.forward);
        }
    }
}