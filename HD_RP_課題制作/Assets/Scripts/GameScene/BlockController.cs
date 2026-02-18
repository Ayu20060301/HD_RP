using System.Collections;
using UnityEngine;



public class BlockController : MonoBehaviour
{

    private float _respawnTime = 5.0f; //•œŠˆ‚Ü‚Å‚Ì•b” //•œŠˆ‚Ü‚Å‚Ì•b”

    private bool _isRespawning = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball") && !_isRespawning)
        {
           
            _isRespawning = true;

            //ˆê’èŠÔŒã‚É•œŠˆ‚³‚¹‚é
            StartCoroutine(RespawnCoroutine());

        }
    }

    private IEnumerator RespawnCoroutine()
    {
        //ƒQ[ƒ€‚ªŠJn‚µ‚Ä‚¢‚È‚¢ê‡‚Í•œŠˆ‚³‚¹‚È‚¢
        if (!GManager.instance.isStart) yield break; ;

        //Œ©‚½–Ú‚¾‚¯Á‚·
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(_respawnTime);

        //•œŠˆ
        GetComponent<Renderer>().enabled = true;
        GetComponent<Collider>().enabled = true;

        _isRespawning = false;
    }
}
