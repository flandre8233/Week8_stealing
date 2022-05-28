using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMaster : MonoBehaviour
{
    [SerializeField]
    Belong belong;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3((IsMasterLeftSide()) ? 1 : -1, 1, 1);
    }

    bool IsMasterLeftSide()
    {
        if (!belong.GetMaster())
        {
            return false;
        }
        return belong.GetMaster().position.x - transform.position.x <= 0;
    }

}
