using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreTextUI;

    private int _score = 0; 

    /// <summary>
    /// スコア加算処理
    /// </summary>
    /// <param name="value">加算値</param>
    public void AddScore(int value)
    {
        //スコア加算
        _score += value;

        //UIの更新
        UpdateScoreUI();

        Debug.Log($"スコアアップ : {_score}");
    }

    /// <summary>
    /// UIの更新
    /// </summary>
    private void UpdateScoreUI()
    {
        //合計スコアの表示
        _scoreTextUI.text = _score.ToString();
    }
}
