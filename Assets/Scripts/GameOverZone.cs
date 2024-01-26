using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    public static event System.Action OnTouchedGameOverZone = null;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out EnemyMove _))
            return;

        OnTouchedGameOverZone?.Invoke();
    }
}