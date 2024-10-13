using System;
using UnityEngine;

public class NextRetryButton2 : MonoBehaviour
{
  public LevelButtonController2 LevelButtonController2 { get; set; }

  [SerializeField] private GameObject levelsPanel2;
  [SerializeField] private GameObject currentScene2;
  [SerializeField] private BlockVisibilityToggle2 blockVisibilityToggle2;
  [SerializeField] private ButtonType2 buttonType2; 
    
  private int currentLevelIndex2 = -1; 

  private void Awake()
  {
    blockVisibilityToggle2.OnBlocksToggled2 += HandleNextOrRetry2;
  }

  public void UpdateCurrentLevelIndex2(int levelIndex)
  {
    void Func2()
    {
      currentLevelIndex2 = levelIndex;
    }

    Func2();
  }

  private void HandleNextOrRetry2()
  {
    void Func2()
    {
      for (int i2 = 0; i2 < currentScene2.transform.childCount; i2++)
      {
        GameObject level3 = currentScene2.transform.GetChild(i2).gameObject;
        Destroy(level3);
      }

      if (buttonType2 == ButtonType2.Next2)
      {
        if (currentLevelIndex2 == LevelButtonController2.levelButtons2.Length)
        {
          levelsPanel2.SetActive(true);
          return;
        }

        LevelButtonController2.LevelButtonInvoke2(currentLevelIndex2);
      }
      else if (buttonType2 == ButtonType2.Retry2)
      {
        if (currentLevelIndex2 > 0)
        {
          LevelButtonController2.LevelButtonInvoke2(currentLevelIndex2 - 1);
        }
      }
    }

    Func2();
  }
}