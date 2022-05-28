using UnityEngine;

public class SectorDetection : MonoBehaviour
{
    public float Distance;//The radius of the sector
    public float Angle;//The angle of the sector

    public Transform targetTrans;//Target position (enemy position)

    public bool IsTargetInSector()
    {
        if (targetTrans == null)
        {
            return false;
        }
        float dis = Vector3.Distance(transform.position, targetTrans.position);
        float angle = Vector3.Angle(transform.forward, targetTrans.position - transform.position);
        return (dis <= Distance && angle <= Angle / 2);
    }

}

