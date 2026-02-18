using UnityEngine;

/// <summary>
/// ゲームの状態を管理するクラス
/// </summary>
public class GManager : SingletonMonoBehaviour<GManager>
{
    public bool isStart; //ゲーム開始したかどうか
    public bool isFading; //フェードに入ってるかどうか

    [Header("オプション設定")]
    public float speed; //ボールの速度
    public float bgmVolume; //BGMのボリューム
    public float seVolume; //効果音のボリューム


    protected override void Awake()
    {
        base.Awake();
    }
}
