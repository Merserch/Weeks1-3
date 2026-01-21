using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomColour();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    //PickARandomColour();
        //}

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite?
        if(spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
