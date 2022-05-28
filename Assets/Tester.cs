using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            GameObject Boy = BoySpawner.Spawn();
            GameObject Girl = GirlSpawner.Spawn();
            Boy.GetComponent<Belong>().ChangeMaster(Girl.transform);
            Girl.GetComponent<Belong>().ChangeMaster(Boy.transform);
        }
    }


}
