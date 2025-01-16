using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //переменная для количества монет
    public int coins_amount = 0;
    //переменная для текстовой надписи
    public TextMeshProUGUI textcoins;
    void Update()
    {
     //на текстовой надписи меняем текст = кол-во_монет.Перевод в символы
        textcoins.text = coins_amount.ToString();
    //число(int) нельзя отобразить поэтому меняем цифры на символы командой ToString
    }
    //при столкновении с ЛЮБЫМ тригером
    private void OnTriggerEnter(Collider other)
    {
        //добавляем условие чтобы различить объекты с которыми сталкиваемся
        if (other.tag == "moneta") //когда сталкиваемся с объектом с ТЭГОМ moneta
        {
            coins_amount++; //увеличиваем кол-во монет на 1
            Destroy(other.gameObject);//уничтожаем монету
        }

    }
}


