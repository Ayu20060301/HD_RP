using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    [SerializeField]
    private GameObject _sight;

    private bool _isCameraMode; //カメラモードに入ってるか

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _isCameraMode = !_isCameraMode;

            if (_isCameraMode)
            {
                _sight.SetActive(true);
            }
            else
            {
                _sight.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (_isCameraMode)
            {
                _sight.gameObject.SetActive(false);

                //スクリーンショット
                string path = Path.Combine(Application.persistentDataPath, "Screenshot");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                StartCoroutine(ScreenShotCoroutine(path));
            }
        }
    }

    private IEnumerator ScreenShotCoroutine(string path)
    {
        yield return new WaitForEndOfFrame();

        GC.Collect();

        string filePath = Path.Combine(path, "1.png");

        ScreenCapture.CaptureScreenshot(filePath);

        Debug.Log(filePath);

        _sight.gameObject.SetActive(true);
    }
}
