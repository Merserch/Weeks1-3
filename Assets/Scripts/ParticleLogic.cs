using UnityEngine;

public class ParticleLogic : MonoBehaviour
{
    //speed for falling
    public float speed = 15;

    //spawn point for the particle
    public Transform spawnPoint;

    //other end of the interpolation
    public Transform fallPoint;
    
    //percentage for interp
    public float t;

    //setting the time
    public float interpLength = 3f;

    //animation curve for falling
    public AnimationCurve easing;

    

    //AnimationCurve for the opacity
    public AnimationCurve fading;

    //getting sprite renderer for opacity
    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gets the sprite rendering component
        spriteRenderer = GetComponent<SpriteRenderer>();
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

        //lerping
        transform.position = Vector2.Lerp(spawnPoint.position, fallPoint.position, easing.Evaluate(t/interpLength));

        //opacity, my reference for this code is this youtube video. It is being repurposed using the animation curve   
        // ->  https://www.youtube.com/watch?v=0Szglwf7bAU
        spriteRenderer.color = new Color(1f, 1f, 1f, fading.Evaluate(t/interpLength));

        //rotation
        Vector3 rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = rotation;


    }
}
