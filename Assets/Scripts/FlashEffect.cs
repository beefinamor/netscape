using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class FlashEffect : MonoBehaviour
{
    public Image effectImage;
    public GameObject errorText;
    private int currentLoop = 0;
    public int maxLoops = 3;


    public void ShowEffect()
    {
        effectImage.DOFade(0.4f, 0.7f).OnComplete(() =>
        {
            effectImage.DOFade(0, 0.7f).OnComplete(() =>
            {
                currentLoop++;
                if (currentLoop < maxLoops)
                {
                    ShowEffect();
                }
                else
                {
                    DisableEffect();
                }
            });
        });
    }
    
    public void EnableEffect()
    {
        effectImage.gameObject.SetActive(true);
        errorText.SetActive(true);
        currentLoop = 0;
        ShowEffect();
    }
    public void DisableEffect()
    {
        effectImage.gameObject.SetActive(false);
        errorText.SetActive(false);
    }
}
