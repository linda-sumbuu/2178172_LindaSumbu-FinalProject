using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite newSprite;

    public MCMovement popUp;

    public GameObject key;

    bool isOpen = false;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite(newSprite);
            key.gameObject.SetActive(true);
            isOpen = true;
        }

        if(isOpen == true)
        {
            popUp.chest.gameObject.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            key.gameObject.SetActive(false);
        }
    }

    void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

}
