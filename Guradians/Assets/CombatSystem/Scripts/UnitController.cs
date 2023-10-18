using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;

public enum UnitType
{
    Rabbit, Turtle, Fox, Deer, WoodCutter, Fairy, Heungbu, Nolbu, Swallow 
}

[Serializable]
public class UnitStats
{
    public float attack;      // ���ݷ�
    public float defend;      // ����
    public float healthPoint; // ü��
    public float attackSpeed; // ���ݼӵ�
    public float moveSpeed;   // �̵��ӵ�
    public float delay;       // ����ð�
    public int attackType;    // ��������
    public float length;      // ��Ÿ�
    public int coast;         // �ڽ�Ʈ
}


public class UnitController : MonoBehaviour
{
    [SerializeField] private UnitStatsSO[] _preStats;

    //[SerializeField] private UnitStatsSO _preStats;
    [SerializeField] private UnitStats _stats;

    public UnitType unit;
    public int index;
    private Transform _transform;


    // Start is called before the first frame update

    void Start()
    {
        if (_preStats is not null)
        {
            _stats = _preStats[index].stats;
        }
        unit = (UnitType)index;
        _transform = GetComponent<Transform>();

        _transform.position = _preStats[index].defaultPosition;
        _transform.localScale = _preStats[index].defaultScale;
        _transform.rotation = Quaternion.Euler(_preStats[index].defaultRotation);
        GetComponent<SpriteRenderer>().sprite = _preStats[index].image;
        GetComponent<Animator>().runtimeAnimatorController = _preStats[index].animatorController;

        Debug.Log(unit);
    }

    void Update()
    {
    }

    // Update is called once per frame


    public void SpawnUnit(int num)
    {
        index = num;
        Instantiate(this);
    }
}