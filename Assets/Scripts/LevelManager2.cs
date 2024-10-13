using UnityEngine;

public class LevelManager2 : MonoBehaviour
{
    [SerializeField] private GameObject _winView2;
    [SerializeField] private GameObject _loseView2;
    [SerializeField] private LevelTimer2 _levelTimer2;

    private void OnEnable()
    {
        _levelTimer2.LevelLost2 += OnLose2;
    }

    private void OnDestroy()
    {
        _levelTimer2.LevelLost2 -= OnLose2;
    }

    private void OnDisable()
    {
        _levelTimer2.LevelLost2 -= OnLose2;
    }

    private void OnWin2()
    {
        Win();

        void Win()
        {
            _winView2.SetActive(true);
        }
    }

    private void OnLose2()
    {
        Lose();

        void Lose()
        {
            _loseView2.SetActive(true);
        }
    }
}
