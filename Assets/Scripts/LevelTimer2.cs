using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer2 : MonoBehaviour
{
  public Action LevelLost2;

  [SerializeField] private Text _timer2;
  [SerializeField] private Text _winViewTimer2;
  [SerializeField] private Text _loseViewTimer2;
  [SerializeField] private int _maxTimerValue2;

  private void OnEnable()
  {
    SetValueSlider2(_maxTimerValue2);
    StartCoroutine(TimerCoroutine2());
  }

  public void StopTimer2()
  {
    StopAllCoroutines();
  }

  private IEnumerator TimerCoroutine2()
  {
    int maxCount2 = _maxTimerValue2;
    while (maxCount2 > 0)
    {
      yield return new WaitForSeconds(1);
      maxCount2 -= 1;
      SetValueSlider2(maxCount2);
    }

    LevelLost2?.Invoke();
  }

  private void SetValueSlider2(int value)
  {
    _timer2.text = value + "s";
    _winViewTimer2.text = _timer2.text;
    _loseViewTimer2.text = _timer2.text;
  }
}