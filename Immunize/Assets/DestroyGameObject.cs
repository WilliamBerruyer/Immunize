using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("True"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("False"))
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("GameOverPoint"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
