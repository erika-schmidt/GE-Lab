using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Animator anim;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()

    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            AudioSource.PlayClipAtPoint(jumpSound, transform.position, 0.5f);
            anim.SetTrigger("jump");
            
        }
    }
  
}
