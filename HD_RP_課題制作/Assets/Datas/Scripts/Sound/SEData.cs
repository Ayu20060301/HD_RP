using UnityEngine;

//Œø‰Ê‰¹‚Ìí—Ş
public enum SEType
{
    CLICK
}

[CreateAssetMenu(fileName = "SEData", menuName = "Sound/SEData‚ğì¬")]

public class SEData : ScriptableObject
{
    public AudioClip clip;
    public SEType type;
}
