using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private int _currentScore = 0;

    public int CurrentScore
    {
        get => _currentScore; private set
        {
            _currentScore = value;
            OnChangedScoreEvent?.Invoke(_currentScore);
        }
    }

    public static event System.Action<int> OnChangedScoreEvent = null;

    private void OnEnable()
    {
        EnemyHealth.OnDeathAction += HandleOnDeathEnemy;
    }
    private void OnDisable()
    {
        EnemyHealth.OnDeathAction -= HandleOnDeathEnemy;
    }

    private void HandleOnDeathEnemy()
    {
        CurrentScore += 100;
    }
}