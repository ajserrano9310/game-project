using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{

    public Slider slider;

    public const float staminaDrain = 10f;
    public const float staminaRegenValue = 10f;
    public const float maxStamina = 100f; 


    private bool isSprinting = false;
    private bool canSprint = true;

    public bool IsSprinting { get => isSprinting; set => isSprinting = value; }
    public bool CanSprint { get => canSprint; set => canSprint = value; }

    public void Sprint()
    {
        slider.value -= staminaDrain * Time.deltaTime; 
    }

    public void RegenerateStamina()
    {

        if(slider.value == maxStamina)
        {
            return; 
        }

        slider.value += staminaRegenValue * Time.deltaTime; 
    }

    public float GetCurrentStamina()
    {
        return slider.value; 
    }
}
