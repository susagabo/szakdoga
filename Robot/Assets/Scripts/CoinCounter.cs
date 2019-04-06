using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

    int coins=0;
    public Text coinsText;
	// Use this for initialization
	void Start () {
        coinsText.text = "Coins: " + coins;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
