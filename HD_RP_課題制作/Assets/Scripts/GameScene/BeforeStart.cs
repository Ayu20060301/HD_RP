using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class BeforeStart : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;

    [SerializeField]
    private Image _image;


    private IEnumerator BeforeStartCoroutine()
    {

        if(Input.GetMouseButtonDown(0))
        {

        }

        //1ƒtƒŒ[ƒ€‘Ò‚Â
        yield return null;
    }


}
