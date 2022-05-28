using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Week8_stealing controls;
    Vector2 Dir;
    private void Awake()
    {
        controls = new Week8_stealing();
        controls.Player.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controls.Player.Move.canceled += ctx => Move(new Vector2());
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    void Move(Vector2 _Dir)
    {
        Dir = _Dir;
    }

    private void Update()
    {
        transform.position += new Vector3(Dir.x, Dir.y, 0) *  Time.deltaTime* 5;
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
