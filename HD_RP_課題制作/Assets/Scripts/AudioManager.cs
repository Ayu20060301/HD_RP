using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    private AudioSource _audio;

    [SerializeField]
    private SoundDatabase _soundDB;

    private Dictionary<BGMType, BGMData> _bgmDict = new();


    private Dictionary<SEType, SEData> _seDict = new();

    protected override void Awake()
    {
        base.Awake();

        _audio = GetComponent<AudioSource>();

        foreach(var data in _soundDB.bgmData)
        {
            _bgmDict[data.type] = data;
        }

        foreach(var data in _soundDB.seData)
        {
            _seDict[data.type] = data;
        }
    }

    /// <summary>
    /// BGMÇê›íË
    /// </summary>
    /// <param name="type">BGMÇÃéÌóﬁ</param>
    public void SetBGMState(BGMType type)
    {
        if(_bgmDict.TryGetValue(type,out var bgmData))
        {
            _audio.clip = bgmData.clip;
            _audio.loop = true;
            _audio.Play();
        }
    }

}
