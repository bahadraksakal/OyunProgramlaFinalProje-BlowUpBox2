using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 4.8f;
    private bool start = false;
    private Rigidbody2D rb;
    [SerializeField]
    private BallControl1 ballControlScript;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballControlScript = GameObject.Find("ball").GetComponent<BallControl1>();    
    }
    void Update()
    {
        if(ballControlScript.rb.velocity == Vector2.zero){ //topun hýzý yoksa oyun baslamamýs demek
            start = false;
        }
        else
        {
            start = true;
        }

        if(start == true){
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            transform.Translate(x, 0, 0);
            rb.velocity = Vector2.zero;//gereksiz kayma olusmamasi icin
        }
        else
        {
            transform.Translate(0, 0, 0);
            rb.velocity = Vector2.zero;//gereksiz kayma olusmamasi icin
        }
    }
}
