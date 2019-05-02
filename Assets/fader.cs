using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fader : MonoBehaviour {

    public digitalClock clock;

    public CanvasGroup uiElement;


	public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
        //needs to stop corotine
    }
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
        //needs to stop corotine
    }

    public IEnumerator FadeCanvasGroup (CanvasGroup cg, float start, float end, float lerpTime = 5.5f) {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while(true)
        {
            
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            cg.alpha = currentValue;


            if (percentageComplete >= 1) break;

            yield return new WaitForEndOfFrame();
        }

        print("done");
		
	}

    void Update()
    {
       if(clock.nightTime)
        {
            FadeOut();
        }
    }
}
