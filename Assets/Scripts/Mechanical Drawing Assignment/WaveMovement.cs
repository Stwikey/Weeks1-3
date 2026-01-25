using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
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

        transform.position = Vector2.Lerp(startPos.position, endPos.position, curve.Evaluate(t));

        Debug.Log(t);
       
    }
}
