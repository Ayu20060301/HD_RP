using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// シーン遷移の制御
/// </summary>
public class SceneController : SingletonMonoBehaviour<SceneController>
{

    protected override void Awake()
    {
        base.Awake();

        //フレームレートの設定
        Application.targetFrameRate = 60;
    }


    /// <summary>
    /// シーン遷移
    /// </summary>
    /// <param name="sceneName">シーン名</param>
    public void SceneChange(string sceneName)
    {
        StartCoroutine(SceneChangeCoroutine(sceneName));
    }


    /// <summary>
    /// シーン遷移のコルーチン
    /// </summary>
    /// <param name="sceneName">シーンの名前</param>
    /// <returns>遷移させるコルーチンを返す</returns>
    private IEnumerator SceneChangeCoroutine(string sceneName)
    {

        //フェードアウト
        yield return FadeController.instance.FadeOutCoroutine(0.5f);

        //シーン切り替え
        SceneManager.LoadScene(sceneName);
        yield return null;

        //フェードイン
        yield return FadeController.instance.FadeInCoroutine(0.6f);

    }
}
