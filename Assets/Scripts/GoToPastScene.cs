using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPastScene : MonoBehaviour
{
    
    bool hasPlayed = false;
    public GameObject flashLight;
    public GameObject portalGlow;
    public GameObject previousText;
    public GameObject activationText;

    public GameObject light;
    public Renderer render;
    public Material newMaterial;
    public GameObject room;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToPast() {
        
        previousText.SetActive(false);
        activationText.SetActive(true);
        render = GetComponent<Renderer>();
        render.material = newMaterial;
        light.SetActive(false);
        StartCoroutine(ExampleCoroutine());
        hasPlayed=true;
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);

        portalGlow.SetActive(true);
        flashLight.SetActive(true);

        yield return new WaitForSeconds(4);
        room.SetActive(false);

        SceneManager.LoadScene("vrcs");
    
    }
}
