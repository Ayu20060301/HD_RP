using UnityEngine;

//BGM‚Ìí—Ş
public enum BGMType
{
    TITLE,
    GAME
}

[CreateAssetMenu(fileName = "BGMData", menuName = "Sound/BGMData‚ğì¬")]

public class BGMData : ScriptableObject
{
    public AudioClip clip;
    public BGMType type;
}
