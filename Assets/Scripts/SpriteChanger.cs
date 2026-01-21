using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels;
    public int randomSpriteIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomSprite();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            //PickARandomColour();
            PickARandomSprite();
        }

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite?
        if(spriteRenderer.bounds.Contains(mousePos))
        {
            //set the colour while hovering
            spriteRenderer.color = col;
        }
        else
        {
            //otherwise set it back to white
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number that is the size of the barrels array
        randomSpriteIndex = Random.Range(0, barrels.Length);
        //use that to set the sprite
        spriteRenderer.sprite = barrels[randomSpriteIndex];

    }
}
