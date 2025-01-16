using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    //переменная для объекта сюрприза
    //тип данных - игровой объект
    public GameObject surprise;

    void Start()
    { 
        surprise.SetActive(false); //изначально делаем объект неактивным
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "area") //при столкновении с area - невидимая область с коллайдером триггером
        {
            surprise.SetActive(true); //делаем объект активным
        }

    }
}
