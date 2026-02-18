using UnityEngine;

public class PlayoutOfScreen : MonoBehaviour
{
    private void Update()
    {

        Vector3 viewportPos = Camera.main.WorldToViewportPoint(this.transform.position);

        //画面外ならゲームオーバー
        if(viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y >1)
        {

        }

    }

    private void GameOver()
    {
        Debug.Log("Game Over");

        
    }
}
