using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class movecharacter : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public float verVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";

    private float speed = 4;

    public AudioClip SlideSound;
    public AudioClip HitSound;

    public Animator ani;


    // Start is called before the first frame update
    void Start()
    {
        ani = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
  
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, verVel, speed);
        speed = speed * 1.00009f;

        if ((Input.GetKeyDown(moveL)) && (laneNum>1) && (controlLocked == "n"))
        {
            AudioSource.PlayClipAtPoint(SlideSound, transform.position);
            horizVel = -3; 
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
            ani.SetTrigger("swipeleft");

        }


        if((Input.GetKeyDown(moveR)) && (laneNum<3) && (controlLocked == "n"))
        {
            AudioSource.PlayClipAtPoint(SlideSound, transform.position);
            horizVel = 3;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
            ani.SetTrigger("swipe");

        }
        if (Input.GetButtonDown("Submit"))
        {
            verVel = 3;
            StartCoroutine(stopJump());
        }
    }

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(.3f);
        verVel = -3;
        yield return new WaitForSeconds(.3f);
        verVel = 0;
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            speed = 0;
            horizVel = 0;
            verVel = 0;
            AudioSource.PlayClipAtPoint(HitSound, transform.position);
        }
    }
}
