using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausMenu : MonoBehaviour
{
    public AudioClip ButtonSound;

    // Update is called once per frame
    void Update()
    {

    }

    public void Continue()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, transform.position);
    }

    public void Restart()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, transform.position);
        SceneManager.LoadScene("Game");
    }
}
