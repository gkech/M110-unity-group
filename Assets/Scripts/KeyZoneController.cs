    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyZoneController : MonoBehaviour
{

    public GameObject portalGlow;
    bool hasPlayed = false;

    public GameObject room;

    public GameObject flashLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnablePortal() {
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
        SceneManager.LoadScene("FutureScene");
    
    }
}
