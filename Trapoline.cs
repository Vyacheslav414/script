using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10;
        // ���������� ���� ������
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
        // ���������� ���� ������
    }
}
