using UnityEngine;

public class TargetMovement : MonoBehaviour
{
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

        Vector2 targetPos = new Vector2(0f, transform.position.y);
        targetPos.x = Mathf.Lerp(startPos, endPos, curve.Evaluate(t));
        transform.position = targetPos;
    }
}
