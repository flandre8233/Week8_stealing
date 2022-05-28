using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBoySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDogOfBoyGirl", 0, 1f);
    }

    void SpawnDogOfBoyGirl()
    {
        GameObject Boy = BoySpawner.Spawn();
        GameObject Girl = GirlSpawner.Spawn();
        Boy.GetComponent<Belong>().ChangeMaster(Girl.transform);
        Girl.GetComponent<Belong>().ChangeMaster(Boy.transform);
    }
}
