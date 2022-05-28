using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleForward : MonoBehaviour
{
    public Vector2 Dir;

    [SerializeField] float Speed;

    // Update is called once per frame
    void Update()
    {
        Vector2 NextPos = Dir * Time.deltaTime * Speed;
        transform.position = new Vector3(NextPos.x + transform.position.x, NextPos.y + transform.position.y);
    }
}
