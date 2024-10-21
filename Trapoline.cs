using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10;
        // Увеличение силы прыжка
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
        // Уменьшение силы прыжка
    }
}
