using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float t = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t >= 3f){
            transform.position = new Vector2(Random.Range(-10, Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width, 0f)).x), Random.Range(-5, Camera.main.ScreenToWorldPoint(new Vector2(0f, Screen.height)).y));
            t = 0f;

        }
    }
}
