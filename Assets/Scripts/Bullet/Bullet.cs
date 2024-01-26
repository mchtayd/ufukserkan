using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [Header("Combat Variables")]
    [SerializeField] private int _damage = 1;


    [Header("Move Variables")]
    [SerializeField] private float _executeSpeed = 10.00f;
    [SerializeField] private float _lifeTime = 2.00f;
    private Rigidbody _rigidbody = null;

    public void Execute(Vector3 Direction)
    {
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, _lifeTime);

        _rigidbody.velocity = (Direction.normalized) * _executeSpeed;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out EnemyHealth Health))
            return;

        Health.TakeDamage(_damage);
        Destroy(gameObject);
    }
}