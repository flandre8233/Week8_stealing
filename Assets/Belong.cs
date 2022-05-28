using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belong : MonoBehaviour
{
    Transform Master;

    public Transform GetMaster()
    {
        return Master;
    }

    public void ChangeMaster(Transform _Master)
    {
        Master = _Master;
        UpdateFollow();
    }

    public void ChangeMasterToPlayer()
    {
        if (!Player.instance)
        {
            return;
        }
        Master.GetComponent<Belong>().BeNTR();
        ChangeMaster(Player.instance.transform);
        RemoveSlaveTag();
        Player.instance.addSalmon();
        Player.instance.SexSlaveCount += 1;
    }

    void RemoveSlaveTag()
    {
        Destroy(GetComponent<Rigidbody2D>());
        Destroy(GetComponent<Collider2D>());
    }

    void UpdateFollow()
    {
        Follower follower = GetComponent<Follower>();
        if (follower)
        {
            follower.UpdateFollow(Master);
        }
    }

    public Vector3 GetMidpoint()
    {
        return Vector3.Lerp(transform.position, Master ? Master.position : new Vector3(), 0.5f);
    }

    void BeNTR()
    {
        gameObject.AddComponent<NTRed>();
    }
}
