using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI _scoreText = null;

    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        ScoreHandler.OnChangedScoreEvent += HandleOnChangeScore;
    }

    private void OnDisable()
    {
        ScoreHandler.OnChangedScoreEvent -= HandleOnChangeScore;
    }

    private void HandleOnChangeScore(int newScore)
    {
        _scoreText.SetText(newScore.ToString());
    }
}