using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomPrefabGenerator2 : MonoBehaviour
{
    public event Action LevelCompleted2;

    public int ScoreThreshold2 = 10;
    public int CurrentScore2 = 0;
    public int AddScoreCount2 = 1;

    [SerializeField] private GameObject[] _prefabs2;

    private int totalObjectsWithID2 = 0;
    private int clickedObjectsWithID2 = 0;

    void Start()
    {
        GenerateRandomPrefabs2();
    }

    void GenerateRandomPrefabs2()
    {
        void Func2()
        {
            totalObjectsWithID2 = 0;
            clickedObjectsWithID2 = 0;

            GridLayout2 gridLayout2 = GetComponent<GridLayout2>();
            if (gridLayout2 == null)
            {
                Debug.LogError("Component GridLayout did not find inside object!");
                return;
            }

            int totalObjects2 = gridLayout2.Rows2 * gridLayout2.Columns2;
            RemoveExistingChildren2();

            for (int i3 = 0; i3 < totalObjects2; i3++)
            {
                if (_prefabs2.Length == 0)
                {
                    Debug.LogWarning("Not prefabs for generate!");
                    return;
                }

                GameObject prefab2 = _prefabs2[GenerateWithRatio2()];
                GameObject instance2 = Instantiate(prefab2, transform);
                instance2.name = prefab2.name + "__" + i3;

                AddClickHandler2(instance2);
            }

            if (totalObjectsWithID2 == 0)
            {
                Debug.LogWarning("No objects with ID = 1 created. Generated...");
                GenerateRandomPrefabs2();
            }
            else
            {
                gridLayout2.ArrangeChildrenInGrid2();
            }
        }

        Func2();
    }

    int GenerateWithRatio2()
    {
        int Func2()
        {
            int randomValue2 = Random.Range(0, 100);

            if (randomValue2 < 80)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        return Func2();
    }

    void AddClickHandler2(GameObject instance)
    {
        void Func2()
        {
            ObjectIDComponent2 idComponent2 = instance.GetComponent<ObjectIDComponent2>();
            if (idComponent2 == null)
            {
                Debug.LogWarning($"ObjectIDComponent did not find inside object {instance.name}");
                return;
            }

            if (idComponent2.ID == 1)
            {
                totalObjectsWithID2++;
            }

            instance.AddComponent<BoxCollider2D>();
            instance.AddComponent<ClickHandler2>().Init2(this, idComponent2.ID);
        }

        Func2();
    }

    void RemoveExistingChildren2()
    {
        void Func2()
        {
            for (int i2 = transform.childCount - 1; i2 >= 0; i2--)
            {
                Transform child2 = transform.GetChild(i2);
                if (Application.isPlaying)
                {
                    Destroy(child2.gameObject);
                }
                else
                {
                    DestroyImmediate(child2.gameObject);
                }
            }
        }

        Func2();
    }

    public void AddScore2(int value, int objectID)
    {
        void FirstFunc2()
        {
            if (objectID == 1)
            {
                clickedObjectsWithID2++;
                Debug.Log($"Cliked objects with ID = 1: {clickedObjectsWithID2}/{totalObjectsWithID2}");

                if (clickedObjectsWithID2 >= totalObjectsWithID2)
                {
                    Debug.Log("All objects with ID = 1 clicked, generate new!");
                    GenerateRandomPrefabs2();
                }
            }
        }

        void SecondFunc2()
        {
            if (CurrentScore2 >= ScoreThreshold2)
            {
                LevelCompleted2?.Invoke();
                Debug.Log("Level Completed");
            }
        }

        CurrentScore2 += value;
        Debug.Log($"Current score: {CurrentScore2}");

        FirstFunc2();

        SecondFunc2();
    }
}
