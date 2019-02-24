using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScene : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;

    private void Start()
    {
    	fadeGroup = Object.FindObjectOfType<CanvasGroup>();
        fadeGroup.alpha = 1;
    }

    private void Update()
    {
    	fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
    }
}
