using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed, degreesPerSecond;
    int i = 0;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 0.30f;
    }

    void Update()
    {
        if (i <= 10000)
        {
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
            i++;
        }

    }
}
 