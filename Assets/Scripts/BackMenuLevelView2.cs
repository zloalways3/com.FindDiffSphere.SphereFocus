using UnityEngine;

public class BackMenuLevelView2 : MonoBehaviour
{
    [SerializeField] private BlockVisibilityToggle2 _blockVisibilityToggle2;
    [SerializeField] private GameObject _scene2;

    private void Awake()
    {
        OnBlocksToggled2();
    }

    private void OnBlocksToggled2()
    {
        _blockVisibilityToggle2.OnBlocksToggled2 += OnButtonClick2;
    }

    private void OnButtonClick2()
    {
        DeleteSceneLevels2();
    }

    private void DeleteSceneLevels2()
    {
        for (int i2 = 0; i2 < _scene2.transform.childCount; i2++)
        {
            ClearScene(i2);
        }

        void ClearScene(int i2)
        {
            GameObject level2 = _scene2.transform.GetChild(i2).gameObject;
            Destroy(level2);
        }
    }
}
