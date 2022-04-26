using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomInputs : MonoBehaviour
{
    [HideInInspector]
    public bool CompassButtonPressed;

    public void OnCompass(InputValue value)
    {
        CompassButtonPressed = value.isPressed;
    }
}
