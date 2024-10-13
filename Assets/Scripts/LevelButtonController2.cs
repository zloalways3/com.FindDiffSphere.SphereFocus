using UnityEngine;
using UnityEngine.UI;

public class LevelButtonController2 : MonoBehaviour
{
    public Button[] levelButtons2;  
    public Sprite lockedSprite2;    
    public Sprite activeSprite2;    
    public Sprite passedSprite2;    
    public NextRetryButton2 NextLevelButton2;
    public NextRetryButton2 ReplayLevelButton2;
    public ScoreDisplay2 _scoreDisplay2;
    public LevelTimer2 _levelTimer2;

    private void Awake()
    {
        NextLevelButton2.LevelButtonController2 = this;
        ReplayLevelButton2.LevelButtonController2 = this;
        _scoreDisplay2.IndexCount2 = levelButtons2.Length;
    }

    private void OnEnable()
    {
        void Func2()
        {
            InitializeButtons2();
        }

        Func2();
    }

    public void InitializeButtons2()
    {
        for (int i2 = 0; i2 < levelButtons2.Length; i2++)
        {
            Button button2 = levelButtons2[i2];
            int levelStatus2;

            if (i2 == 0)
            {
                levelStatus2 = PlayerPrefs.GetInt("Level2" + i2, 1); 
            }
            else
            {
                levelStatus2 = PlayerPrefs.GetInt("Level2" + i2, 0); 
            }

            switch (levelStatus2)
            {
                case 0:
                    SetButtonState2(button2, lockedSprite2, false);
                    break;
                case 1:
                    SetButtonState2(button2, activeSprite2, true);
                    break;
                case 2:
                    SetButtonState2(button2, passedSprite2, true);
                    break;
            }
        }
    }

    void SetButtonState2(Button button, Sprite sprite, bool interactable)
    {
        button.image.sprite = sprite;  
        button.interactable = interactable;  
    }


    public void LevelButtonInvoke2(int levelButtonNumber)
    {
        levelButtons2[levelButtonNumber].onClick.Invoke();
    }
}
