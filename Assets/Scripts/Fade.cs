using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Image>().DOFade(1f,1f);
    }   
}
