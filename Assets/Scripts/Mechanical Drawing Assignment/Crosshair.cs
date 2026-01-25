using UnityEngine;
using UnityEngine.InputSystem;


public class Crosshair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //convert the mouse position from screen units to world units
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //making the crosshair follow the mouse position
        transform.position = mousePos;
    }
}
