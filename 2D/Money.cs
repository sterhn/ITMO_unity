using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coins_ui;
    void Update()
    {
        coins_ui.text=coins.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin") 
        {
            print("игрок собрал монетку");
            coins++;
            Destroy(collision.gameObject);
        }
    }
}
