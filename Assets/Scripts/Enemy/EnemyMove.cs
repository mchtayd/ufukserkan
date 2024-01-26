using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.00f;

    private void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * transform.forward);
    }
}