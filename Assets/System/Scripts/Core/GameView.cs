using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameView : MonoBehaviour
{
    public CanvasGroup fadeCanvas;

    public void FadeInScreen(float time = .25f)
    {
        fadeCanvas.interactable = false;
        fadeCanvas.blocksRaycasts = true;        
        fadeCanvas.DOFade(1, time);
    }

    public void FadeOutScreen(float time = .25f)
    {
        fadeCanvas.DOFade(0, time).OnComplete(()=> 
        {
            fadeCanvas.blocksRaycasts = false;
        });
    }
}
