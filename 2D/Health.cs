using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp = 3;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Heart") 
        {
            print("����� ������ ��������");
            hp++;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Trap") 
        {
            print("����� ����� � �������");
            hp--;
        }
    }
}
