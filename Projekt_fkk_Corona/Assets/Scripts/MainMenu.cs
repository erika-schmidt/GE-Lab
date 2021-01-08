using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Text highscoreText;
    public Text CoinText;
    public AudioClip ButtonSound;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "HIGHSCORE: " + (int)PlayerPrefs.GetFloat("Highscore");
        CoinText.text = "" + PlayerPrefs.GetInt("Coins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToGame()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, transform.position);
        SceneManager.LoadScene("Game");
    }

}
