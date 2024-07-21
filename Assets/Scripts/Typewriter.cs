using UnityEngine;
using DG.Tweening;
using TMPro;

public class Typewriter : MonoBehaviour
{
    private TMP_Text UIText;
    private string finalText;
    public float WriteSpeed;


    private void Awake()
    {
        UIText = GetComponent<TMP_Text>();
        finalText = UIText.text;        
    }

    
    private void OnEnable()
    {
        AnimateText();
    }

    public void AnimateText()
    {
        string tweenText = "";
        var TextWriterTween = DOTween.To( () => tweenText, x => tweenText = x, finalText, finalText.Length / WriteSpeed).OnUpdate(()=>
        {
            UIText.text = tweenText;
        }).SetEase(Ease.Linear);
    }

}
