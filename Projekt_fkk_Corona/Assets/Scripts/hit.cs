﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    public GameObject DeathMenu;
    public Animator anim;
    public AudioClip hitSound;

    //private bool isDead = false;

    void Start()

    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
            anim.SetTrigger("death");
            DeathMenu.SetActive(true);
            Death();  
        }
    }

    void Death()
    {
        //isDead = true;
        GetComponent<Score>().OnDeath();
    }

}
