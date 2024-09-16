using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteractable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("—фера взаимодействует!");
    }
}
