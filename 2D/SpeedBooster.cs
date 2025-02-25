using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    public int speedIncrease = 2; // Насколько увеличивать скорость игрока

    // При входе игрока в триггер увеличиваем скорость
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.speed += speedIncrease;
        }
    }

    // При выходе игрока из триггера возвращаем скорость обратно
    private void OnTriggerExit2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.speed -= speedIncrease;
        }
    }
}
