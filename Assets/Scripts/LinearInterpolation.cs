using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Vector2 start;
    public Vector2 end;
    public float t = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start, end, t);
    }
}
