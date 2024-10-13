using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreenManager2 : MonoBehaviour
{
  [SerializeField] private GameObject _loadingScreenCanvas2; 
  [SerializeField] private Slider _slider;
  
  void Start()
  {
    StartCoroutine(HideLoadingScreenAfterDelay2(1f, 1.5f));  
  }

  private IEnumerator HideLoadingScreenAfterDelay2(float targetValue, float delay)
  {
    float startValue = _slider.value;
    float timeElapsed = 0f;

    while (timeElapsed < delay)
    {
      timeElapsed += Time.deltaTime;
      _slider.value = Mathf.Lerp(startValue, targetValue, timeElapsed / delay);

      yield return null;
    }

    _slider.value = targetValue;

    CanvasGroup canvasGroup2 = _loadingScreenCanvas2.GetComponent<CanvasGroup>();
    if (canvasGroup2 != null)
    {
      float startAlpha2 = canvasGroup2.alpha;
      float endAlpha2 = 0f;
      float fadeDuration2 = 1f;
      float elapsedFadeTime2 = 0f;

      while (elapsedFadeTime2 < fadeDuration2)
      {
        elapsedFadeTime2 += Time.deltaTime;
        canvasGroup2.alpha = Mathf.Lerp(startAlpha2, endAlpha2, elapsedFadeTime2 / fadeDuration2);
        yield return null;
      }

      canvasGroup2.alpha = endAlpha2;
      _loadingScreenCanvas2.SetActive(false);  
    }
  }
}