using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxStamina;
    public HealtBar healt;

    private float playerSpeed;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }


}
