using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public int HandType; // 0 = hour, 1 = minute, 2 = second
    public float HandSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (HandType == 0)
        {
            HandSpeed = 30f; // degrees per second for hour hand
        }
        else if (HandType == 1)
        {
            HandSpeed = 6f; // degrees per second for minute hand
        }
        else if (HandType == 2)
        {
            HandSpeed = 360f; // degrees per second for second hand
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -HandSpeed * Time.deltaTime);
        }
}
