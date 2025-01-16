using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    //���������� ��� ������� ��������
    //��� ������ - ������� ������
    public GameObject surprise;

    void Start()
    { 
        surprise.SetActive(false); //���������� ������ ������ ����������
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "area") //��� ������������ � area - ��������� ������� � ����������� ���������
        {
            surprise.SetActive(true); //������ ������ ��������
        }

    }
}
