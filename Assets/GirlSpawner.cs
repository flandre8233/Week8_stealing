using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlSpawner : SingletonMonoBehavior<GirlSpawner>
{
    [SerializeField]
    float Radius;
    public static GameObject Spawn()
    {
        return ResourcesSpawner.Spawn("Girl", GetRandomSpawnPoint());
    }

    static Vector3 GetRandomSpawnPoint()
    {
        Vector2 RandomCircle = Random.insideUnitCircle * instance.Radius;
        return new Vector3(RandomCircle.x, RandomCircle.y, 0);
    }
}
