using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    public Light pointLight;
    public AudioSource audioSource;
    public float blinkIntervalInSecond = 0.5f; // interval flr blink in seconds
    public float timeoutBlinkSecond = 5f; // interval flr blink in seconds

    // Start is called before the first frame update
    void Start()
    {
        resetGame();
    }

    void ToggleLight()
    {
        // toggle the light on or off
        pointLight.enabled = !pointLight.enabled;
    }

    void changeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetGame()
    {
        audioSource.mute = false;
        // start the repeating function
        InvokeRepeating("ToggleLight", blinkIntervalInSecond, blinkIntervalInSecond);
        Invoke("changeScene", timeoutBlinkSecond);
        
        //System.Console.WriteLine("test");
    }
}
