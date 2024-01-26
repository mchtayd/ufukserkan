using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 10;
    private int _currentHealth = 0;

    public static event System.Action OnDeathAction = null;


    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;

        if (_currentHealth > 0)
            return;

        OnDeathAction?.Invoke();
        Destroy(gameObject);
    }
}