using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashImage : MonoBehaviour
{
    Image _image = null;
    Coroutine _currentFlashRoutine = null;
    
    private void Awake() {
        _image = GetComponent<Image>();
    }
    public void StartFlash(float seconds, float maxAlpha, Color newColor)
    {
        _image.color = newColor;
        maxAlpha = Mathf.Clamp(maxAlpha, 0 , 1);

        if(_currentFlashRoutine !=null)
        {
            StopCoroutine(_currentFlashRoutine);
            _currentFlashRoutine = StartCoroutine(Flash(seconds,maxAlpha ));
        }

        
    }

    IEnumerator Flash(float secondsForOne, float maxAlpha)
    {
        float flashInDuration = secondsForOne;
        for (float t = 0; t<= flashInDuration; t += Time.deltaTime)
        {
            Color colorThisFrame = _image.color;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
