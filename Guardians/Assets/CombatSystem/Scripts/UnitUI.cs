using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitUI : MonoBehaviour
{
    public GameObject unit;
    public MiniMapTile CurrentTile { get; set; }  // �� ������ ���� ���� Ÿ��
    public Vector2Int boardPosition;


    private void OnMouseDown()
    {

        if (MiniMap.instance != null)
        {
            MiniMap.instance.HighlightMovableTiles(this);
            Debug.Log("UnitUI clicked!");

        } 
    }
}



