using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputVariations : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("������� ������ ������");
        }

        if (Input.GetMouseButtonDown(0))
        {
            print("������ ����� ������ ����");
        }
    }
}
