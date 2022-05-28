using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NTRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GetComponent<LookAtMaster>());
        Destroy(gameObject , 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -90f), Time.deltaTime * 5);
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(), Time.deltaTime * 1.2f);
    }
}
