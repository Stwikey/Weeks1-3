using UnityEngine;
using UnityEngine.InputSystem;

public class TargetClick : MonoBehaviour
{
    //defining variables
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
        //keeps a timer
        t += Time.deltaTime;

        //if the timer reached 3 seconds and the target has been shot
        if (t > 3f && shot == true)
        {
            //change the target back to not shot
            shot = false;

            //return the target to the position of the broken stick (so it looks like it is back to normal)
            transform.position = new Vector2(stick.position.x + 0.1f, stick.position.y +3);
        }

        //change the mouse position from screen units to world units
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //if the target is currently active (not shot) and it is hovering over the target
        if (shot == false && mousePos.x > target.position.x - 1 && mousePos.x < target.position.x + 1 && mousePos.y > target.position.y - 1 && mousePos.y < target.position.y + 1)
        {
            //change the target to be shot
            shot = true;

            //send the target off screen
            transform.position = new Vector2(1000f, 1000f);

            //start the timer (reset jt)
            t = 0f;
        }

        

    }
}
