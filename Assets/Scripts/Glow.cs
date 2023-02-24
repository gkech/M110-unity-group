using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public bool isGlowing = false;

    public GameObject objectToGlow;


    public void glow() {
        isGlowing = true;
        objectToGlow.SetActive(true);
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
{
    yield return new WaitForSecondsRealtime(1);
    isGlowing = false;
    objectToGlow.SetActive(false);
}
}
