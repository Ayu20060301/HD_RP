using UnityEngine;

public class GameStart : MonoBehaviour
{
    
   public void OnStart()
   {
        if(!GManager.instance.isStart)
        {
            GManager.instance.isStart = true;
        }
   }
}
