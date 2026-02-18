using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundDatabase", menuName = "Sound/SoundDatabaseを作成")]

public class SoundDatabase : ScriptableObject
{
    [Header("各BGMのデータを格納する")]
    public List<BGMData> bgmData = new List<BGMData>();

    [Header("各効果音のデータを格納する")]
    public List<SEData> seData = new List<SEData>();
}
