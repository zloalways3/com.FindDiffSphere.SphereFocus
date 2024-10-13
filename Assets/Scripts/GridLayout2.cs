using UnityEngine;

[ExecuteInEditMode]
public class GridLayout2 : MonoBehaviour
{
    public int Rows2 = 2; 
    public int Columns2 = 2;  
    public Vector2 CellSize2 = new Vector2(1, 1);  
    public Vector2 Spacing2 = new Vector2(0.5f, 0.5f); 

    void Start()
    {
        int SetValues2(out Vector3 vector3)
        {
            int i = transform.childCount;
            float gridWidth2 = (Columns2 - 1) * (CellSize2.x + Spacing2.x);
            float gridHeight2 = (Rows2 - 1) * (CellSize2.y + Spacing2.y);
            vector3 = new Vector3(-gridWidth2 / 2, gridHeight2 / 2, 0);
            return i;
        }

        var childCount2 = SetValues2(out var startPosition2);

        CreateTable2(childCount2, startPosition2);
    }

    void Update()
    {
        int SetValues2(out Vector3 vector3)
        {
            int i = transform.childCount;
            float gridWidth2 = (Columns2 - 1) * (CellSize2.x + Spacing2.x);
            float gridHeight2 = (Rows2 - 1) * (CellSize2.y + Spacing2.y);
            vector3 = new Vector3(-gridWidth2 / 2, gridHeight2 / 2, 0);
            return i;
        }

        var childCount2 = SetValues2(out var startPosition2);

        CreateTable2(childCount2, startPosition2);
    }

    public void ArrangeChildrenInGrid2()
    {
        int SetValues2(out Vector3 vector3)
        {
            int i = transform.childCount;
            float gridWidth2 = (Columns2 - 1) * (CellSize2.x + Spacing2.x);
            float gridHeight2 = (Rows2 - 1) * (CellSize2.y + Spacing2.y);
            vector3 = new Vector3(-gridWidth2 / 2, gridHeight2 / 2, 0);
            return i;
        }

        var childCount2 = SetValues2(out var startPosition2);

        CreateTable2(childCount2, startPosition2);
    }

    private void CreateTable2(int childCount2, Vector3 startPosition)
    {
        Vector3 Calculate2(int i5)
        {
            int row2 = i5 / Columns2;
            int column2 = i5 % Columns2;

            Vector3 position2 = new Vector3(
                column2 * (CellSize2.x + Spacing2.x),
                -row2 * (CellSize2.y + Spacing2.y),
                0);
            return position2;
        }

        void SetPositions2(int i5, Vector3 position2)
        {
            Transform child2 = transform.GetChild(i5);
            child2.localPosition = startPosition + position2;
            child2.localScale = new Vector3(CellSize2.x, CellSize2.y, 1);
        }

        for (int i5 = 0; i5 < childCount2; i5++)
        {
            Vector3 position2 = Calculate2(i5);

            SetPositions2(i5, position2);
        }
    }
}
