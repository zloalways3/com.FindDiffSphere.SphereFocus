using UnityEngine;

public class ClickHandler2 : MonoBehaviour
{
  private RandomPrefabGenerator2 prefabGenerator2;
  private int objectID2;

  public void Init2(RandomPrefabGenerator2 generator2, int id)
  {
    void Func2()
    {
      prefabGenerator2 = generator2;
      objectID2 = id;
    }

    Func2();
  }

  void OnMouseDown()
  {
    if (objectID2 == 1)
    {
      gameObject.SetActive(false);
      prefabGenerator2.AddScore2(prefabGenerator2.AddScoreCount2, objectID2);
    }
  }
}