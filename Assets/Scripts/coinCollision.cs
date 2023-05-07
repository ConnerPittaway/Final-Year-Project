using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinCollision : MonoBehaviour
{
    public Collider2D playerCollider;
    public TMP_InputField coinText;
    public checkCode2 codeScript;
    public int coinValue = 1;

    void increaseCoins()
    {
        int currentCoins = int.Parse(coinText.text);
        currentCoins += coinValue;
        codeScript.currentPlayerGold = currentCoins;
        coinText.text = currentCoins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            increaseCoins();
            Audio.Instance.PlaySFX("Coin");
            Destroy(collision.gameObject);
        }
    }
}
