using UnityEngine;
using UnityEngine.InputSystem;

public class TargetClick : MonoBehaviour
{
    public Transform target;
    public Transform stick;
    float t = 0f;
    bool shot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 3f && shot == true)
        {
            shot = false;
            transform.position = new Vector2(stick.position.x + 0.1f, stick.position.y +3);
        }
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if(shot == false && mousePos.x > target.position.x - 1 && mousePos.x < target.position.x + 1 && mousePos.y > target.position.y - 1 && mousePos.y < target.position.y + 1)
        {
            shot = true;
            transform.position = new Vector2(1000f, 1000f);
            t = 0f;
        }

        

    }
}
