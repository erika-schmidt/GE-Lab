using System.Collections;
using System.Collections.Generic;
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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, verVel, speed);
        speed = speed * 1.00002f;

        if ((Input.GetKeyDown(moveL)) && (laneNum>1) && (controlLocked == "n"))
        {
            AudioSource.PlayClipAtPoint(SlideSound, transform.position, 0.5f);
            horizVel = -3; 
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";

        }


        if((Input.GetKeyDown(moveR)) && (laneNum<3) && (controlLocked == "n"))
        {
            AudioSource.PlayClipAtPoint(SlideSound, transform.position, 0.5f);
            horizVel = 3;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";

        }
        if (Input.GetButtonDown("Submit"))
        {
            verVel = 5;
            StartCoroutine(stopJump());
        }
    }

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(.5f);
        verVel = -5;
        yield return new WaitForSeconds(.5f);
        verVel = 0;
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
