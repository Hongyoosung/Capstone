using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostManager : MonoBehaviour
{
    public GameObject baseObject;
    public Text resourceText;

    private Base baseScript;

    private void Awake()
    {
        if (baseObject != null)
        {
            baseObject = Instantiate(baseObject);
            GameController.instance.playerBaseObject = baseObject;
            baseScript = baseObject.GetComponent<Base>();
        }
    }

    private void Update()
    {
        if (baseScript != null && resourceText != null)
        {
            // Base ��ũ��Ʈ���� �ڿ� ���� ������ UI�� ǥ��
            resourceText.text = "Resources: " + baseScript.GetResource().ToString();
        }
    }
}
