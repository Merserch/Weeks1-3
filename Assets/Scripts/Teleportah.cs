using UnityEngine;

public class Teleportah : MonoBehaviour
{
    public Vector2 newPos;
    public float t = 0f;
    public float timelimit = 2.211f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        //newPos = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
        newPos = new Vector2(Random.Range(-9f,-2f),Random.Range(5f,-5f));
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        transform.position = newPos;

        if (t > timelimit)
        {
            //newPos = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
            newPos = new Vector2(Random.Range(-9f, -2f), Random.Range(5f, -5f));
            t = 0;
        }
    }
}
