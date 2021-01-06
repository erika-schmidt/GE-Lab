using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public AudioClip ButtonSound;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, transform.position);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, transform.position);
        SceneManager.LoadScene("Menu");
    }


}
