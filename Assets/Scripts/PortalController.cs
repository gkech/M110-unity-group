using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PortalController : MonoBehaviour
{
    public UnityEvent interactAction;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("MPHKA");
        interactAction.Invoke();
    }
}