using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetcontrol : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ResetTheGame()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        //It will be activate the button when all enemies are killed.
        //!!!Change code to go back to the first scene, now it only restarts the scene!!!
        if (gameObjects.Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
