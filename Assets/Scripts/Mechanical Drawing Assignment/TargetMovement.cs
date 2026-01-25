using UnityEngine;

public class TargetMovement : MonoBehaviour
{

    //defining variables
    public float startPos;
    public float endPos;
    public float t = 0f;
    public AnimationCurve curve;

    bool forwards = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if the targets are moving forwards
        if (forwards)
        {
            //move the time forwards
            t += Time.deltaTime;
        }
        else //if the target is moving backwards 
        {
            //move the time backwards
            t -= Time.deltaTime;
        }

        //if the target has reached the endpoint
        if (t > 1f)
        {
            t = 1f;

            //set the target to begin to move backwards
            forwards = false;
        }

        //if the target has reached the startpoint
        if (t < 0f)
        {
            t = 0f;

            //set the target to begin to move forwards
            forwards = true;
        }

        //change the target xposition based on the time and curve
        Vector2 targetPos = new Vector2(0f, transform.position.y);
        targetPos.x = Mathf.Lerp(startPos, endPos, curve.Evaluate(t));
        transform.position = targetPos;
    }
}
