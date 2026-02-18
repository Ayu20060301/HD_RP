using System.Collections.Generic;
using UnityEngine;

public class BGMManager : SingletonMonoBehaviour<BGMManager>
{
    private AudioSource _audio;

    [SerializeField]
    private SoundDatabase _soundDatabase;

    private Dictionary<BGMType, BGMData> _bgmDict = new();

    
    

}
