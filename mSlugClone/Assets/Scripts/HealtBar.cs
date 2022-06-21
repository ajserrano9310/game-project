using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{

    public Slider slider;
    public int num;

    public void SetHealth(int health)
    {

        slider.value = health;

    }
}
