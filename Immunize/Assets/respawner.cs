using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawner : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        transform.position = startPos;
    }
}
