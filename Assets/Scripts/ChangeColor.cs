using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private float timeToChange = 0.5f;
    private float timeSinceChanged = 0f;
    public Renderer render;
    private Material origMaterial;
    public Material nextMaterial;

    void Awake()
    {
        render = GetComponent<Renderer>();
        origMaterial = render.material;
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        timeSinceChanged += Time.deltaTime;
        render.material = origMaterial;

        if (timeSinceChanged > timeToChange)
        {
            render.material = nextMaterial;
            
            timeSinceChanged = 0f;           
            //render.material.color = Random.ColorHSV();
        }

    }
}