using UnityEngine;

public class EnemyWaveManager : MonoBehaviour
{
    [SerializeField] private EnemyMove _enemyPrefab = null;

    [SerializeField] private Transform _minTransform = null;
    [SerializeField] private Transform _maxTransform = null;

    [SerializeField] private Vector2 _minMaxSpawnDelay = Vector2.one;
    private float _timeDuration = 0.00f;
    private float _elapsedTime = 0.00f;

    private void Start()
    {
        _timeDuration = GetRandomTimeDuration();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime < _timeDuration)
            return;

        SpawnEnemy();
    }

    private float GetRandomTimeDuration() => Random.Range(_minMaxSpawnDelay.x, _minMaxSpawnDelay.y);

    private Vector3 GetRandomSpawnPosition() {
        return new Vector3(Random.Range(_minTransform.position.x, _maxTransform.position.x), _minTransform.position.y, _minTransform.position.z);
    }

    private void SpawnEnemy()
    {
        _elapsedTime = 0.00f;
        Instantiate(_enemyPrefab,GetRandomSpawnPosition(), _enemyPrefab.transform.rotation);
    }
}