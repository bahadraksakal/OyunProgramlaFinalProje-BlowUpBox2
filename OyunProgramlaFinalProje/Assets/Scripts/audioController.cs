using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioSource blockBreakSound;
    public AudioSource boingSound;
    public Animator playerAnimator;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "block" || coll.gameObject.tag == "blackBlock")
        {
            blockBreakSound.Play();
        }
        if (coll.gameObject.tag == "player")
        {
            boingSound.Play();
            playerAnimator.SetBool("isHit",true);
        }
        else
        {
            playerAnimator.SetBool("isHit", false);
        }
    }
}
