using UnityEngine;

public class ParticleLogic : MonoBehaviour
{
    public float speed;
    //spawn point for the particle
    public float spawnPoint;
    //other end of the interpolation
    private float fallPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //initial spawn
        spawnPoint = 0;
        //initial despawn
        fallPoint = spawnPoint - 4f;
    }

    // Update is called once per frame
    void Update()
    {
        //respawn logic


        Vector3 rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = rotation;


    }
}
