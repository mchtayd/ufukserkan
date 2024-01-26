using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class QuitButton : MonoBehaviour
{
    private Button _button = null;

    private void Awake()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(delegate
        {
            Application.Quit();
        });
    }
}
