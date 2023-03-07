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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("True"))  //White Cell
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("False")) //Red Cell
        {
            //Destroy(this.gameObject);
            Destroy(collision.gameObject);
            this.gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }

        if (collision.collider.CompareTag("GameOverPoint")) //When enemies reach the HeartRoom
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       
    }
}
