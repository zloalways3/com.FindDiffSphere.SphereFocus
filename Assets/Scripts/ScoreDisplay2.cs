using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay2 : MonoBehaviour
{
  public int IndexCount2 { get; set; }
  
  [SerializeField] private GameObject _winPopup2;
  [SerializeField] private Text _winScore2;
  [SerializeField] private Text _loseScore2;
  
  private RandomPrefabGenerator2 _randomPrefabGenerator2;
  private Text scoreText2;
  private int _levelNumber2;

  void Start()
  {
    scoreText2 = GetComponent<Text>();
  }

  void Update()
  {
    UpdateScoreText2();
  }
  
  public void SetValues2(RandomPrefabGenerator2 randomPrefabGenerator2, int lvlnum)
  {
    _randomPrefabGenerator2 = randomPrefabGenerator2;
    _levelNumber2 = lvlnum;
    randomPrefabGenerator2.LevelCompleted2 += OnLevelCompleted2;
  }

  private void UpdateScoreText2()
  {

    if (_randomPrefabGenerator2 == null) return;
    scoreText2.text = $"{_randomPrefabGenerator2.CurrentScore2}/{_randomPrefabGenerator2.ScoreThreshold2}";
    _loseScore2.text = scoreText2.text;
    _winScore2.text = scoreText2.text;
  }

  private void OnLevelCompleted2()
  {
    SaveCompletedLevel2(_levelNumber2 - 1);
    Destroy(_randomPrefabGenerator2.gameObject);
    _winPopup2.SetActive(true);
  }
  
  private void SaveCompletedLevel2(int levelIndex)
  {
    PlayerPrefs.SetInt("Level2" + levelIndex, 2); 

    if (levelIndex + 1 < IndexCount2 && PlayerPrefs.GetInt("Level2" + (levelIndex + 1)) != 2)
    {
      PlayerPrefs.SetInt("Level2" + (levelIndex + 1), 1); 
    }
  }
}