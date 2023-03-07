using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OculusSampleFramework;
using System.IO;
using System;

public class PlantTouch : MonoBehaviour
{
    [SerializeField] public string nextScene; // Name of the next scene to load
    [SerializeField] public ParticleSystem bloodParticles; // Reference to the blood particle system
    [SerializeField] public GameObject dialog; // Reference to the blood particle system

    
    public bool enableBlood;

    private void Start()
    {
        //Invoke("LoadNextScene", 3f);
        dialog.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Console.WriteLine("Tag");
        Console.WriteLine(other);
        // Check if the collider belongs to a hand
        if (other.CompareTag("PlayerHand"))
        {
            if (enableBlood)
            {
                // Spawn blood particles at the location of the user's hand
                SpawnBloodParticles(other.transform);

                // Load the next scene after a delay
                Invoke("LoadNextScene", 1.5f);
            }
            else
            {
                dialog.SetActive(true);
                Invoke("LoadNextScene", 1.5f);
            }
        }
    }


    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene); // Load the next scene
       // SceneManager.UnloadSceneAsync("EntryScene"); 
    }

    private void SpawnBloodParticles(Transform handTransform)
    {
        // Instantiate the blood particle effect at the hand position
        ParticleSystem bloodEffect = Instantiate(bloodParticles, handTransform.position, Quaternion.identity);

        // Attach the blood particle effect to the hand transform as a child
        bloodEffect.transform.SetParent(handTransform);

        // Play the blood particle effect
        bloodEffect.Play();
    }
}