using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        //Get the animator

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Inputspace.GetButtonDown("Jump")) //wert erhöhen
        {
            animator.SetTrigger("Space");
        }
    }
}
