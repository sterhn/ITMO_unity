using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    public int speedIncrease = 2; // ��������� ����������� �������� ������

    // ��� ����� ������ � ������� ����������� ��������
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.speed += speedIncrease;
        }
    }

    // ��� ������ ������ �� �������� ���������� �������� �������
    private void OnTriggerExit2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.speed -= speedIncrease;
        }
    }
}
