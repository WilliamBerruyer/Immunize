using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Respawn()
    {
        if (i < 200)
        {
            i++;
        }
        if (i >= 200 && i < 201)
        {
            transform.position = new Vector3(-4.849f, 0.818f, -0.242f);
            i++;
        }
    }
}
