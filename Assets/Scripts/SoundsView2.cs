using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsView2 : MonoBehaviour
{
  [SerializeField] private Slider _slider;
  [SerializeField] private AudioMixer _audioMixer2;
  [SerializeField] private bool _isSound2;

  private const string Soundsvolumes2 = "SoundsVolumes2";
  private const string Musicsvolumes2 = "MusicsVolumes2";
  
  private Vector3 _initialImagePosition2;

  private void Awake()
  {
    void Func2()
    {
      _slider.onValueChanged.AddListener(OnSliderValueChanged2);
    }

    Func2();
  }

  public void SetDefaultValue()
  {
    OnSliderValueChanged2(_slider.value);
  }

  private void OnSliderValueChanged2(float value) => SetVolume2(value, _isSound2 ? Soundsvolumes2 : Musicsvolumes2);

  private void SetVolume2(float value, string mixerName) => _audioMixer2.SetFloat(mixerName, Mathf.Log10(value) * 20);
}