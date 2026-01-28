using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0f;
    public float lengthOfInterpolation = 1;

    public AnimationCurve easing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > lengthOfInterpolation)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, easing.Evaluate(t));
    }
}
