using UnityEngine;

/// <summary>
/// パドルの挙動処理
/// </summary>
public class PaddleController : MonoBehaviour
{
    private float _speed = 7.0f; //移動速度

    private Rigidbody _rb;

    //移動可能範囲
    private float _minX = -3.5f;
    private float _maxX = 3.5f;

    private void Start()
    {
        //コーポネントを取得
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //ゲームが開始していない場合は動かないようにする
        if (!GManager.instance.isStart) return;

        float move = 0.0f;

        //右移動
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move = 1.0f;
        }

        //左移動
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            move = -1.0f;
        }

        //現在位置を取得
        Vector3 pos = _rb.position;

        //入力に応じてX方向へ移動
        pos.x += move * _speed * Time.fixedDeltaTime;

        //移動範囲を制限(壁貫通防止)
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        //RigidBodyを使って位置を更新
        _rb.MovePosition(pos);
    }
}
