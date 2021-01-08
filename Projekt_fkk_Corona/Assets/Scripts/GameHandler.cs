using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins = 0;
    private int coinCount;

    // Update is called once per frame
    void Update()
    {
        CoinText.text = "" + coins;
    }

    public void OnDeath()
    {
        coinCount = PlayerPrefs.GetInt("Coins") + coins;
        PlayerPrefs.SetInt("Coins", coinCount);
        Debug.Log("Coin Counted:" + coins);
    }
}
