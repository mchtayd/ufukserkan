using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu = null;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _pauseMenu.SetActive(!_pauseMenu.activeSelf);
            Time.timeScale = _pauseMenu.activeSelf ? 0.00f : 1.00f;
        }   
    }
}