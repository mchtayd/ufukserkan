using UnityEngine;

public class EnemySkin : MonoBehaviour
{
    [SerializeField] private Transform _skinsParent = null;
    [SerializeField] private Vector2Int _skinMinMaxIndexs = Vector2Int.up;

    private void Awake()
    {
        int randomSkinIndex = Random.Range(_skinMinMaxIndexs.x, _skinMinMaxIndexs.y + 1);

        for (int i = _skinMinMaxIndexs.x; i <= _skinMinMaxIndexs.y; i++)
            _skinsParent.GetChild(i).gameObject.SetActive(i.Equals(randomSkinIndex));
    }
}