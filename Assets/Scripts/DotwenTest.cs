using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotwenTest : MonoBehaviour
{

    public CanvasGroup canvasGroup;
    void Start()
    {
        this.canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0, 2);
        //this.GetComponent()
    }
}
