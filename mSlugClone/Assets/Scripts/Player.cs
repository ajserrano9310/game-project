using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public HealtBar healt;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("I just pressed A");
            healt.SetHealth(10);
        }
    }


}
