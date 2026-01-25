using UnityEngine;

public class WaveMovement : MonoBehaviour
{

    //defining variables
    public float startPosx;
    public float startPosy;
    public float endPosx;
    public float endPosy;

    public float t = 0f;
    public AnimationCurve curvex;
    public AnimationCurve curvey;

    bool forwards = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if the wave is moving forwards
        if (forwards)
        {
            //make the time move forwards
            t += Time.deltaTime;
        }
        else //if the wave is moving backwards
        {
            //make the time move backwards
            t -= Time.deltaTime;
        }
        //if the wave has reached the endpoint
        if (t > 1f)
        {
            t = 1f;

            //make the wave begin to move backwards
            forwards = false;
        }

        //if the wave has reached the startpoint
        if (t < 0f)
        {
            t = 0f;

            //make the wave begin to move forwards
            forwards = true;
        }

        Vector2 wavePos = new Vector2(0f, 0f);

        //change the yposition based on the curve and time
        wavePos.x = Mathf.Lerp(startPosx, endPosx, curvex.Evaluate(t));

        //change the xpoition based on a separate curve and time
        wavePos.y = Mathf.Lerp(startPosy, endPosy, curvey.Evaluate(t));

        transform.position = wavePos;       
    }
}
