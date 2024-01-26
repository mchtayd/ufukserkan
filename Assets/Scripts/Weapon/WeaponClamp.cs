using UnityEngine;

public class WeaponClamp : MonoBehaviour
{
    [SerializeField] private Vector2 _clampXValues = Vector2.one;

    private void LateUpdate()
    {
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, _clampXValues.x, _clampXValues.y);

        transform.position = position;
    }
}