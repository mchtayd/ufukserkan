using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class StartButton : MonoBehaviour
{
    private Button _button = null;

    private void Awake()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(delegate
        {
            SceneManager.LoadScene(1);
        });
    }
}