using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

public class SpawnUnitNode : Action
{
    public SharedGameObject baseGameObject;
    public GameObject unitUIPrefab;

    public override TaskStatus OnUpdate()
    {
        if (baseGameObject == null || baseGameObject.Value == null)
        {
            return TaskStatus.Failure;
        }

        Base baseScript = baseGameObject.Value.GetComponent<Base>();

        if (baseScript == null)
        {
            return TaskStatus.Failure;
        }

        // �ڿ��� ������� Ȯ��
        if (baseScript.GetResource() >= unitUIPrefab.GetComponent<UnitUI>().unit.stats.coast)
        {
            // �ڿ��� ����ϸ� ���� ��ȯ
            Debug.Log(baseScript.position / 10);
            baseScript.SpawnUnit(unitUIPrefab, Unit.Team.Enemy, baseScript.position);
            return TaskStatus.Success;
        }
        else
        {
            // �ڿ��� �����ϸ� ����
            return TaskStatus.Failure;
        }
    }
}
