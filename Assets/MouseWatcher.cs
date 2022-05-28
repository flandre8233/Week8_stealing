using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MouseWatcher : MonoBehaviour
{
    public Vector2 GetLookAtMouseDir()
    {
        Vector2 MousePos = Mouse.current.position.ReadValue();
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        return (MousePos - new Vector2(transform.position.x, transform.position.y)).normalized;
    }
}
