using System.Collections;
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
            Death();
            Debug.Log("sdsds");
            DeathMenu.SetActive(true);
            anim.SetTrigger("death");

            //Destroy(gameObject);
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
        }
    }

    void Death()
    {
        GetComponent<Score>().OnDeath();
        GetComponent<GameHandler>().OnDeath();
    }

}
