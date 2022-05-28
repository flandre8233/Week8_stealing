using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitchRay : MonoBehaviour
{

    public void OnNearToMaster()
    {
        InvokeRepeating("SpawnBitchRay", 0, Random.Range(0.3f, 35f));
    }
    public void OnFarToMaster()
    {
        CancelInvoke();
    }
    public void OnExitToMaster()
    {

    }

    void SpawnBitchRay()
    {
        
        ResourcesSpawner.Spawn("BitchRay", GetComponent<Belong>().GetMidpoint(), 5f);
    }


}
