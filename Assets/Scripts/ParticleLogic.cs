using UnityEngine;

public class ParticleLogic : MonoBehaviour
{
    public float speed = 15;
    //spawn point for the particle
    public Transform spawnPoint;
    //other end of the interpolation
    public Transform fallPoint;
    //percentage for lerp
    private float t;
    //setting the time
    public float interpLength = 3f;
    //animation curve for falling
    public AnimationCurve easing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //progressing time
        t += Time.deltaTime;
        if (t > interpLength)
        {
            t = 0f;
        }

        //respawn logic


        //lerping
        transform.position = Vector2.Lerp(spawnPoint.position, fallPoint.position, easing.Evaluate(t/interpLength));

        //rotation
        Vector3 rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = rotation;


    }
}
