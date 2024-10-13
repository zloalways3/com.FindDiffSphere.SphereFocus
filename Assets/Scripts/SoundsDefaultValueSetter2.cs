using UnityEngine;

public class SoundsDefaultValueSetter2 : MonoBehaviour
{
  [SerializeField] private SoundsView2 _soundsView2;
  [SerializeField] private SoundsView2 _musicView2;

  private void Start()
  {
    _soundsView2.SetDefaultValue();
    _musicView2.SetDefaultValue();
  }
}