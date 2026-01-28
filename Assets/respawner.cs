using UnityEngine;

public class respawner : MonoBehaviour
{
    private float t;
    
    public float timer = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        t += Time.deltaTime;
        if (t > timer) 
        {
            t = 0;
            transform.position = new Vector3(Random.Range(-8f, 8f),Random.Range(-3f,5f));
            
        }

    }
}
