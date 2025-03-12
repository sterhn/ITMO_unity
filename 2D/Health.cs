using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp = 3;
    
    public GameObject heart;
    public GameObject heart2;
    public GameObject heart3;
    void Update()
    {
        if (hp == 3)
        { 
            heart.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        if (hp == 2)
        {
            heart.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        
        if (hp == 1)
        {
            heart.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }

        if (hp == 0)
        {
            print("you died");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Heart") 
        {
            print("игрок собрал сердечко");
            hp++;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Trap") 
        {
            print("игрок попал в ловушку");
            hp--;
        }
    }
}
