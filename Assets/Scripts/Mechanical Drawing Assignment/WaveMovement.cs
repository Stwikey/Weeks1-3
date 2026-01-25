using UnityEngine;

public class WaveMovement : MonoBehaviour
{
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
        if (forwards)
        {
            t += Time.deltaTime;
        }
        else
        {
            t -= Time.deltaTime;
        }

        if (t > 1f)
        {
            t = 1f;
            forwards = false;
        }

        if (t < 0f)
        {
            t = 0f;
            forwards = true;
        }

        Vector2 wavePos = new Vector2(0f, 0f);
        wavePos.x = Mathf.Lerp(startPosx, endPosx, curvex.Evaluate(t));
        wavePos.y = Mathf.Lerp(startPosy, endPosy, curvey.Evaluate(t));
        transform.position = wavePos;       
    }
}
