using UnityEngine;

public class WeaponMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.00f;
    [SerializeField] private bool _convertInput = false;


    private void Update()
    {
        float horizontalInput = (Input.GetAxisRaw("Horizontal") * Time.deltaTime * _moveSpeed) * (_convertInput ? -1.00f : 1.00f);

        transform.Translate(transform.right * horizontalInput);
    }
}