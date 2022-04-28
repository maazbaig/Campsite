using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EquipmentAccess : MonoBehaviour
{
    [SerializeField] private GameObject Compass;

    private CustomInputs CustomInputs;

    private void Awake()
    {
        CustomInputs = GetComponent<CustomInputs>();
    }

    void Update()
    {
        ToggleCompass();
    }

    private void ToggleCompass()
    {
        if (CustomInputs.CompassButtonPressed)
        {
            Compass.SetActive(Compass.activeSelf ? false : true);
            CustomInputs.CompassButtonPressed = false;
        }
    }
}
