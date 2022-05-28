using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoySpawner : SingletonMonoBehavior<BoySpawner>
{
    [SerializeField]
    float Radius;
    public static GameObject Spawn()
    {
        return ResourcesSpawner.Spawn("Boy", GetRandomSpawnPoint());
    }

    static Vector3 GetRandomSpawnPoint()
    {
        Vector2 RandomCircle = Random.insideUnitCircle * instance.Radius;
        return new Vector3(RandomCircle.x, RandomCircle.y, 0);
    }
}
