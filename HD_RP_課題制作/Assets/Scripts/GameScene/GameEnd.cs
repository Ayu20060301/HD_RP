using UnityEngine;

public class GameEnd : MonoBehaviour
{
   public void OnEnd()
    {
        GManager.instance.isStart = false;
    }
}
