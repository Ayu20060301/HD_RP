using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    { 
        //左クリック : ゲームシーンに遷移
        if(Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
    }

    public void OnClick()
    {
        SceneController.instance.SceneChange("GameScene");
    }
}
