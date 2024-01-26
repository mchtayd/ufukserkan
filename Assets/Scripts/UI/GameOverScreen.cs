using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private GameObject _panelObject = null;
    private void OnEnable()
    {
        GameOverZone.OnTouchedGameOverZone += HandleOnTouchedGameOverZone;
    }

    private void OnDisable()
    {
        GameOverZone.OnTouchedGameOverZone -= HandleOnTouchedGameOverZone;
    }

    private void HandleOnTouchedGameOverZone()
    {
        _panelObject.SetActive(true);
        Time.timeScale = 0.00f;
    }    
}