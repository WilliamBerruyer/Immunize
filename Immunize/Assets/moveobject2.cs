using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject2 : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    float m_Speed, degreesPerSecond;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 1500)
        {
            i++;
        }
        if (i >= 1500 && i < 6500)
        {
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
            i++;
        }
    }
}
