using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;

public class SimplifyMesh : MonoBehaviour
{
    // Start is called before the first frame update
    public float quality = 0.4f;
    

    void Awake()
    {

        var originalMesh = GetComponent<MeshFilter>().mesh;
        var meshSimplifier = new UnityMeshSimplifier.MeshSimplifier();
        meshSimplifier.Initialize(originalMesh);
        meshSimplifier.SimplifyMesh(quality);
        var destMesh = meshSimplifier.ToMesh();
        GetComponent<MeshFilter>().mesh = destMesh;
        Debug.Log("Mesh changed");

    }
}
