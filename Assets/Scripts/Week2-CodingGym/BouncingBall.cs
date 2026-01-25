using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speedx = 10f;
    public float speedy = 7f;
    public Vector2 screenSize;


    void Start()
    {
        screenSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition;
        newPosition.x = transform.position.x + speedx * Time.deltaTime;
        newPosition.y = transform.position.y + speedy * Time.deltaTime;

        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < -10)
        {
            transform.position = new Vector2(-10f, transform.position.y);
            speedx *= -1;
        }
        if (screenPos.x > Screen.width)
        {
            transform.position = new Vector2(screenSize.x, transform.position.y);
            speedx *= -1;
        }
        if (screenPos.y < -5)
        {
            transform.position = new Vector2(transform.position.x, -5f);
            speedy *= -1;
        }
        if (screenPos.y > Screen.height)
        {
            transform.position = new Vector2(transform.position.x, screenSize.y);
            speedy *= -1;
        }
    }
}
