using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSpawner2 : MonoBehaviour
{
    [SerializeField] private GameObject _levelPrefab2;
    [SerializeField] private Transform _sceneContainer2; 
    [SerializeField] private BlockVisibilityToggle2 _blockVisibilityToggle2;
    [SerializeField] private int lvlnum2; 

    private Text _buttonText2; 
    private LevelButtonController2 _levelButtonController2; 
    private ClickHandler2 clickHandler2;
    private RandomPrefabGenerator2 _randomPrefabGenerator2;
    private GameObject _level4;

    private void Awake()
    {
        void Func2()
        {
            _levelButtonController2 = GetComponentInParent<LevelButtonController2>();
            _buttonText2 = GetComponent<Button>().GetComponentInChildren<Text>();
            _blockVisibilityToggle2.OnBlocksToggled2 += SpawnLevel2;
            _levelButtonController2._levelTimer2.LevelLost2 += OnLevelLost2;
            if (_buttonText2 != null)
            {
                _buttonText2.text = lvlnum2.ToString();
            }
        }

        Func2();
    }

    private void SpawnLevel2()
    {
        void Func2()
        {
            _level4 = Instantiate(_levelPrefab2, _sceneContainer2);
            RandomPrefabGenerator2 randomPrefabGenerator2 = _level4.GetComponent<RandomPrefabGenerator2>();
            randomPrefabGenerator2.LevelCompleted2 += () => _levelButtonController2._levelTimer2.StopTimer2();
            _levelButtonController2._scoreDisplay2.SetValues2(randomPrefabGenerator2, lvlnum2);
            _levelButtonController2.NextLevelButton2.UpdateCurrentLevelIndex2(lvlnum2);
            _levelButtonController2.ReplayLevelButton2.UpdateCurrentLevelIndex2(lvlnum2);
        }

        Func2();
    }

    private void OnLevelLost2()
    {
        DestroyObj();
        
        void DestroyObj()
        {
            Destroy(_level4);
        }
    }


}
