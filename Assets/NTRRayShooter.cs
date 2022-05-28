using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class NTRRayShooter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Player.instance.OnShoot();
            ShootSalmon();
        }
    }



    void ShootSalmon()
    {
        GameObject NTRBullet = ResourcesSpawner.Spawn("NTRBullet", transform.position, 5f);
        NTRBullet.GetComponent<SimpleForward>().Dir = GetComponent<MouseWatcher>().GetLookAtMouseDir();
    }
}
