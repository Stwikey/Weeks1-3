using UnityEngine;
using UnityEngine.InputSystem;

public class TargetClick : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if(mousePos.x > target.position.x - 3 && mousePos.x < target.position.x + 3 && mousePos.x > target.position.y - 3 && mousePos.x < target.position.y + 3)
        {
            transform.position = new Vector2(1000f, 1000f);
        }

        

    }
}
