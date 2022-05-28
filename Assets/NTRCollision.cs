using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NTRCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Slave")
        {
            OnHitSlave(other.gameObject);
        }
    }

    public void OnHitSlave(GameObject Slave)
    {
        Destroy(gameObject);
        Slave.GetComponent<Belong>().ChangeMasterToPlayer();
    }
}
