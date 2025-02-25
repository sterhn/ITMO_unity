using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint; // Точка назначения

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = teleportPoint.position; // Телепортируем любой объект
    }
}
