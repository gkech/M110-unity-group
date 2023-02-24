using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFuture : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("FutureScene");
    }
}