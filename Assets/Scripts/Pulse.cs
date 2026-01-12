using UnityEngine;

public class Pulse : MonoBehaviour
{
    public AnimationCurve curve;
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > 1)
        {
            t = 0;
        }

        float y = curve.Evaluate(t);
        //Vector3.one is the same as a vector with 1s in every column
        Vector3 newSize = Vector3.one * y;
        transform.localScale = Vector3.one * curve.Evaluate(t);
    }
}
