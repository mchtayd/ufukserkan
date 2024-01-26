using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class ResumeButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel = null;
    private Button _button = null;

    private void Awake()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(delegate
        {
            Time.timeScale = 1.00f;
            _panel.SetActive(false);
        });
    }
}