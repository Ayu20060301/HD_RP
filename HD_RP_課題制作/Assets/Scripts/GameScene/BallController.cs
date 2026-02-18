using UnityEngine;

public class BallController : MonoBehaviour
{
    private float _ballSpeed = 6.0f; //ボールの速度

    private Rigidbody _rigidbody;

    private void Start()
    {

        //GManager.instance.isStart = false;

        //Rigidbodyを取得
        _rigidbody = GetComponent<Rigidbody>();

        if (GManager.instance.isStart)
        {
            //右奥方向に力を加える
            Vector3 direction = new Vector3(_ballSpeed, 0, _ballSpeed);

            _rigidbody.AddForce(direction, ForceMode.Impulse);
        }
    }


}
