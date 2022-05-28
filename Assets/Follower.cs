using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform Target;
    [SerializeField]
    float Distance;

    Vector3 WantedPosition;

    bool Near = false;

    public void UpdateFollow(Transform _Target)
    {
        Target = _Target;
        Distance = Random.Range(0.21f, 1.25f);
        WantedPosition = Random.insideUnitCircle.normalized * Distance;
    }

    // Update is called once per frame
    void Update()
    {

        if (!Target)
        {
            return;
        }
        transform.position = Vector3.Lerp(transform.position, WantedPosition + Target.position, Time.deltaTime);

        if (Near)
        {
            if (!IsNearMaster())
            {
                GetComponent<BitchRay>().OnExitToMaster();
                Near = false;
            }
        }
        else
        {
            if (IsNearMaster())
            {
                GetComponent<BitchRay>().OnNearToMaster();
                Near = true;
            }
        }

        if (Near && !Target.GetComponent<Player>())
        {
            if(Player.instance){
            Player.instance.AddGrudge(3);
            }
        }

    }

    bool IsNearMaster()
    {
        return (Vector3.Distance(transform.position, Target.position) <= Distance * 1.2f);
    }
}
