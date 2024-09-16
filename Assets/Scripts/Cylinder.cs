using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderInteractable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Цилиндр взаимодействует!");
    }
}
