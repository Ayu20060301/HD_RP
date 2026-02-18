using UnityEngine;
using TMPro;
using DG.Tweening; //DOTween用
using System.Collections;

public class ReadyCount : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _readyText;

    [SerializeField]
    private GameStart _gameStart;

    private float _countDownTime = 3.0f; //秒数
    private float _bounceScale = 1.5f; //跳ねる大きさ
    private float _bounceDuration = 0.3f; //跳ねる時間

    private void Start()
    {
        StartCoroutine(CountCoroutine());
    }

    private IEnumerator CountCoroutine()
    {
        float currentTime = _countDownTime;

        while (currentTime > 0)
        {
            _readyText.text = Mathf.Ceil(currentTime).ToString();

            //スケールをリセットしてからアニメーション
            _readyText.transform.localScale = Vector3.one;
            _readyText.transform.DOScale(_bounceScale, _bounceDuration).SetEase(Ease.OutBounce);

            yield return new WaitForSeconds(1.0f);
            currentTime--;
        }

        //Start!演出
        _readyText.text = "Start!";
        _readyText.transform.localScale = Vector3.one;
        _readyText.transform.DOScale(_bounceScale, _bounceDuration).SetEase(Ease.OutBounce);

        yield return new WaitForSeconds(1.0f);
        _readyText.gameObject.SetActive(false);

        _gameStart.OnStart();

    }




}
