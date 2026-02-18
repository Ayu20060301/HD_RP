using System.Collections;
using UnityEngine;

public class FadeController : SingletonMonoBehaviour<FadeController>
{
    [SerializeField]
    CanvasGroup _fadeCanvas;

    protected override void Awake()
    {
        base.Awake();

        //フェード用のCanvasを他のシーンにも残しておく
        DontDestroyOnLoad(this._fadeCanvas.gameObject);

        //起動時は透明にしておく
        _fadeCanvas.alpha = 0.0f;
        _fadeCanvas.blocksRaycasts = false;
        _fadeCanvas.gameObject.SetActive(false);
    }

    /// <summary>
    /// フェードイン用コルーチン
    /// </summary>
    /// <param name="duration">フェードインまでにかかる時間</param>
    /// <returns></returns>
    public IEnumerator FadeInCoroutine(float duration)
    {

        _fadeCanvas.gameObject.SetActive(true);
        _fadeCanvas.blocksRaycasts = true;

        if(duration <= 0.0f)
        {
            _fadeCanvas.alpha = 0.0f;
        }
        else
        {
            float time = 0.0f;
            while(time < duration)
            {
                time += Time.deltaTime;
                _fadeCanvas.alpha = 1.0f - (time / duration);
                yield return null;
            }
        }

        _fadeCanvas.alpha = 0.0f;
        _fadeCanvas.blocksRaycasts = false;
        _fadeCanvas.gameObject.SetActive(false);
    }


    /// <summary>
    /// フェードアウト用コルーチン
    /// </summary>
    /// <param name="duration">フェードアウトになるまでに掛かる時間</param>
    /// <returns></returns>
    public IEnumerator FadeOutCoroutine(float duration)
    {
        _fadeCanvas.gameObject.SetActive(true);
        _fadeCanvas.blocksRaycasts = true;

        if(duration <= 0.0f)
        {
            _fadeCanvas.alpha = 1.0f;
        }
        else
        {
            float time = 0.0f;
            while(time < duration)
            {
                time += Time.deltaTime;
                _fadeCanvas.alpha = time / duration;
                yield return null;
            }
        }
        _fadeCanvas.alpha = 1.0f;
    }
}
