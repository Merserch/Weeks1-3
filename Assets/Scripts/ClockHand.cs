using UnityEngine;
using UnityEngine.InputSystem;

public class ClockHand2 : MonoBehaviour
{
    public int handType; // 0 = hour, 1 = minute, 2 = second
    public float handSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (handType == 0)
        {
            handSpeed = -6f; // degrees per second for hour hand
        }
        else if (handType == 1)
        {
            handSpeed = -30f; // degrees per second for minute hand
        }
        else if (handType == 2)
        {
            handSpeed = -360f; // degrees per second for second hand
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += handSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }
}
