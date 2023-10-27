using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapTile : MonoBehaviour
{
    public Vector2Int gridPosition;
    public Vector2Int boardPosition;
    public bool IsMovable { get; set; }  // Whether this tile is currently movable.
    public List<UnitUI> unitsOnTile = new List<UnitUI>();


    public void AddUnit(UnitUI unitUI)
    {
        unitsOnTile.Add(unitUI);
        unitUI.CurrentTile = this;  // ������ ���� ���� Ÿ���� �����մϴ�.
        UpdateUnitPositions();
    }

    public void RemoveUnit(UnitUI unitUI)
    {
        unitsOnTile.Remove(unitUI);
        unitUI.CurrentTile = null;  // ������ �� �̻� ������ �ʴ� Ÿ���� null�� �����մϴ�.
        UpdateUnitPositions();
    }

    private void UpdateUnitPositions()
    {
        // ��ġ�� �ʵ��� ���� ��ġ�� �����ϴ� �ڵ带 ���⿡ �ۼ�...
        for (int i = 0; i < unitsOnTile.Count; i++)
        {
            Vector3 offset = new Vector3(i * 1f, 0, 0);
            unitsOnTile[i].transform.position = unitsOnTile[i].CurrentTile.transform.position + offset;
        }
    }
}
