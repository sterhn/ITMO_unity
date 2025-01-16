using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //���������� ��� ���������� �����
    public int coins_amount = 0;
    //���������� ��� ��������� �������
    public TextMeshProUGUI textcoins;
    void Update()
    {
     //�� ��������� ������� ������ ����� = ���-��_�����.������� � �������
        textcoins.text = coins_amount.ToString();
    //�����(int) ������ ���������� ������� ������ ����� �� ������� �������� ToString
    }
    //��� ������������ � ����� ��������
    private void OnTriggerEnter(Collider other)
    {
        //��������� ������� ����� ��������� ������� � �������� ������������
        if (other.tag == "moneta") //����� ������������ � �������� � ����� moneta
        {
            coins_amount++; //����������� ���-�� ����� �� 1
            Destroy(other.gameObject);//���������� ������
        }

    }
}


