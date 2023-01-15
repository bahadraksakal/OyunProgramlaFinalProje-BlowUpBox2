using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoxCollider : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite brokenBlock;
    public GameObject box;

    int boxHP = 2;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "ball")
        {
            boxHP--;
            spriteRenderer.sprite = brokenBlock;
        }
        if(boxHP == 0)
        {
            Destroy(box);
        }
    }
}
